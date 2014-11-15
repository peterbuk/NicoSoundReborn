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
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblLinkAbout = new System.Windows.Forms.LinkLabel();
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
            this.lblPromptFileName.Location = new System.Drawing.Point(27, 84);
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
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(30, 100);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(207, 20);
            this.txtBoxFileName.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(262, 58);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 39);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(27, 142);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(324, 23);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Welcome!";
            // 
            // lblLinkAbout
            // 
            this.lblLinkAbout.AutoSize = true;
            this.lblLinkAbout.Location = new System.Drawing.Point(337, 157);
            this.lblLinkAbout.Name = "lblLinkAbout";
            this.lblLinkAbout.Size = new System.Drawing.Size(35, 13);
            this.lblLinkAbout.TabIndex = 6;
            this.lblLinkAbout.TabStop = true;
            this.lblLinkAbout.Text = "About";
            this.lblLinkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // NSRForm
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 176);
            this.Controls.Add(this.lblLinkAbout);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lblPromptFileName);
            this.Controls.Add(this.lblPromptURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NSRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nico Sound Reborn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromptURL;
        private System.Windows.Forms.Label lblPromptFileName;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.LinkLabel lblLinkAbout;
    }
}

