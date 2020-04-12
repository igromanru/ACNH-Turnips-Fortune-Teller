using System.IO;
using System.Windows.Forms;
using MyHorizons.Data.Save;
using MyHorizons.Data.TownData;

namespace ACNH_Turnips_Fortuneteller.Services
{
    public class SaveGameService
    {

        private const string MainDat = "main.dat";
        private const string MainHeaderDat = "mainHeader.dat";

        public bool OpenSaveFromFolder(string saveDirectory, out StalkMarket? stalkMarket)
        {
            stalkMarket = null;
            var result = false;
            var mainDatPath = Path.Combine(saveDirectory, MainDat);
            var mainHeaderDatPath = Path.Combine(saveDirectory, MainHeaderDat);
            if (!File.Exists(mainDatPath))
            {
                MessageBox.Show($"{mainDatPath} doesn't exist!", "Failed to open save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists(mainHeaderDatPath))
            {
                MessageBox.Show($"{mainHeaderDatPath} doesn't exist!", "Failed to open save file header", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var mainSaveFile = new MainSaveFile(mainHeaderDatPath, mainDatPath);
                result = mainSaveFile.Loaded && mainSaveFile.Town != null;
                stalkMarket = mainSaveFile.Town?.StalkMarket;
            }
            return result;
        }
    }
}
