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

        public void SetPrices(uint morningPrice, uint eveningPrice)
        {
            morningBuyPriceTextBox.Text = morningPrice.ToString();
            eveningBuyPriceTextBox.Text = eveningPrice.ToString();
        }
    }
}
