using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EU4MapPainter
{
    public partial class frMainScreen : Form
    {
        public frMainScreen()
        {
            InitializeComponent();
            Select();
            picMap.Image = Image.FromFile(SharedContent.mapURL);
            picMap.Width = picMap.Image.Width;
            picMap.Height = picMap.Image.Height;
        }

        private void picMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //checks what is the color of the pixel the user clicked on
            MouseEventArgs eCurrent = (MouseEventArgs)e;
            Bitmap bitmap = new Bitmap(picMap.Image);
            Color pixel = bitmap.GetPixel(eCurrent.X, eCurrent.Y);

            //now, it goes to definitions.csv and tries to find the respective "color coordinates"
            Boolean foundProvince = false;
            string provinceID = "";
            for(int i = 0; i < SharedContent.definitionData.GetLength(0); i++)
            {
                if(SharedContent.definitionData[i, 1] == pixel.R.ToString() &&
                   SharedContent.definitionData[i, 2] == pixel.G.ToString() &&
                   SharedContent.definitionData[i, 3] == pixel.B.ToString())
                {
                    foundProvince = true;
                    provinceID = SharedContent.definitionData[i, 0];
                }
            }
            //if the province was found
            if(foundProvince)
            {
                //it's data is going to be "created"
                string content = txtScript.Text;
                if (SharedContent.usingOriginalFiles)
                    content = AssembleContent(content, provinceID);
                if (SharedContent.btChoice == 2)
                    content += "\nbase_tax = " + (new Random()).Next(SharedContent.btFromValue, SharedContent.btToValue + 1);
                if (SharedContent.bpChoice == 2)
                    content += "\nbase_production = " + (new Random()).Next(SharedContent.bpFromValue, SharedContent.bpToValue + 1);
                if (SharedContent.bmChoice == 2)
                    content += "\nbase_manpower = " + (new Random()).Next(SharedContent.bmFromValue, SharedContent.bmToValue + 1);
                //and saved in a file
                File.WriteAllText("provinces/" + provinceID + ".txt", content);
            }
        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            //checks what is the color of the pixel the user clicked on
            MouseEventArgs eCurrent = e;
            Bitmap bitmap = new Bitmap(picMap.Image);
            Color pixel = bitmap.GetPixel(eCurrent.X, eCurrent.Y);

            //now, it goes to definitions.csv and tries to find the respective "color coordinates"
            Boolean foundProvince = false;
            string provinceID = "";
            for (int i = 0; i < SharedContent.definitionData.GetLength(0); i++)
            {
                if (SharedContent.definitionData[i, 1] == pixel.R.ToString() &&
                   SharedContent.definitionData[i, 2] == pixel.G.ToString() &&
                   SharedContent.definitionData[i, 3] == pixel.B.ToString())
                {
                    foundProvince = true;
                    provinceID = SharedContent.definitionData[i, 0];
                }
            }

            if (eCurrent.Button == MouseButtons.Right && File.Exists("provinces/" + provinceID + ".txt"))
            {
                File.Delete("provinces/" + provinceID + ".txt");
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                //if the province was found
                if (foundProvince)
                {
                    //it's data is going to be "created"
                    string content = txtScript.Text;
                    if (SharedContent.usingOriginalFiles)
                        content = AssembleContent(content, provinceID);
                    if(SharedContent.btChoice == 2)
                        content += "\nbase_tax = " + (new Random()).Next(SharedContent.btFromValue, SharedContent.btToValue + 1);
                    if(SharedContent.bpChoice == 2)
                        content += "\nbase_production = " + (new Random()).Next(SharedContent.bpFromValue, SharedContent.bpToValue + 1);
                    if(SharedContent.bmChoice == 2)
                        content += "\nbase_manpower = " + (new Random()).Next(SharedContent.bmFromValue, SharedContent.bmToValue + 1);
                    //and saved in a file
                    File.WriteAllText("provinces/" + provinceID + ".txt", content);
                }
            }
        }

        private static string AssembleContent(string content, string provinceID)
        {
            content += "\n";
            for (int i = 0; i < SharedContent.provinceFilesList.Length; i++)
            {
                string currentProvince = Path.GetFileName(SharedContent.provinceFilesList[i]), extraContent = "";
                int maxLength = currentProvince.IndexOf(" ");
                //checks only the ID part of the name. Some mods use the format "ID.txt" instead of the
                //default "ID - province name.txt", so this must be done
                if((maxLength != -1 && currentProvince.Substring(0, maxLength) == provinceID) || 
                    currentProvince == provinceID + ".txt")
                {
                    if (SharedContent.originalCulture)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "culture =");
                    if (SharedContent.originalReligion)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "religion =");
                    if (SharedContent.originalHRE)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "hre =");
                    if (SharedContent.originalTradeGood)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "trade_goods =");
                    if (SharedContent.originalCapital)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "capital =");
                    if (SharedContent.originalExtraCost)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "extra_cost =");
                    if (SharedContent.originalCoT)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "center_of_trade =");
                    if (SharedContent.btChoice == 1)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "base_tax =");
                    if (SharedContent.bpChoice == 1)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "base_production =");
                    if (SharedContent.bmChoice == 1)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "base_manpower =");
                }
            }

            return content;
        }

        private static string TakeOriginalData(string[] currentFile, string searchTerm)
        {
            string extraContent = "";
            for(int i = 0; i < currentFile.Length; i++)
            {
                if (currentFile[i].Contains(searchTerm))
                {
                    extraContent += currentFile[i].Trim() + "\n";
                    break;
                }
            }
            return extraContent;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScript.Clear();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            (new frHelp()).ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new frSettings()).ShowDialog();
        }

        private void frMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Directory.Delete("provinces", true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] provinceFiles = Directory.GetFiles("provinces");
            for(int i = 0; i < provinceFiles.Length; i++)
            {
                File.Copy(provinceFiles[i], SharedContent.modPath + "/history/provinces/" + Path.GetFileName(provinceFiles[i]));
            }

        }
    }
}
