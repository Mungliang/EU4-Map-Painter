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
            picMap.Image = SharedContent.baseMap;
            picMap.Width = picMap.Image.Width;
            picMap.Height = picMap.Image.Height;
        }

        public Bitmap bitmap = new Bitmap(SharedContent.baseMap);

        private void picMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //checks what is the color of the pixel the user clicked on
            MouseEventArgs eCurrent = (MouseEventArgs)e;
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

            //if the province was found
            if(foundProvince)
            {
                //checks if sea or lake
                if (SharedContent.seaAndLakeStarts.Contains(provinceID))
                {
                    MessageBox.Show("You can't paint seas or lakes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //checks if wasteland
                if (SharedContent.wastelandIDs.Contains(provinceID))
                {
                    MessageBox.Show("You can't paint wastelands.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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
            else
            {
                MessageBox.Show("Province ID could not be found. Please, check your definition.csv file and restart the program.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            //checks what is the color of the pixel the user clicked on
            MouseEventArgs eCurrent = e;
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
                    break;
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
                    //checks if sea or lake
                    if (SharedContent.seaAndLakeStarts.Contains(provinceID))
                    {
                        MessageBox.Show("You can't paint seas or lakes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //checks if wasteland
                    if (SharedContent.wastelandIDs.Contains(provinceID))
                    {
                        MessageBox.Show("You can't paint wastelands.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //gets original file name
                    string provinceName = provinceID + ".txt";
                    for(int i = 0; i < SharedContent.provinceFilesList.Length; i++)
                    {
                        string currentProvince = Path.GetFileName(SharedContent.provinceFilesList[i]);
                        //checks only the ID part of the name. Some mods use the format "ID.txt" instead of the
                        //default "ID - province name.txt", so this must be done
                        if (currentProvince.Split('-')[0].Trim() == provinceID || currentProvince.Split(' ')[0].Trim() == provinceID ||
                           currentProvince.Split('.')[0].Trim() == provinceID)
                        {
                            provinceName = currentProvince;
                            break;
                        }
                    }

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
                    File.WriteAllText("provinces/" + provinceName, content, Encoding.Default);
                }
                else
                {
                    MessageBox.Show("Province ID could not be found. Please, check your definition.csv file and restart the program.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string AssembleContent(string content, string provinceID)
        {
            content += "\n";
            for (int i = 0; i < SharedContent.provinceFilesList.Length; i++)
            {
                string currentProvince = Path.GetFileName(SharedContent.provinceFilesList[i]);
                //checks only the ID part of the name. Some mods use the format "ID.txt" instead of the
                //default "ID - province name.txt", so this must be done
                if(currentProvince.Split('-')[0].Trim() == provinceID || currentProvince.Split(' ')[0].Trim() == provinceID ||
                   currentProvince.Split('.')[0].Trim() == provinceID)
                {
                    if (SharedContent.originalCulture)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "culture =");
                    if (SharedContent.originalReligion)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "religion =");
                    if (SharedContent.originalHRE)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "hre =");
                    if (SharedContent.originalCapital)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i], Encoding.GetEncoding("iso-8859-1")), "capital =");
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
                    if (SharedContent.originalTradeGood)
                        content += TakeOriginalData(File.ReadAllLines(SharedContent.provinceFilesList[i]), "trade_goods =");
                }
            }

            return content;
        }

        private static string TakeOriginalData(string[] currentFile, string searchTerm)
        {
            string extraContent = "";
            if(!(searchTerm == "trade_goods ="))
            {
                for (int i = 0; i < currentFile.Length; i++)
                {
                    if (currentFile[i].Contains(searchTerm))
                    {
                        extraContent += currentFile[i].Trim() + "\n";
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < currentFile.Length; i++)
                {
                    if (currentFile[i].Contains("trade_goods =") && !currentFile[i].Contains("latent_trade_goods ="))
                    {
                        extraContent += currentFile[i].Trim() + "\n";
                        break;
                    }
                }

                for (int i = 0; i < currentFile.Length; i++)
                {
                    if (currentFile[i].Contains("latent_trade_goods ="))
                    {
                        while(true)
                        {
                            extraContent += currentFile[i].Trim() + " ";
                            if (currentFile[i].Contains("}"))
                            {
                                extraContent += "\n";
                                break;
                            }
                            i++;
                        }
                        break;
                    }
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
            DialogResult result = MessageBox.Show("Are you sure you want to quit? Unsaved progress will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                Directory.Delete("provinces", true);
            else
                e.Cancel = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] provinceFiles = Directory.GetFiles("provinces");
            for (int i = 0; i < provinceFiles.Length; i++)
            {
                File.Copy(provinceFiles[i], SharedContent.modPath + "/history/provinces/" + Path.GetFileName(provinceFiles[i]), true);
            }

        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs eCurrent = e;
            Color pixel = bitmap.GetPixel(eCurrent.X, eCurrent.Y);
            //now, it goes to definitions.csv and tries to find the respective "color coordinates"
            string provinceID = "", provinceName = "";
            for (int i = 0; i < SharedContent.definitionData.GetLength(0); i++)
            {
                if (SharedContent.definitionData[i, 1] == pixel.R.ToString() &&
                   SharedContent.definitionData[i, 2] == pixel.G.ToString() &&
                   SharedContent.definitionData[i, 3] == pixel.B.ToString())
                {
                    provinceID = SharedContent.definitionData[i, 0];
                    provinceName = SharedContent.definitionData[i, 4];
                    break;
                }
            }
            lblProvName.Text = "Name: " + provinceName + "\nID: " + provinceID;
        }
    }
}
