using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

namespace SpreadSheetInspector
{
    public class SSInspector : Inspector2
    {
        private Control mainControl;

        public override void AddToTab(TabPage tabPage)
        {
            mainControl = new SSControl();
            tabPage.Text = "Spread Sheet";
            tabPage.Controls.Add(mainControl);
            mainControl.Dock = DockStyle.Fill;
        }

        public override int GetOrder()
        {
            return 0;
        }
    }
}
