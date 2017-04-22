namespace PaoPic.Gui
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.grpKeep = new System.Windows.Forms.GroupBox();
            this.btnGetAccessToken = new System.Windows.Forms.Button();
            this.cboInstances = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpKeep.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKeep
            // 
            this.grpKeep.Controls.Add(this.btnGetAccessToken);
            this.grpKeep.Controls.Add(this.cboInstances);
            this.grpKeep.Controls.Add(this.txtPassword);
            this.grpKeep.Controls.Add(this.txtMail);
            this.grpKeep.Controls.Add(this.label3);
            this.grpKeep.Controls.Add(this.label2);
            this.grpKeep.Controls.Add(this.label1);
            this.grpKeep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpKeep.Location = new System.Drawing.Point(12, 12);
            this.grpKeep.Name = "grpKeep";
            this.grpKeep.Size = new System.Drawing.Size(270, 138);
            this.grpKeep.TabIndex = 3;
            this.grpKeep.TabStop = false;
            this.grpKeep.Text = "ログイン情報";
            // 
            // btnGetAccessToken
            // 
            this.btnGetAccessToken.ForeColor = System.Drawing.Color.Black;
            this.btnGetAccessToken.Location = new System.Drawing.Point(72, 104);
            this.btnGetAccessToken.Name = "btnGetAccessToken";
            this.btnGetAccessToken.Size = new System.Drawing.Size(127, 23);
            this.btnGetAccessToken.TabIndex = 6;
            this.btnGetAccessToken.Text = "アクセストークン取得";
            this.btnGetAccessToken.UseVisualStyleBackColor = true;
            this.btnGetAccessToken.Click += new System.EventHandler(this.btnGetAccessToken_Click);
            // 
            // cboInstances
            // 
            this.cboInstances.FormattingEnabled = true;
            this.cboInstances.Items.AddRange(new object[] {
            "https://mstdn.jp",
            "https://pawoo.net",
            "https://friends.nico"});
            this.cboInstances.Location = new System.Drawing.Point(87, 76);
            this.cboInstances.Name = "cboInstances";
            this.cboInstances.Size = new System.Drawing.Size(164, 20);
            this.cboInstances.TabIndex = 5;
            this.cboInstances.Text = "pawoo.net";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 19);
            this.txtPassword.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(87, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(164, 19);
            this.txtMail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "インスタンス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "メールアドレス";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(12, 200);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnd.Location = new System.Drawing.Point(207, 200);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "キャンセル";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "マストドンの登録情報を入力し、\r\nアクセストークンを取得して下さい。";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(294, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpKeep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ログイン情報入力";
            this.grpKeep.ResumeLayout(false);
            this.grpKeep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKeep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInstances;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnGetAccessToken;
        private System.Windows.Forms.Label label4;
    }
}