using Mastonet.Entities;
using PaoPic.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaoPic.Ctrl
{
    public class PicturePanel : Panel
    {
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.PictureBox btnTootView;
        private System.Windows.Forms.PictureBox btnBoost;
        private System.Windows.Forms.PictureBox btnFavo;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox btnTrash;
        private System.Windows.Forms.PictureBox btnView;
        private System.Windows.Forms.PictureBox btnFollow;

        private Status status;
        private FrmMain form;

        //画像URL
        public string picUrl { get; set; }

        //ローカル保存パス
        public string localSavePath { get; set; }

        //保存されているか
        public bool flgSaved;

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="picUrl"></param>
        public PicturePanel(FrmMain form,Status status, string picUrl)
        {
            InitializeComponent();

            this.form = form;
            this.status = status;
            this.picUrl = picUrl;
            this.picBox.ImageLocation = picUrl;
            this.flgSaved = false;
        }
        public PicturePanel(FrmMain form, Status status, string picUrl, string savePath, bool flgSaved)
        {
            InitializeComponent();

            this.form = form;
            this.status = status;
            this.picUrl = picUrl;
            this.picBox.ImageLocation = picUrl;
            this.flgSaved = flgSaved;

            if(flgSaved)
            {
                SetFlgSaved(savePath);
            }
        }

        /// <summary>
        /// 初期化
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
            // 
            // pnlPic
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnFollow);
            this.Controls.Add(this.btnTootView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnTrash);
            this.Controls.Add(this.btnBoost);
            this.Controls.Add(this.btnFavo);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "pnlPic";
            this.Size = new System.Drawing.Size(230, 200);
            this.TabIndex = 1;
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
        }

        /// <summary>
        /// ピクチャーボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Click(object sender, EventArgs e)
        {
            picUp();
        }

        /// <summary>
        /// ブーストボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBoost_Click(object sender, EventArgs e)
        {
            form.tootBoost(this.status);
        }

        /// <summary>
        /// ファボボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFavo_Click(object sender, EventArgs e)
        {
            form.tootFavourite(this.status);
        }

        /// <summary>
        /// ツゥーとを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTootView_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(status.Url);
        }

        /// <summary>
        /// フォローする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFollow_Click(object sender, EventArgs e)
        {
            form.follow(status);
        }

        /// <summary>
        /// トラッシュボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (!flgSaved)
            {
                form.delFromPicup(this);
            }
            else
            {
                form.delFromSaved(this);
            }
        }

        /// <summary>
        /// ブラウザで開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(picUrl);
        }

        /// <summary>
        /// 保存済みON
        /// </summary>
        public void SetFlgSaved(string localSavePath)
        {
            this.flgSaved = true;
            this.localSavePath = localSavePath;
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void picUp()
        {
            if (!flgSaved)
            {
                //キープ
                form.picUp(this);
            }
            else
            {
                //ローカルから開く
                System.Diagnostics.Process.Start(this.localSavePath);
            }
        }
    }
}
