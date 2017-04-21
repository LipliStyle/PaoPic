using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaoPic.Setting
{
    public class SettingController<T>
    {
        /// <summary>
        /// レコードをセーブする
        /// </summary>
        public void Save(T data)
        {
            //ジェーソン取得
            string json = JsonConvert.SerializeObject(data);

            //テーブルファイル名を生成する
            string saveFileName = getFilePath();

            //ファイル書き込み
            using (StreamWriter w = new StreamWriter(saveFileName,false, Encoding.UTF8))
            {
                w.WriteLine(json);
            }
        }

        /// <summary>
        /// 設定を取得する
        /// </summary>
        /// <returns></returns>
        public T Load()
        {
            string saveFileName = getFilePath();

            string json = "";

            //存在チェック
            if(!File.Exists(saveFileName))
            {
                return default(T);
            }

            //JSON読み込み
            using (StreamReader sr = new StreamReader(saveFileName, Encoding.UTF8))
            {
                json = sr.ReadToEnd();   
            }

            //インスタンスを返す
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// ファイルパス 取得
        /// </summary>
        /// <returns></returns>
        protected virtual string getFilePath()
        {
            string dirName = Application.StartupPath + "\\Setting\\";

            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            return dirName + typeof(T).Name + ".json";
        }
    }
}
