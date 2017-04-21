using Mastonet;
using Mastonet.Entities;
using PaoPic.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaoPic.Gui
{
    public partial class FrmLogin : Form
    {
        //=====================================
        // アカウント情報
        SettingAccount settingAccount;

        //=====================================
        // パオーン定義
        public string CLIENT_ID { get; set; }
        public string CLIENTSECRET { get; set; }

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="settingAccount"></param>
        public FrmLogin(SettingAccount settingAccount)
        {
            InitializeComponent();

            this.settingAccount = settingAccount;

            if (this.settingAccount == null)
            {
                this.btnOk.Enabled = false;
            }
            else if (this.settingAccount.IsNull())
            {
                this.btnOk.Enabled = false;
            }
            else
            {
                this.btnOk.Enabled = true;
            }

        }

        /// <summary>
        /// 設定を取得する
        /// </summary>
        /// <returns></returns>
        public SettingAccount GetAccountSetting()
        {
            this.ShowDialog();

            //設定を返す
            return settingAccount;
        }

        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(settingAccount == null)
            {
                settingAccount = new SettingAccount();
            }

            //認証OKなら返す
            settingAccount.INSTANCE_URL = cboInstances.Text;
            settingAccount.EMAIL = txtMail.Text;
            settingAccount.PASSWORD = txtPassword.Text;
            settingAccount.CLIENT_ID = CLIENT_ID;
            settingAccount.CLIENTSECRET = CLIENTSECRET;


            this.Close();
        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            settingAccount = null;
            this.Close();
        }

        /// <summary>
        /// アクセストークンを取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                MessageBox.Show("メールアドレスを入力して下さい。", this.Text);
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("メールアドレスを入力して下さい。", this.Text);
            }


            if (cboInstances.Text == "")
            {
                MessageBox.Show("インスタンスURLを入力して下さい。", this.Text);
            }

            try
            {
                //アクセストークンの取得
                if (!await GetAccessToken())
                {
                    MessageBox.Show("アクセストークンの取得に失敗しました。インスタンスを確認してください。", this.Text);
                    return;
                }

                //認証
                if (!await AuthenticationCheck())
                {
                    MessageBox.Show("認証に失敗しました。メールアドレス、パスワードを確認してください。", this.Text);
                    return;
                }

                //取得成功！
                MessageBox.Show("アクセストークンの取得に成功しました！", this.Text);

                //OKボタン押下可能
                this.btnOk.Enabled = true;
            }
            catch
            {
                MessageBox.Show("認証に失敗しました。インスタンスを確認してください。", this.Text);
                this.btnOk.Enabled = false;
            }
        }

        /// <summary>
        /// 認証チェック
        /// </summary>
        /// <returns></returns>
        private async Task<bool> GetAccessToken()
        {
            try
            {
                //登録情報取得
                var appRegistration = await MastodonClient.CreateApp(cboInstances.Text, "PaoPic", Scope.Read | Scope.Write | Scope.Follow);

                this.CLIENT_ID = appRegistration.ClientId;
                this.CLIENTSECRET = appRegistration.ClientSecret;

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 認証チェック
        /// </summary>
        /// <returns></returns>
        private async Task<bool> AuthenticationCheck()
        {
            try
            {
                var appRegistration = new AppRegistration
                {
                    ClientId = CLIENT_ID,
                    ClientSecret = CLIENTSECRET,
                    Instance = cboInstances.Text,
                    Scope = Scope.Read | Scope.Write
                };

                var client = new MastodonClient(appRegistration);
                var auth = await client.ConnectWithPassword(txtMail.Text, txtPassword.Text);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

