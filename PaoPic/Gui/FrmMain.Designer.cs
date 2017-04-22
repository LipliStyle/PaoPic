using PaoPic.Ctrl;

namespace PaoPic.Gui
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.FlpSaved = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKeep = new System.Windows.Forms.GroupBox();
            this.grpPicTImeLine = new System.Windows.Forms.GroupBox();
            this.FlpPicup = new System.Windows.Forms.FlowLayoutPanel();
            this.spl1 = new System.Windows.Forms.SplitContainer();
            this.grpTimeline = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToot = new System.Windows.Forms.Button();
            this.txtToot = new System.Windows.Forms.TextBox();
            this.pnlCtrl = new System.Windows.Forms.Panel();
            this.btnOpenDIr = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.btnClearTimeLine = new System.Windows.Forms.Button();
            this.btnClearSaved = new System.Windows.Forms.Button();
            this.btnClearPicup = new System.Windows.Forms.Button();
            this.lblTitleAutoSave = new System.Windows.Forms.Label();
            this.cboAutoSave = new System.Windows.Forms.ComboBox();
            this.lblTitleDisplayNum = new System.Windows.Forms.Label();
            this.cboDisplayNum = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTitleTerms = new System.Windows.Forms.Label();
            this.cboTerms = new System.Windows.Forms.ComboBox();
            this.lstTimeline = new PaoPic.Ctrl.BufferedListView();
            this.ColDummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColToot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpKeep.SuspendLayout();
            this.grpPicTImeLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).BeginInit();
            this.spl1.Panel1.SuspendLayout();
            this.spl1.Panel2.SuspendLayout();
            this.spl1.SuspendLayout();
            this.grpTimeline.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpSaved
            // 
            this.FlpSaved.AutoScroll = true;
            this.FlpSaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpSaved.Location = new System.Drawing.Point(3, 15);
            this.FlpSaved.Name = "FlpSaved";
            this.FlpSaved.Size = new System.Drawing.Size(264, 839);
            this.FlpSaved.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEnd});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(66, 20);
            this.tsmiFile.Text = "ファイル(&F)";
            // 
            // tsmiEnd
            // 
            this.tsmiEnd.Name = "tsmiEnd";
            this.tsmiEnd.Size = new System.Drawing.Size(113, 22);
            this.tsmiEnd.Text = "終了(&X)";
            this.tsmiEnd.Click += new System.EventHandler(this.tsmiEnd_Click);
            // 
            // grpKeep
            // 
            this.grpKeep.Controls.Add(this.FlpSaved);
            this.grpKeep.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpKeep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpKeep.Location = new System.Drawing.Point(994, 0);
            this.grpKeep.Name = "grpKeep";
            this.grpKeep.Size = new System.Drawing.Size(270, 857);
            this.grpKeep.TabIndex = 2;
            this.grpKeep.TabStop = false;
            this.grpKeep.Text = "保存済み";
            // 
            // grpPicTImeLine
            // 
            this.grpPicTImeLine.Controls.Add(this.FlpPicup);
            this.grpPicTImeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPicTImeLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpPicTImeLine.Location = new System.Drawing.Point(0, 0);
            this.grpPicTImeLine.Name = "grpPicTImeLine";
            this.grpPicTImeLine.Size = new System.Drawing.Size(543, 857);
            this.grpPicTImeLine.TabIndex = 3;
            this.grpPicTImeLine.TabStop = false;
            this.grpPicTImeLine.Text = "画像ピックアップ";
            // 
            // FlpPicup
            // 
            this.FlpPicup.AutoScroll = true;
            this.FlpPicup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpPicup.Location = new System.Drawing.Point(3, 15);
            this.FlpPicup.Name = "FlpPicup";
            this.FlpPicup.Size = new System.Drawing.Size(537, 839);
            this.FlpPicup.TabIndex = 0;
            // 
            // spl1
            // 
            this.spl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl1.Location = new System.Drawing.Point(0, 0);
            this.spl1.Name = "spl1";
            // 
            // spl1.Panel1
            // 
            this.spl1.Panel1.Controls.Add(this.grpTimeline);
            // 
            // spl1.Panel2
            // 
            this.spl1.Panel2.Controls.Add(this.grpPicTImeLine);
            this.spl1.Size = new System.Drawing.Size(994, 857);
            this.spl1.SplitterDistance = 447;
            this.spl1.TabIndex = 4;
            // 
            // grpTimeline
            // 
            this.grpTimeline.Controls.Add(this.lstTimeline);
            this.grpTimeline.Controls.Add(this.panel2);
            this.grpTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimeline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpTimeline.Location = new System.Drawing.Point(0, 0);
            this.grpTimeline.Name = "grpTimeline";
            this.grpTimeline.Size = new System.Drawing.Size(447, 857);
            this.grpTimeline.TabIndex = 0;
            this.grpTimeline.TabStop = false;
            this.grpTimeline.Text = "タイムライン";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToot);
            this.panel2.Controls.Add(this.txtToot);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 786);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnToot
            // 
            this.btnToot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnToot.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToot.ForeColor = System.Drawing.Color.White;
            this.btnToot.Location = new System.Drawing.Point(370, 0);
            this.btnToot.Name = "btnToot";
            this.btnToot.Size = new System.Drawing.Size(71, 68);
            this.btnToot.TabIndex = 1;
            this.btnToot.Text = "Toot!";
            this.btnToot.UseVisualStyleBackColor = false;
            this.btnToot.Click += new System.EventHandler(this.btnToot_Click);
            // 
            // txtToot
            // 
            this.txtToot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToot.Location = new System.Drawing.Point(0, 0);
            this.txtToot.Multiline = true;
            this.txtToot.Name = "txtToot";
            this.txtToot.Size = new System.Drawing.Size(441, 68);
            this.txtToot.TabIndex = 0;
            // 
            // pnlCtrl
            // 
            this.pnlCtrl.Controls.Add(this.lblTitleTerms);
            this.pnlCtrl.Controls.Add(this.cboTerms);
            this.pnlCtrl.Controls.Add(this.btnOpenDIr);
            this.pnlCtrl.Controls.Add(this.txtDir);
            this.pnlCtrl.Controls.Add(this.chkOnline);
            this.pnlCtrl.Controls.Add(this.btnClearTimeLine);
            this.pnlCtrl.Controls.Add(this.btnClearSaved);
            this.pnlCtrl.Controls.Add(this.btnClearPicup);
            this.pnlCtrl.Controls.Add(this.lblTitleAutoSave);
            this.pnlCtrl.Controls.Add(this.cboAutoSave);
            this.pnlCtrl.Controls.Add(this.lblTitleDisplayNum);
            this.pnlCtrl.Controls.Add(this.cboDisplayNum);
            this.pnlCtrl.Controls.Add(this.btnStop);
            this.pnlCtrl.Controls.Add(this.btnStart);
            this.pnlCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCtrl.Location = new System.Drawing.Point(0, 24);
            this.pnlCtrl.Name = "pnlCtrl";
            this.pnlCtrl.Size = new System.Drawing.Size(1264, 40);
            this.pnlCtrl.TabIndex = 5;
            // 
            // btnOpenDIr
            // 
            this.btnOpenDIr.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenDIr.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpenDIr.Location = new System.Drawing.Point(1157, 10);
            this.btnOpenDIr.Name = "btnOpenDIr";
            this.btnOpenDIr.Size = new System.Drawing.Size(95, 20);
            this.btnOpenDIr.TabIndex = 11;
            this.btnOpenDIr.Text = "保存フォルダを開く";
            this.btnOpenDIr.UseVisualStyleBackColor = false;
            this.btnOpenDIr.Click += new System.EventHandler(this.btnOpenDIr_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(929, 11);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(222, 19);
            this.txtDir.TabIndex = 10;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chkOnline.Location = new System.Drawing.Point(535, 13);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(104, 16);
            this.chkOnline.TabIndex = 9;
            this.chkOnline.Text = "起動時オンライン";
            this.chkOnline.UseVisualStyleBackColor = true;
            this.chkOnline.CheckedChanged += new System.EventHandler(this.chkOnline_CheckedChanged);
            // 
            // btnClearTimeLine
            // 
            this.btnClearTimeLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearTimeLine.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClearTimeLine.Location = new System.Drawing.Point(647, 10);
            this.btnClearTimeLine.Name = "btnClearTimeLine";
            this.btnClearTimeLine.Size = new System.Drawing.Size(86, 20);
            this.btnClearTimeLine.TabIndex = 8;
            this.btnClearTimeLine.Text = "タイムラインクリア";
            this.btnClearTimeLine.UseVisualStyleBackColor = false;
            this.btnClearTimeLine.Click += new System.EventHandler(this.btnClearTimeLine_Click);
            // 
            // btnClearSaved
            // 
            this.btnClearSaved.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearSaved.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClearSaved.Location = new System.Drawing.Point(831, 10);
            this.btnClearSaved.Name = "btnClearSaved";
            this.btnClearSaved.Size = new System.Drawing.Size(86, 20);
            this.btnClearSaved.TabIndex = 7;
            this.btnClearSaved.Text = "保存済み クリア";
            this.btnClearSaved.UseVisualStyleBackColor = false;
            this.btnClearSaved.Click += new System.EventHandler(this.btnClearSaved_Click);
            // 
            // btnClearPicup
            // 
            this.btnClearPicup.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearPicup.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClearPicup.Location = new System.Drawing.Point(739, 10);
            this.btnClearPicup.Name = "btnClearPicup";
            this.btnClearPicup.Size = new System.Drawing.Size(86, 20);
            this.btnClearPicup.TabIndex = 6;
            this.btnClearPicup.Text = "ピックアップ クリア";
            this.btnClearPicup.UseVisualStyleBackColor = false;
            this.btnClearPicup.Click += new System.EventHandler(this.btnClearPicup_Click);
            // 
            // lblTitleAutoSave
            // 
            this.lblTitleAutoSave.AutoSize = true;
            this.lblTitleAutoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitleAutoSave.Location = new System.Drawing.Point(222, 14);
            this.lblTitleAutoSave.Name = "lblTitleAutoSave";
            this.lblTitleAutoSave.Size = new System.Drawing.Size(53, 12);
            this.lblTitleAutoSave.TabIndex = 5;
            this.lblTitleAutoSave.Text = "自動保存";
            // 
            // cboAutoSave
            // 
            this.cboAutoSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutoSave.FormattingEnabled = true;
            this.cboAutoSave.Items.AddRange(new object[] {
            "しない",
            "すべて",
            "健全のみ",
            "不健全のみ"});
            this.cboAutoSave.Location = new System.Drawing.Point(276, 10);
            this.cboAutoSave.Name = "cboAutoSave";
            this.cboAutoSave.Size = new System.Drawing.Size(101, 20);
            this.cboAutoSave.TabIndex = 4;
            this.cboAutoSave.SelectedIndexChanged += new System.EventHandler(this.cboAutoSave_SelectedIndexChanged);
            // 
            // lblTitleDisplayNum
            // 
            this.lblTitleDisplayNum.AutoSize = true;
            this.lblTitleDisplayNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitleDisplayNum.Location = new System.Drawing.Point(85, 14);
            this.lblTitleDisplayNum.Name = "lblTitleDisplayNum";
            this.lblTitleDisplayNum.Size = new System.Drawing.Size(53, 12);
            this.lblTitleDisplayNum.TabIndex = 3;
            this.lblTitleDisplayNum.Text = "表示件数";
            // 
            // cboDisplayNum
            // 
            this.cboDisplayNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisplayNum.FormattingEnabled = true;
            this.cboDisplayNum.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cboDisplayNum.Location = new System.Drawing.Point(139, 10);
            this.cboDisplayNum.Name = "cboDisplayNum";
            this.cboDisplayNum.Size = new System.Drawing.Size(71, 20);
            this.cboDisplayNum.TabIndex = 2;
            this.cboDisplayNum.SelectedIndexChanged += new System.EventHandler(this.cboDisplayNum_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::PaoPic.Properties.Resources.icon_001713_256;
            this.btnStop.Location = new System.Drawing.Point(42, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStop.TabIndex = 1;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::PaoPic.Properties.Resources.icon_016513_256;
            this.btnStart.Location = new System.Drawing.Point(4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.spl1);
            this.pnlContent.Controls.Add(this.grpKeep);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1264, 857);
            this.pnlContent.TabIndex = 6;
            // 
            // lblTitleTerms
            // 
            this.lblTitleTerms.AutoSize = true;
            this.lblTitleTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitleTerms.Location = new System.Drawing.Point(391, 14);
            this.lblTitleTerms.Name = "lblTitleTerms";
            this.lblTitleTerms.Size = new System.Drawing.Size(29, 12);
            this.lblTitleTerms.TabIndex = 13;
            this.lblTitleTerms.Text = "条件";
            // 
            // cboTerms
            // 
            this.cboTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerms.FormattingEnabled = true;
            this.cboTerms.Items.AddRange(new object[] {
            "すべて",
            "健全のみ",
            "不健全のみ"});
            this.cboTerms.Location = new System.Drawing.Point(421, 10);
            this.cboTerms.Name = "cboTerms";
            this.cboTerms.Size = new System.Drawing.Size(101, 20);
            this.cboTerms.TabIndex = 12;
            this.cboTerms.SelectedIndexChanged += new System.EventHandler(this.cboTerms_SelectedIndexChanged);
            // 
            // lstTimeline
            // 
            this.lstTimeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstTimeline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDummy,
            this.ColTime,
            this.ColName,
            this.ColToot});
            this.lstTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTimeline.Location = new System.Drawing.Point(3, 15);
            this.lstTimeline.Name = "lstTimeline";
            this.lstTimeline.Size = new System.Drawing.Size(441, 771);
            this.lstTimeline.TabIndex = 2;
            this.lstTimeline.UseCompatibleStateImageBehavior = false;
            this.lstTimeline.View = System.Windows.Forms.View.Details;
            // 
            // ColDummy
            // 
            this.ColDummy.DisplayIndex = 3;
            this.ColDummy.Text = "";
            this.ColDummy.Width = 0;
            // 
            // ColTime
            // 
            this.ColTime.DisplayIndex = 0;
            this.ColTime.Text = "Time";
            // 
            // ColName
            // 
            this.ColName.DisplayIndex = 1;
            this.ColName.Text = "Name";
            // 
            // ColToot
            // 
            this.ColToot.DisplayIndex = 2;
            this.ColToot.Text = "Toot";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpOpen,
            this.tsmiVersion});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(48, 20);
            this.tsmiHelp.Text = "ヘルプ";
            // 
            // tsmiHelpOpen
            // 
            this.tsmiHelpOpen.Name = "tsmiHelpOpen";
            this.tsmiHelpOpen.Size = new System.Drawing.Size(152, 22);
            this.tsmiHelpOpen.Text = "ヘルプを開く";
            this.tsmiHelpOpen.Click += new System.EventHandler(this.tsmiHelpOpen_Click);
            // 
            // tsmiVersion
            // 
            this.tsmiVersion.Name = "tsmiVersion";
            this.tsmiVersion.Size = new System.Drawing.Size(152, 22);
            this.tsmiVersion.Text = "バージョン";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlCtrl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "PaoPic 1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpKeep.ResumeLayout(false);
            this.grpPicTImeLine.ResumeLayout(false);
            this.spl1.Panel1.ResumeLayout(false);
            this.spl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl1)).EndInit();
            this.spl1.ResumeLayout(false);
            this.grpTimeline.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCtrl.ResumeLayout(false);
            this.pnlCtrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpSaved;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.GroupBox grpKeep;
        private System.Windows.Forms.GroupBox grpPicTImeLine;
        private System.Windows.Forms.FlowLayoutPanel FlpPicup;
        private System.Windows.Forms.SplitContainer spl1;
        private System.Windows.Forms.GroupBox grpTimeline;
        private System.Windows.Forms.Panel panel2;
        private BufferedListView lstTimeline;
        private System.Windows.Forms.Button btnToot;
        private System.Windows.Forms.TextBox txtToot;
        private System.Windows.Forms.Panel pnlCtrl;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.ColumnHeader ColTime;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColToot;
        private System.Windows.Forms.Label lblTitleDisplayNum;
        private System.Windows.Forms.ComboBox cboDisplayNum;
        private System.Windows.Forms.Label lblTitleAutoSave;
        private System.Windows.Forms.ComboBox cboAutoSave;
        private System.Windows.Forms.ColumnHeader ColDummy;
        private System.Windows.Forms.Button btnClearSaved;
        private System.Windows.Forms.Button btnClearPicup;
        private System.Windows.Forms.Button btnClearTimeLine;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Button btnOpenDIr;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnd;
        private System.Windows.Forms.Label lblTitleTerms;
        private System.Windows.Forms.ComboBox cboTerms;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiVersion;
    }
}

