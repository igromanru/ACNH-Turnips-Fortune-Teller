using System.IO;
using System.Windows.Forms;
using MyHorizons.Data.Save;
using NLog;

namespace ACNH_Turnips_Fortuneteller.Services
{
    public class SaveGameService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private const string MainDat = "main.dat";
        private const string MainHeaderDat = "mainHeader.dat";

        private MainSaveFile MainSave { get; set; }

        public bool OpenSaveFromFolder(string saveDirectory)
        {
            var result = false;
            var mainDatPath = Path.Combine(saveDirectory, MainDat);
            var mainHeaderDatPath = Path.Combine(saveDirectory, MainHeaderDat);
            if (!File.Exists(mainDatPath))
            {
                MessageBox.Show("Failed to open save file", $"{mainDatPath} doesn't exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists(mainHeaderDatPath))
            {
                MessageBox.Show("Failed to open save file header", $"{mainHeaderDatPath} doesn't exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainSave = new MainSaveFile(mainHeaderDatPath, mainDatPath);
                result = MainSave.Loaded && MainSave.Town != null;
            }
            return result;
        }
    }
}
