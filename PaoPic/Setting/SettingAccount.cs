using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaoPic.Setting
{
    public class SettingAccount
    {
        //=====================================
        // パオーン定義
        public string CLIENT_ID { get; set; }
        public string CLIENTSECRET  { get; set; }

        //=====================================
        // ログイン情報
        public string EMAIL  { get; set; }
        public string PASSWORD { get; set; }

        //=====================================
        // インスタンス
        public string INSTANCE_URL { get; set; }

        public bool IsNull()
        {
            return CLIENT_ID == null && CLIENTSECRET == null && EMAIL == null && PASSWORD == null && INSTANCE_URL == null;
        }

    }
}
