using Mastonet;
using Mastonet.Entities;
using PaoPic.Ctrl;
using PaoPic.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace PaoPic.Gui
{
    public partial class FrmMain : Form
    {
        //=====================================
        // 保存ディレクトリ定義
        private const string SAVE_DIR = "\\Save";

        //=====================================
        // パオーンインスタンス
        private AppRegistration regInfo;
        private MastodonClient client;
        private Auth auth;
        private TimelineStreaming streaming;

        //=====================================
        // 設定
        private SettingControllerAccount setCtrlAccount;
        private SettingControllerGeneral setCtrlGeneral;
        private SettingAccount settingAccount;
        private SettingGeneral settingGeneral;

        private int maxCount = 10;

        //====================================================================
        //
        //                             初期化処理
        //                         
        //====================================================================
        #region 初期化処理

        /// <summary>
        /// コンストラクター
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            //設定のロード
            loadSetting();

            //ウインドウの初期化
            initWindow();

            //ディレクトリ生成
            createDir();

            //アカウントチェック
            checkAccount();

            //トークンの生成
            createToken();

            //ログイン
            login();

            //オンラインスタート
            startOnline();
        }

        /// <summary>
        /// 設定のロード
        /// </summary>
        private void loadSetting()
        {
            setCtrlAccount = new SettingControllerAccount();
            setCtrlGeneral = new SettingControllerGeneral();

            settingAccount = setCtrlAccount.Load();
            settingGeneral = setCtrlGeneral.getSetting();
        }

        /// <summary>
        /// ウインドウの初期化
        /// </summary>
        private void initWindow()
        {
            this.btnStop.Image = global::PaoPic.Properties.Resources.icon_001713_256_off;

            cboAutoSave.SelectedIndex = settingGeneral.selectedAutoSave;
            cboDisplayNum.SelectedIndex = settingGeneral.selectedDisplayNum;
            chkOnline.Checked = settingGeneral.startOnline;
        }

        /// <summary>
        /// マックスカウント設定
        /// </summary>
        private void setMaxCount()
        {
            try
            {
                this.maxCount = int.Parse(cboDisplayNum.Text);
            }
            catch
            {
                this.maxCount = 100;
            }
        }


        /// <summary>
        /// トークン生成
        /// </summary>
        private void createToken()
        {
            if(settingAccount != null)
            {
                this.regInfo = new AppRegistration
                {
                    ClientId = settingAccount.CLIENT_ID,
                    ClientSecret = settingAccount.CLIENTSECRET,
                    Instance = settingAccount.INSTANCE_URL,
                    Scope = Scope.Read|Scope.Write|Scope.Follow
                };
            }

        }

        /// <summary>
        /// セーブディレクトリ作成
        /// </summary>
        private void createDir()
        {
            string saveDir = System.Windows.Forms.Application.StartupPath + SAVE_DIR;

            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }

            //表示
            txtDir.Text = saveDir;
        }

        /// <summary>
        /// オンラインならスタートsル
        /// </summary>
        private void startOnline()
        {
            //アカウント情報が登録されていて、アカウントが有効で、スタートONノア場合、オンラインにする。
            if (settingAccount != null)
            {
                if (chkOnline.Checked)
                {
                    btnStart_Click(null, null);
                }
            }

        }

        /// <summary>
        /// ログインチェック
        /// </summary>
        private void checkAccount()
        {
            if(settingAccount == null)
            {
                getSettingAccount();
            }
            else if (settingAccount.IsNull())
            {
                getSettingAccount();
            }
        }

        /// <summary>
        /// アカウント情報を取得する
        /// </summary>
        private void getSettingAccount()
        {
            using (FrmLogin f = new FrmLogin(settingAccount))
            {
                this.Show();
                settingAccount = f.GetAccountSetting();

                if(settingAccount == null)
                {
                    //NULLの場合、終了する
                    this.Close();
                }
                else
                {
                    setCtrlAccount.Save(settingAccount);
                }
            }
        }

        /// <summary>
        /// ログインチェック
        /// </summary>
        /// <returns></returns>
        private async Task<bool> login()
        {
            try
            {
                this.client = new MastodonClient(regInfo);
                this.auth = await client.ConnectWithPassword(settingAccount.EMAIL, settingAccount.PASSWORD);

                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion
        //====================================================================
        //
        //                         設定関連処理
        //                         
        //====================================================================
        #region 設定関連処理
        /// <summary>
        /// 設定情報をセーブする
        /// </summary>
        private void SaveSettingGeneral()
        {
            setCtrlGeneral.Save(settingGeneral);
        }

        /// <summary>
        /// アカウント情報をセーブする
        /// </summary>
        private void SaveSettingAccount()
        {
            setCtrlAccount.Save(settingAccount);
           
        }
        #endregion
        //====================================================================
        //
        //                         ツイート収集処理
        //                         
        //====================================================================
        #region ツイート収集処理

        public async void collectStart()
        {
            try
            {
                this.client = new MastodonClient(regInfo);
                this.auth = await client.ConnectWithPassword(settingAccount.EMAIL, settingAccount.PASSWORD);
                this.streaming = client.GetPublicStreaming();

                // イベント登録
                streaming.OnUpdate += new EventHandler<StreamUpdateEventArgs>(CollectEvent);

                // ストリーミング開始
                streaming.Start();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {

            }
        }

        /// <summary>
        /// 収集イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectEvent(object sender, StreamUpdateEventArgs e)
        {
            try
            {
                //画像があったか？
                bool isMedia = false;

                //ドゥーイベ
                System.Windows.Forms.Application.DoEvents();

                //ステータス取得
                Status status = e.Status;

                if (status.MediaAttachments != null)
                {
                    foreach (Attachment media in status.MediaAttachments)
                    {
                        //空URLはスルー
                        if (media.Url == "")
                        {
                            continue;
                        }

                        //ピクチャーセット
                        Invoke((MethodInvoker)delegate{ 
                            //イメージのセット
                            if (this.cboAutoSave.SelectedIndex == 1)
                            {
                                setPicup(status, media);
                            }
                            else
                            {
                                setImage(status, media);
                            }
                        });

                        //メディアが存在した
                        isMedia = true;
                    }
                }

                //ツイートのセット
                setListView(status, isMedia);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// ツイートのセット
        /// </summary>
        /// <param name="status"></param>
        private void setListView(Status status, bool isMedia)
        {
            Invoke((MethodInvoker)delegate
            {
                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;

                lvi.SubItems.Add(CreateSubItem(DateTime.Now.ToString("hh:mm:ss"), isMedia));
                lvi.SubItems.Add(CreateSubItem(status.Account.AccountName, isMedia));
                lvi.SubItems.Add(CreateSubItem(TweetFilter(status.Content), isMedia));

                //先頭に挿入
                lstTimeline.Items.Insert(0, lvi);

                while(this.lstTimeline.Items.Count >= maxCount)
                {
                    this.lstTimeline.Items.RemoveAt(maxCount - 1);
                }

                lstTimeline.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            });
        }
        private void addLog(string message, string action)
        {
            Invoke((MethodInvoker)delegate
            {
                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;

                lvi.SubItems.Add(CreateLogSubItem(DateTime.Now.ToString("hh:mm:ss")));
                lvi.SubItems.Add(CreateLogSubItem(action));
                lvi.SubItems.Add(CreateLogSubItem(message));

                //先頭に挿入
                lstTimeline.Items.Insert(0, lvi);

                while (this.lstTimeline.Items.Count >= maxCount)
                {
                    this.lstTimeline.Items.RemoveAt(maxCount - 1);
                }

                lstTimeline.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            });
        }


        /// <summary>
        /// サブアテムを追加する
        /// </summary>
        /// <param name="toot"></param>
        /// <returns></returns>
        private ListViewSubItem CreateSubItem(string toot, bool isMedia)
        {
            ListViewSubItem sItem = new ListViewSubItem();

            //テキストセット
            sItem.Text = toot;

            //文字色設定
            if(isMedia)
            {
                sItem.ForeColor = Color.Red;
            }
            else
            {
                sItem.ForeColor = Color.White;
            }
            

            return sItem;
        }
        private ListViewSubItem CreateLogSubItem(string message)
        {
            ListViewSubItem sItem = new ListViewSubItem();

            //テキストセット
            sItem.Text = message;

            //文字色設定
            sItem.ForeColor = Color.Yellow;

            return sItem;
        }


        /// <summary>
        /// イメージを追加する
        /// </summary>
        /// <param name="media"></param>
        private void setImage(Status status,Attachment media)
        {
            Invoke((MethodInvoker)delegate
            {
                //パネル生成
                PicturePanel msgMedia = new PicturePanel(this,status,media.Url);

                //追加
                this.FlpPicup.Controls.Add(msgMedia);

                //先頭に移動
                this.FlpPicup.Controls.SetChildIndex(msgMedia, 0);

                //上限チェック
                while (this.FlpPicup.Controls.Count >= maxCount)
                {
                    this.FlpPicup.Controls.RemoveAt(maxCount - 1);
                }
            });
        }

        /// <summary>
        /// ピックアップ
        /// </summary>
        /// <param name="msgMedia"></param>
        public void picUp(PicturePanel msgMedia)
        {
            //ピックアップに移動する。
            try
            {
                //リストから削除
                this.FlpPicup.Controls.Remove(msgMedia);

                //キープに入れる
                this.FlpSaved.Controls.Add(msgMedia);

                //先頭に移動
                this.FlpSaved.Controls.SetChildIndex(msgMedia, 0);

                //上限チェック
                while (this.FlpSaved.Controls.Count >= maxCount)
                {
                    this.FlpSaved.Controls.RemoveAt(maxCount - 1);
                }

                //ダウンロードする
                msgMedia.SetFlgSaved(PicDownLoad(msgMedia.picUrl));
            }
            catch
            {

            }
        }

        /// <summary>
        /// 速攻でピックアップする
        /// </summary>
        /// <param name="status"></param>
        /// <param name="media"></param>
        private void setPicup(Status status, Attachment media)
        {
            Invoke((MethodInvoker)delegate
            {
                //パネル生成
                PicturePanel msgMedia = new PicturePanel(this, status, media.Url, PicDownLoad(media.Url) ,true);

                //追加
                this.FlpSaved.Controls.Add(msgMedia);

                //先頭に移動
                this.FlpSaved.Controls.SetChildIndex(msgMedia, 0);

                //上限チェック
                while (this.FlpSaved.Controls.Count >= maxCount)
                {
                    this.FlpSaved.Controls.RemoveAt(maxCount - 1);
                }                
            });
        }

        /// <summary>
        /// ピックアップから削除する
        /// </summary>
        /// <param name="msgMedia"></param>
        public void delFromPicup(PicturePanel msgMedia)
        {
            this.FlpPicup.Controls.Remove(msgMedia);
            addLog("ピックアップから1件削除しました。", "保存リストDEL");
        }

        /// <summary>
        /// 保存済みから削除する
        /// </summary>
        /// <param name="msgMedia"></param>
        public void delFromSaved(PicturePanel msgMedia)
        {
            this.FlpSaved.Controls.Remove(msgMedia);
            addLog("保存リストから1件削除しました。", "保存リストDEL");
        }

        /// <summary>
        /// お気に入り登録
        /// </summary>
        /// <param name="msgMedia"></param>
        public void tootFavourite(Status status)
        {
            client.Favourite(status.Id);
            addLog(status.Id + "をお気に入りお登録しました。", "ファボ");
        }

        /// <summary>
        /// ブースト
        /// </summary>
        /// <param name="status"></param>
        public void tootBoost(Status status)
        {
            client.Reblog(status.Id);
            addLog(status.Id + "をブーストしました。", "ブースト");
        }

        /// <summary>
        /// フォロー
        /// </summary>
        /// <param name="status"></param>
        public void follow(Status status)
        {
            client.Follow(status.Account.Id);
            addLog(status.Account.AccountName + "さんをフォローしました。", "フォロー");
        }

        #endregion

        //====================================================================
        //
        //                          ツイート加工
        //                         
        //====================================================================
        #region ツイート加工
        public const string regexStrHtml = @"<.*?>";     //HTML
        public const string regexStrUrl = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";       //URL
        public const string regexStrHash = @"\s#.*(\s|$)";     //HASHタグ



        Regex rexexHtmlTag = new Regex(regexStrHtml);          //HTMLタグ
        Regex regexUrl = new Regex(regexStrUrl);               //URL
        Regex rexexHashTag = new Regex(regexStrHash);          //HASHタグ
        
        /// <summary>
        /// ツイートフィルター
        /// </summary>
        /// <param name="tweet"></param>
        /// <returns></returns>
        private string TweetFilter(string tweet)
        {
            //セット
            string result = tweet;

            //HTMLタグ除去
            result = RxRemove(rexexHtmlTag, result);

            //URLの除去
            result = RxRemove(regexUrl, result);

            //HASH除去
            result = RxRemove(rexexHashTag, result);

            //前後に出来たスペースを除去
            result = result.Trim();

            //修正後の文字を返す
            return result;
        }
        public string RxRemove(Regex rx, string targetStr)
        {
            return rx.Replace(targetStr, "");
        }

        #endregion

        //====================================================================
        //
        //                      ファイルダウンロード処理
        //                         
        //====================================================================
        #region ファイルダウンロード処理
        /// <summary>
        /// ファイルをダウンロードする
        /// </summary>
        /// <param name="url"></param>
        private string  PicDownLoad(string url)
        {
            string dirName = System.Windows.Forms.Application.StartupPath + SAVE_DIR;

            string dlPath = dirName + "\\" + getFileName(url);

            using (WebClient client = new WebClient())
            {
                client.DownloadFileTaskAsync(url, dlPath);
            }

            return dlPath;
        }

        /// <summary>
        /// ファイル名を生成する
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string getFileName(string url)
        {
            if(url.Contains("?"))
            {
                string[] urls = url.Split('?');

                url = urls[0];
            }

            string extention = Path.GetExtension(url);


            return DateTime.Now.ToString("yyyyMMddHHmmss") + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper() + extention;
        }
        #endregion

        //====================================================================
        //
        //                             イベントハンドラ
        //                         
        //====================================================================
        #region イベントハンドラ

        /// <summary>
        /// スタートボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
             collectStart()
            );
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            this.btnStart.Image = Properties.Resources.icon_016513_256_off;
            this.btnStop.Image = Properties.Resources.icon_001713_256;
        }


        /// <summary>
        /// 停止ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            streaming.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            this.btnStart.Image = Properties.Resources.icon_016513_256;
            this.btnStop.Image = Properties.Resources.icon_001713_256_off;
        }

        /// <summary>
        /// マックスカウント設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDisplayNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            setMaxCount();
            settingGeneral.selectedDisplayNum = cboDisplayNum.SelectedIndex;
            SaveSettingGeneral();
        }

        /// <summary>
        /// オートセーブ設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAutoSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingGeneral.selectedAutoSave = cboAutoSave.SelectedIndex;
            SaveSettingGeneral();
        }

        /// <summary>
        /// オンライン設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkOnline_CheckedChanged(object sender, EventArgs e)
        {
            settingGeneral.startOnline = chkOnline.Checked;
            SaveSettingGeneral();
        }

        /// <summary>
        /// tootする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToot_Click(object sender, EventArgs e)
        {
            if(txtToot.Text == "")
            {
                return;
            }

            //ツートする
            try
            {
                client.PostStatus(txtToot.Text, Visibility.Public);
                txtToot.Text = "";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        /// <summary>
        /// ピックアップクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearPicup_Click(object sender, EventArgs e)
        {
            this.FlpPicup.Controls.Clear();
        }

        /// <summary>
        /// 保存済みクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSaved_Click(object sender, EventArgs e)
        {
            this.FlpSaved.Controls.Clear();
        }

        /// <summary>
        /// タイムラインクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearTimeLine_Click(object sender, EventArgs e)
        {
            this.lstTimeline.Items.Clear();
        }

        /// <summary>
        /// バージョン情報表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiVersion_Click(object sender, EventArgs e)
        {
            using (FrmVersion f = new FrmVersion())
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 保存フォルダを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDIr_Click(object sender, EventArgs e)
        {
            createDir();
            System.Diagnostics.Process.Start(txtDir.Text);
        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
