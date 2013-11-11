using System.Windows.Forms;

namespace TestForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            ssControl1.LoadSpreadSheet(@"data\City-owned_and_Leased_Property.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }
    }
}
