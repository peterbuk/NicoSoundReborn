using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * 
 * References:
 * http://stackoverflow.com/questions/1469764/run-command-prompt-commands
 * http://stackoverflow.com/questions/206323/how-to-execute-command-line-in-c-get-std-out-results
 * 
 * 
 * TO DO:
 * - checkbox to keep mp4 file
 * - hide cmd window, redirect output to GUI
 * - better tag parsing
 */

namespace NicoSoundReborn
{
    public partial class NSRForm : Form
    {
        private bool tagExtracted;

        public NSRForm()
        {
            InitializeComponent();

            tagExtracted = false;
        }


        /***************************************************************************************************************************/

        /*
         * Download button clicked. Start download process.
         */
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // check if proper url is provided
            if (!CheckURL(txtBoxURL.Text))
            {
                statusLabel.Text = "Invalid URL. Enter an appropriate NND URL.";
                txtBoxURL.BackColor = Color.LightPink;
            }
            else
                DownloadCommands();
        }

        /*
         * Change color of textbox back to white
         */
        private void txtBoxRecolor(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.BackColor = Color.White;
        }

        /*
         * About link clicked. Show messagebox info.
         */
        private void lblLinkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string about = "Version 1.2\n" +
                            "Author: Peter Buk\n\n" +
                            "This program makes use of these great utilities:\n" +
                            "https://www.ffmpeg.org/\n" +
                            "http://rg3.github.io/youtube-dl/index.html\n";

            MessageBox.Show(about, "About");
        }

        /*
         *  Changes default values of MP3 tags
         */
        private void chkBoxDefault_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxDefault.Checked == true)
            {
                txtBoxFileName.Enabled = false;
                txtBoxTitle.Enabled = false;
                txtBoxArtist.Enabled = false;
                txtBoxAlbum.Enabled = false;

                txtBoxFileName.Text = "(default from video)";
                txtBoxTitle.Text = "(default from video)";
                txtBoxArtist.Text = "(default from video)";
                txtBoxAlbum.Text = "Nico Nico Douga Music";
            }
            else if (chkBoxDefault.Checked == false)
            {
                txtBoxFileName.Enabled = true;
                txtBoxTitle.Enabled = true;
                txtBoxArtist.Enabled = true;
                txtBoxAlbum.Enabled = true;

                txtBoxFileName.Text = "";
                txtBoxTitle.Text = "";
                txtBoxArtist.Text = "";
                txtBoxAlbum.Text = "";
            }
        }

        /***************************************************************************************************************************/

        /*
         *  Checks for a valid NND url
         */
        private bool CheckURL(string URL)
        {
            Regex r = new Regex("https?://(?:www\\.|secure\\.)?nicovideo\\.jp/watch/((?:[a-z]{2})?[0-9]+)");

            Match m = r.Match(URL);

            if (m.Success)
                return true;
            else
                return false;
        }

        /*
         * Run through all the commands necessary to download a NND video 
         */
        private void DownloadCommands()
        {
            // start a new process
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            // set process params to download
            startInfo.Arguments = "/C youtube-dl " + txtBoxURL.Text;
            startInfo.FileName = "cmd.exe";
            
            /* Gotta figure out how to redirect output
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            */
            
            p.StartInfo = startInfo;
            p.Start();
            statusLabel.Text = "Downloading...";

            /*while (p.HasExited == false)
            {
                lblProgress.Text = p.StandardOutput.ReadToEnd();
                lblProgress.Refresh();
            }*/

            p.WaitForExit();

            statusLabel.Text = "Converting...";

            // extract mp4 name
            string filename = ExtractFileName();

            // set up mp3 tags
            if (chkBoxDefault.Checked == true && filename != null)  // use default
            {
                txtBoxFileName.Text = filename + ".mp3";
                txtBoxTitle.Text = filename;
                txtBoxArtist.Text = filename;  //TODO: attempt to extract artist name...

                tagExtracted = true;
            }
            else if (chkBoxDefault.Checked == true && filename == null) // extracting failed, use placeholders
            {
                txtBoxFileName.Text = "song.mp3";
                txtBoxTitle.Text = "";
                txtBoxArtist.Text = "";

                tagExtracted = false;
            }
            else  // make sure the user inputted file name has *.mp3
            {
                if (txtBoxFileName.Text.Equals("")) // empty filename
                    txtBoxFileName.Text = "song.mp3";
                else
                    if (!txtBoxFileName.Text.EndsWith(".mp3", true, null)) // did not have .mp3
                        txtBoxFileName.Text = txtBoxFileName.Text + ".mp3";

                tagExtracted = true;
            }

            // rename mp4
            startInfo.Arguments = "/C ren *.mp4 tmp.mp4";
            p.Start();
            p.WaitForExit();

            // convert mp4
            startInfo.Arguments = "/C ffmpeg -i tmp.mp4 -f mp3 -ab 320000 -vn " +
                                    "-metadata title=\"" + txtBoxTitle.Text +
                                    "\" -metadata artist=\"" + txtBoxArtist.Text +
                                    "\" -metadata album=\"" + txtBoxAlbum.Text +
                                    "\" " + txtBoxFileName.Text;
            p.Start();
            p.WaitForExit();

            // cleanup
            startInfo.Arguments = "/C del tmp.mp4";
            p.Start();
            p.WaitForExit();

            statusLabel.Text = "Complete!";

            if (!tagExtracted)
                statusLabel.Text = "Error: MP3 tags failed to extract. Placeholders used.";
        }

        /*
         *  Extract the filename of the downloaded mp4
         *  Known issues: will grab the first mp4 found, can't check for latest yet
         */
        private string ExtractFileName()
        {
            string pwd = Path.GetDirectoryName(Application.ExecutablePath);
            string[] filePath = Directory.GetFiles(pwd, "*.mp4");

            if (filePath.Length != 0)
                return Path.GetFileNameWithoutExtension(filePath[0]);
            else
                return null;
        }


    }
}
