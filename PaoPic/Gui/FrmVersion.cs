using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaoPic.Gui
{
    public partial class FrmVersion : Form
    {
        public FrmVersion()
        {
            InitializeComponent();

            setVersion();
        }

        private void setVersion()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Version ver = asm.GetName().Version;
            this.lblVersion.Text = ver.ToString();
        }

        private void lnkSiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkMastodon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://liplis.mine.nu");
        }

        private void lnkMastodon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkMastodon.LinkVisited = true;
            System.Diagnostics.Process.Start("https://pawoo.net/@sachin");
        }
    }
}
