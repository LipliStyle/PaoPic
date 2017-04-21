using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaoPic.Setting
{
    public class SettingControllerGeneral : SettingController<SettingGeneral>
    {
        /// <summary>
        /// 設定を取得する
        /// </summary>
        /// <returns></returns>
        public SettingGeneral getSetting()
        {
            //設定ロード
            SettingGeneral setting = Load();

            //NULLチェック
            if(setting == null)
            {
                setting = new SettingGeneral();
            }

            //設定を取得する
            return setting;
        }

    }
}
