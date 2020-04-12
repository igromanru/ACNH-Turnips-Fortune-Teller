using System.Windows.Forms;

namespace ACNH_Turnips_Fortuneteller
{
    public partial class BuyPricesControl : UserControl
    {
        public BuyPricesControl()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            buyPricesGroupBox.Text = title + buyPricesGroupBox.Text;
        }
    }
}
