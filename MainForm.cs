using System.Windows.Forms;

namespace ACNH_Turnips_Fortuneteller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mondayBuyPricesControl.SetTitle("Monday");
            tuesdayBuyPricesControl.SetTitle("Tuesday");
            wednesdayBuyPricesControl.SetTitle("Wednesday");
            thursdayBuyPricesControl.SetTitle("Thursday");
            fridayBuyPricesControl.SetTitle("Friday");
            saturdayBuyPricesControl.SetTitle("Saturday");
        }
    }
}
