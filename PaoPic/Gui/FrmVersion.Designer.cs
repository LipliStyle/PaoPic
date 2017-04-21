namespace PaoPic.Gui
{
    partial class FrmVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVersion));
            this.lblTItleTItle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lnkSiteLink = new System.Windows.Forms.LinkLabel();
            this.lnkMastodon = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTItleTItle
            // 
            this.lblTItleTItle.AutoSize = true;
            this.lblTItleTItle.Location = new System.Drawing.Point(118, 22);
            this.lblTItleTItle.Name = "lblTItleTItle";
            this.lblTItleTItle.Size = new System.Drawing.Size(40, 12);
            this.lblTItleTItle.TabIndex = 2;
            this.lblTItleTItle.Text = "PaoPic";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(174, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(98, 12);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "X.X.X.X";
            // 
            // lnkSiteLink
            // 
            this.lnkSiteLink.AutoSize = true;
            this.lnkSiteLink.Location = new System.Drawing.Point(174, 46);
            this.lnkSiteLink.Name = "lnkSiteLink";
            this.lnkSiteLink.Size = new System.Drawing.Size(109, 12);
            this.lnkSiteLink.TabIndex = 4;
            this.lnkSiteLink.TabStop = true;
            this.lnkSiteLink.Text = "https://liplis.mine.nu";
            this.lnkSiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSiteLink_LinkClicked);
            // 
            // lnkMastodon
            // 
            this.lnkMastodon.AutoSize = true;
            this.lnkMastodon.Location = new System.Drawing.Point(174, 70);
            this.lnkMastodon.Name = "lnkMastodon";
            this.lnkMastodon.Size = new System.Drawing.Size(142, 12);
            this.lnkMastodon.TabIndex = 5;
            this.lnkMastodon.TabStop = true;
            this.lnkMastodon.Text = "https://pawoo.net/@sachin";
            this.lnkMastodon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMastodon_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "サイト";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "マストドン";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaoPic.Properties.Resources.icon_043553_256;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "連絡はこちらにお願いします。";
            // 
            // FrmVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkMastodon);
            this.Controls.Add(this.lnkSiteLink);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTItleTItle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "バージョン情報";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTItleTItle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel lnkSiteLink;
        private System.Windows.Forms.LinkLabel lnkMastodon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}