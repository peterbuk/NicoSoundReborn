using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * References:
 * http://stackoverflow.com/questions/1469764/run-command-prompt-commands
 * http://stackoverflow.com/questions/206323/how-to-execute-command-line-in-c-get-std-out-results
 * 
 * 
 * TO DO:
 * - checkbox to keep mp4 file
 * - check valid url
 * - hide cmd window, redirect output to GUI
 */

namespace NicoSoundReborn
{
    public partial class NSRForm : Form
    {
        public NSRForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // check if url is provided
            if (txtBoxURL.Text.Equals(""))
                lblProgress.Text = "Enter an appropriate NND URL";
            else
                // TO DO: what if the URL is invalid?
                DownloadCommands();

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
            //startInfo.UseShellExecute = false;
            //startInfo.RedirectStandardOutput = true;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.StartInfo = startInfo;
            p.Start();
            lblProgress.Text = "Downloading...";

            /*while (p.HasExited == false)
            {
                lblProgress.Text = p.StandardOutput.ReadToEnd();
                lblProgress.Refresh();
            }*/

            p.WaitForExit();

            lblProgress.Text = "Converting...";

            // TO DO: extract mp4 name

            // rename mp4
            startInfo.Arguments = "/C ren *.mp4 tmp.mp4";
            p.Start();
            p.WaitForExit();

            // check if user inputted file name, otherwise use default
            // also check for ".mp3" and add automatically if not present
            string fileName;
            if (txtBoxFileName.Text.Equals(""))
                fileName = "song.mp3";
            else
            {
                if (txtBoxFileName.Text.EndsWith(".mp3", true, null))
                    fileName = "\"" + txtBoxFileName.Text + "\"";
                else
                    fileName = "\"" + txtBoxFileName.Text + ".mp3" +"\"";
            }

            // convert mp4
            startInfo.Arguments = "/C ffmpeg -i tmp.mp4 -f mp3 -ab 320000 -vn " + fileName;
            p.Start();
            p.WaitForExit();

            // cleanup
            startInfo.Arguments = "/C del tmp.mp4";
            p.Start();
            p.WaitForExit();

            lblProgress.Text = "Complete!";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string about = "Version 1.1\n" +
                            "Author: Peter Buk\n\n" +
                            "This program makes use of these great utilities:\n" +
                            "https://www.ffmpeg.org/\n" +
                            "http://rg3.github.io/youtube-dl/index.html\n";

            MessageBox.Show(about, "About");
        }

        

    }
}
