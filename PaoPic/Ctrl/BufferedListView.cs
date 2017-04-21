using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaoPic.Ctrl
{
    public class BufferedListView : System.Windows.Forms.ListView
    {
        protected override bool DoubleBuffered { get { return true; } set { } }
    }
}
