using System.IO;
using System.Resources;
using System.Windows.Forms;
using ACNH_Turnips_Fortuneteller.Properties;
using ACNH_Turnips_Fortuneteller.Services;

namespace ACNH_Turnips_Fortuneteller
{
    public partial class MainForm : Form
    {
        private ResourceManager ResourceManager { get; }

        private SaveGameService SaveGameService { get; }

        public MainForm()
        {
            InitializeComponent();
            mondayBuyPricesControl.SetTitle("Monday");
            tuesdayBuyPricesControl.SetTitle("Tuesday");
            wednesdayBuyPricesControl.SetTitle("Wednesday");
            thursdayBuyPricesControl.SetTitle("Thursday");
            fridayBuyPricesControl.SetTitle("Friday");
            saturdayBuyPricesControl.SetTitle("Saturday");

            ResourceManager = new ResourceManager(typeof(MainForm));
            SaveGameService = new SaveGameService();
        }

        private void openSaveButton_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = ResourceManager.GetString("acnh_save_file");
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveGameService.OpenSaveFromFolder(Path.GetDirectoryName(openFileDialog.FileName)))
                    {

                    }
                    else
                    {
                        MessageBox.Show(Resources.application_name, Resources.couldnt_parse_the_save_file, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
