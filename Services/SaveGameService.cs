using System;
using System.IO;
using System.Windows.Forms;
using NHSE.Core;
using NLog;

namespace ACNH_Turnips_Fortuneteller.Services
{
    public class SaveGameService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private const string MainDat = "main.dat";
        private const string MainHeaderDat = "mainHeader.dat";

        public bool OpenSaveFromFolder(string saveDirectory, out TurnipStonk turnipStonk)
        {
            turnipStonk = null;
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
                try
                {
                    var mainSaveFile = new HorizonSave(saveDirectory);
                    if(mainSaveFile.ValidateSizes())
                    {
                        result = true;
                        turnipStonk = mainSaveFile.Main.Turnips;
                    }
                    else
                    {
                        MessageBox.Show("Save file sizes appear to be incorrect.", "Version doesn't match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    Logger.Error(e);
                    MessageBox.Show(e.Message, "Failed to load save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            return result;
        }
    }
}
