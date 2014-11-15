namespace NicoSoundReborn
{
    partial class NSRForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NSRForm));
            this.lblPromptURL = new System.Windows.Forms.Label();
            this.lblPromptFileName = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblLinkAbout = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxFields = new System.Windows.Forms.GroupBox();
            this.txtBoxAlbum = new System.Windows.Forms.TextBox();
            this.txtBoxArtist = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblPromptAlbum = new System.Windows.Forms.Label();
            this.lblPromptArtist = new System.Windows.Forms.Label();
            this.lblPromptTitle = new System.Windows.Forms.Label();
            this.chkBoxDefault = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.boxFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPromptURL
            // 
            this.lblPromptURL.AutoSize = true;
            this.lblPromptURL.Location = new System.Drawing.Point(27, 26);
            this.lblPromptURL.Name = "lblPromptURL";
            this.lblPromptURL.Size = new System.Drawing.Size(59, 13);
            this.lblPromptURL.TabIndex = 0;
            this.lblPromptURL.Text = "NND URL:";
            // 
            // lblPromptFileName
            // 
            this.lblPromptFileName.AutoSize = true;
            this.lblPromptFileName.Location = new System.Drawing.Point(15, 27);
            this.lblPromptFileName.Name = "lblPromptFileName";
            this.lblPromptFileName.Size = new System.Drawing.Size(82, 13);
            this.lblPromptFileName.TabIndex = 1;
            this.lblPromptFileName.Text = "MP3 File Name:";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(30, 42);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(207, 20);
            this.txtBoxURL.TabIndex = 2;
            this.txtBoxURL.Enter += new System.EventHandler(this.txtBoxRecolor);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Enabled = false;
            this.txtBoxFileName.Location = new System.Drawing.Point(18, 43);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(174, 20);
            this.txtBoxFileName.TabIndex = 3;
            this.txtBoxFileName.Text = "(default from video)";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(273, 32);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 39);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblLinkAbout
            // 
            this.lblLinkAbout.AutoSize = true;
            this.lblLinkAbout.Location = new System.Drawing.Point(335, 299);
            this.lblLinkAbout.Name = "lblLinkAbout";
            this.lblLinkAbout.Size = new System.Drawing.Size(35, 13);
            this.lblLinkAbout.TabIndex = 6;
            this.lblLinkAbout.TabStop = true;
            this.lblLinkAbout.Text = "About";
            this.lblLinkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkAbout_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 17);
            this.statusLabel.Text = "Welcome!";
            // 
            // boxFields
            // 
            this.boxFields.Controls.Add(this.chkBoxDefault);
            this.boxFields.Controls.Add(this.txtBoxAlbum);
            this.boxFields.Controls.Add(this.txtBoxArtist);
            this.boxFields.Controls.Add(this.txtBoxTitle);
            this.boxFields.Controls.Add(this.lblPromptAlbum);
            this.boxFields.Controls.Add(this.lblPromptArtist);
            this.boxFields.Controls.Add(this.lblPromptTitle);
            this.boxFields.Controls.Add(this.txtBoxFileName);
            this.boxFields.Controls.Add(this.lblPromptFileName);
            this.boxFields.Location = new System.Drawing.Point(30, 87);
            this.boxFields.Name = "boxFields";
            this.boxFields.Size = new System.Drawing.Size(232, 208);
            this.boxFields.TabIndex = 8;
            this.boxFields.TabStop = false;
            this.boxFields.Text = "MP3 Tags";
            // 
            // txtBoxAlbum
            // 
            this.txtBoxAlbum.Enabled = false;
            this.txtBoxAlbum.Location = new System.Drawing.Point(18, 185);
            this.txtBoxAlbum.Name = "txtBoxAlbum";
            this.txtBoxAlbum.Size = new System.Drawing.Size(174, 20);
            this.txtBoxAlbum.TabIndex = 9;
            this.txtBoxAlbum.Text = "Nico Nico Douga Music";
            // 
            // txtBoxArtist
            // 
            this.txtBoxArtist.Enabled = false;
            this.txtBoxArtist.Location = new System.Drawing.Point(18, 139);
            this.txtBoxArtist.Name = "txtBoxArtist";
            this.txtBoxArtist.Size = new System.Drawing.Size(174, 20);
            this.txtBoxArtist.TabIndex = 8;
            this.txtBoxArtist.Text = "(default from video)";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Enabled = false;
            this.txtBoxTitle.Location = new System.Drawing.Point(18, 91);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(174, 20);
            this.txtBoxTitle.TabIndex = 7;
            this.txtBoxTitle.Text = "(default from video)";
            // 
            // lblPromptAlbum
            // 
            this.lblPromptAlbum.AutoSize = true;
            this.lblPromptAlbum.Location = new System.Drawing.Point(15, 171);
            this.lblPromptAlbum.Name = "lblPromptAlbum";
            this.lblPromptAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblPromptAlbum.TabIndex = 6;
            this.lblPromptAlbum.Text = "Album:";
            // 
            // lblPromptArtist
            // 
            this.lblPromptArtist.AutoSize = true;
            this.lblPromptArtist.Location = new System.Drawing.Point(15, 123);
            this.lblPromptArtist.Name = "lblPromptArtist";
            this.lblPromptArtist.Size = new System.Drawing.Size(33, 13);
            this.lblPromptArtist.TabIndex = 5;
            this.lblPromptArtist.Text = "Artist:";
            // 
            // lblPromptTitle
            // 
            this.lblPromptTitle.AutoSize = true;
            this.lblPromptTitle.Location = new System.Drawing.Point(15, 75);
            this.lblPromptTitle.Name = "lblPromptTitle";
            this.lblPromptTitle.Size = new System.Drawing.Size(30, 13);
            this.lblPromptTitle.TabIndex = 4;
            this.lblPromptTitle.Text = "Title:";
            // 
            // chkBoxDefault
            // 
            this.chkBoxDefault.AutoSize = true;
            this.chkBoxDefault.Checked = true;
            this.chkBoxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxDefault.Location = new System.Drawing.Point(144, 0);
            this.chkBoxDefault.Name = "chkBoxDefault";
            this.chkBoxDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBoxDefault.Size = new System.Drawing.Size(87, 17);
            this.chkBoxDefault.TabIndex = 11;
            this.chkBoxDefault.Text = "Use Defaults";
            this.chkBoxDefault.UseVisualStyleBackColor = true;
            this.chkBoxDefault.CheckStateChanged += new System.EventHandler(this.chkBoxDefault_CheckStateChanged);
            // 
            // NSRForm
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 334);
            this.Controls.Add(this.boxFields);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblLinkAbout);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lblPromptURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NSRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nico Sound Reborn";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.boxFields.ResumeLayout(false);
            this.boxFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromptURL;
        private System.Windows.Forms.Label lblPromptFileName;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.LinkLabel lblLinkAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox boxFields;
        private System.Windows.Forms.TextBox txtBoxAlbum;
        private System.Windows.Forms.TextBox txtBoxArtist;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblPromptAlbum;
        private System.Windows.Forms.Label lblPromptArtist;
        private System.Windows.Forms.Label lblPromptTitle;
        private System.Windows.Forms.CheckBox chkBoxDefault;
    }
}

