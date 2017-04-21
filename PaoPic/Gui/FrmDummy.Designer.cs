namespace PaoPic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlPic = new System.Windows.Forms.Panel();
            this.btnFollow = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.PictureBox();
            this.btnTrash = new System.Windows.Forms.PictureBox();
            this.btnTootView = new System.Windows.Forms.PictureBox();
            this.btnBoost = new System.Windows.Forms.PictureBox();
            this.btnFavo = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFollow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTootView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPic
            // 
            this.pnlPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPic.Controls.Add(this.btnFollow);
            this.pnlPic.Controls.Add(this.btnTootView);
            this.pnlPic.Controls.Add(this.btnView);
            this.pnlPic.Controls.Add(this.btnTrash);
            this.pnlPic.Controls.Add(this.btnBoost);
            this.pnlPic.Controls.Add(this.btnFavo);
            this.pnlPic.Controls.Add(this.picBox);
            this.pnlPic.Location = new System.Drawing.Point(12, 12);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(230, 200);
            this.pnlPic.TabIndex = 1;
            // 
            // btnFollow
            // 
            this.btnFollow.Image = global::PaoPic.Properties.Resources.Follow;
            this.btnFollow.Location = new System.Drawing.Point(202, 61);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(24, 24);
            this.btnFollow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFollow.TabIndex = 7;
            this.btnFollow.TabStop = false;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::PaoPic.Properties.Resources.icon_030903_256;
            this.btnView.Location = new System.Drawing.Point(202, 121);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(24, 24);
            this.btnView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnView.TabIndex = 6;
            this.btnView.TabStop = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Image = global::PaoPic.Properties.Resources.icon_002003_256;
            this.btnTrash.Location = new System.Drawing.Point(202, 171);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(24, 24);
            this.btnTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTrash.TabIndex = 5;
            this.btnTrash.TabStop = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnTootView
            // 
            this.btnTootView.Image = global::PaoPic.Properties.Resources.icon_043563_256;
            this.btnTootView.Location = new System.Drawing.Point(202, 91);
            this.btnTootView.Name = "btnTootView";
            this.btnTootView.Size = new System.Drawing.Size(24, 24);
            this.btnTootView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTootView.TabIndex = 4;
            this.btnTootView.TabStop = false;
            this.btnTootView.Click += new System.EventHandler(this.btnTootView_Click);
            // 
            // btnBoost
            // 
            this.btnBoost.Image = ((System.Drawing.Image)(resources.GetObject("btnBoost.Image")));
            this.btnBoost.Location = new System.Drawing.Point(202, 1);
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(24, 24);
            this.btnBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBoost.TabIndex = 3;
            this.btnBoost.TabStop = false;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // btnFavo
            // 
            this.btnFavo.Image = ((System.Drawing.Image)(resources.GetObject("btnFavo.Image")));
            this.btnFavo.Location = new System.Drawing.Point(202, 31);
            this.btnFavo.Name = "btnFavo";
            this.btnFavo.Size = new System.Drawing.Size(24, 24);
            this.btnFavo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFavo.TabIndex = 2;
            this.btnFavo.TabStop = false;
            this.btnFavo.Click += new System.EventHandler(this.btnFavo_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(200, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.pic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.pnlPic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFollow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTootView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.PictureBox btnTootView;
        private System.Windows.Forms.PictureBox btnBoost;
        private System.Windows.Forms.PictureBox btnFavo;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox btnTrash;
        private System.Windows.Forms.PictureBox btnView;
        private System.Windows.Forms.PictureBox btnFollow;
    }
}