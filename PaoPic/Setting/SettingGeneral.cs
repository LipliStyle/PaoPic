using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaoPic.Setting
{
    public class SettingGeneral
    {
        public int selectedDisplayNum {get;set;}
        public int selectedAutoSave { get; set; }
        public int selectTerms { get; set; }
        public bool startOnline { get; set; }
       
        /// <summary>
        /// コンストラクター
        /// </summary>
        public SettingGeneral()
        {
            this.selectedDisplayNum = 0;
            this.selectedAutoSave = 0;
            this.selectTerms = 0;
            this.startOnline = false;
        }
    }
}
