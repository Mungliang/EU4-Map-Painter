using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EU4MapPainter
{
    public partial class frPathSelectionScreen : Form
    {
        FolderBrowserDialog gameFolder = new FolderBrowserDialog();
        FolderBrowserDialog modFolder = new FolderBrowserDialog();
        public frPathSelectionScreen()
        {
            InitializeComponent();
            Select();
            if(File.Exists("paths.txt"))
            {
                gameFolder.SelectedPath = txtGamePath.Text = File.ReadAllLines("paths.txt")[0];
                modFolder.SelectedPath = txtModPath.Text = File.ReadAllLines("paths.txt")[1];
            }
        }

        private void txtGamePath_DoubleClick(object sender, EventArgs e)
        {
            //opens dialog for user to choose the game folder containing map folder
            gameFolder.Description = "Select your EU4 folder";
            DialogResult result = gameFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtGamePath.Text = gameFolder.SelectedPath;
            }
        }

        private void txtModPath_DoubleClick(object sender, EventArgs e)
        {
            //opens dialog for user to choose the game folder containing destiny (mod) folder
            modFolder.Description = "Select your mod folder";
            DialogResult result = modFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtModPath.Text = modFolder.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Text = "EU4 Map Painter " + SharedContent.version + " - Checking paths";
            Boolean defaultMapExists = true, climateTxtExists = true;
            //checks if paths are valid
            if (Directory.Exists(txtGamePath.Text.Trim() + "/map"))
            {
                if (!File.Exists(txtGamePath.Text.Trim() + "/map/definition.csv"))
                {
                    MessageBox.Show("Could not find definition.csv file on specified folder. Please, insert a valid path.", "Missing definition.csv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text = "EU4 Map Painter " + SharedContent.version + " - Select paths";
                    return;
                }
                if (!File.Exists(txtGamePath.Text.Trim() + "/map/provinces.bmp"))
                {
                    MessageBox.Show("Could not find provinces.bmp file on specified folder. Please, insert a valid path.", "Missing provinces.bmp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text = "EU4 Map Painter " + SharedContent.version + " - Select paths";
                    return;
                }
                if (!Directory.Exists(txtGamePath.Text.Trim() + "/history/provinces"))
                {
                    DialogResult result = MessageBox.Show("Could not find history/provinces folder. Copying data will not be possible. Are you sure you want to proceed?", "Missing history/provinces", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                    else
                    {
                        SharedContent.canUsePoliticalMap = false;
                        SharedContent.canCopyData = false;
                    }
                }
                if (!File.Exists(txtGamePath.Text.Trim() + "/map/default.map"))
                {
                    DialogResult result = MessageBox.Show("File default.map is missing. It will not be possible do read which provinces are sea tiles or lakes. Do you wish to continue anyway?", "Missing default.map", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                    else
                        defaultMapExists = false;
                }
                if (!File.Exists(txtGamePath.Text.Trim() + "/map/climate.txt"))
                {
                    DialogResult result = MessageBox.Show("File climate.txt is missing. It will not be possible do read which provinces are wastelands. Do you wish to continue anyway?", "Missing climate.txt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                    else
                        climateTxtExists = false;
                }
                /* [WORK IN PROGRESS]
                if (!Directory.Exists(txtGamePath.Text.Trim() + "/common/countries"))
                {
                    DialogResult result = MessageBox.Show("Could not find common/countries folder. Copying data will not be possible. Are you sure you want to proceed?", "Missing common/countries", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                    else
                        SharedContent.canUsePoliticalMap = false;
                }
                if (!Directory.Exists(txtGamePath.Text.Trim() + "/common/country_tags"))
                {
                    DialogResult result = MessageBox.Show("Could not find common/country_tags folder. Copying data will not be possible. Are you sure you want to proceed?", "Missing common/country_tags", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                        return;
                    else
                        SharedContent.canUsePoliticalMap = false;
                }
                */
            }
            else
            {
                MessageBox.Show("There is no map folder on game path. Please, insert a valid path.", "Missing map folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtModPath.Text))
            {
                MessageBox.Show("Mod path is invalid.", "No mod folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!Directory.Exists(txtModPath.Text + "/history/provinces"))
            {
                Directory.CreateDirectory(txtModPath.Text + "/history/provinces");
            }

            //creates provinces directory
            Text = "EU4 Map Painter " + SharedContent.version + " - Creating provinces directory";
            if (!Directory.Exists("provinces"))
            {
                Directory.CreateDirectory("provinces");
            }
            //saves paths
            string content = txtGamePath.Text + "\n" +
                             txtModPath.Text;
            File.WriteAllText("paths.txt", content);
            SharedContent.originalPath = txtGamePath.Text;
            SharedContent.modPath = txtModPath.Text;
            SharedContent.baseMap = Image.FromFile(txtGamePath.Text.Trim() + "/map/provinces.bmp");

            //loads definition file
            Text = "EU4 Map Painter " + SharedContent.version + " - Loading definition.csv";
            LoadDefinitions(File.ReadAllLines(txtGamePath.Text.Trim() + "/map/definition.csv", Encoding.GetEncoding("iso-8859-1")));

            //reads all history/provinces files
            Text = "EU4 Map Painter " + SharedContent.version + " - Loading provinces";
            SharedContent.provinceFilesList = Directory.GetFiles(txtGamePath.Text + "/history/provinces");
            if (Directory.Exists(txtModPath.Text.Trim() + "/history/provinces"))
            {
                string[] modProvinces = Directory.GetFiles(txtModPath.Text.Trim() + "/history/provinces/");
                for (int i = 0; i < modProvinces.Length; i++)
                {
                    File.Copy(modProvinces[i], "provinces/" + Path.GetFileName(modProvinces[i]), true);
                }
            }

            //checks which provinces are sea starts
            if (defaultMapExists)
            {
                Text = "EU4 Map Painter " + SharedContent.version + " - Reading sea starts and lakes";
                FindSeasAndLakes(File.ReadAllLines(txtGamePath.Text + "/map/default.map"));
            }
            else
                SharedContent.seaAndLakeStarts = new string[1];

            //checks which provinces are wastelands
            if (climateTxtExists)
            {
                Text = "EU4 Map Painter" + SharedContent.version + " - Reading wastelands";
                FindWasteLand(File.ReadAllLines(txtGamePath.Text + "/map/climate.txt"));
            }
            else
                SharedContent.wastelandIDs = new string[1];
            /*generates political map [WORK IN PROGRESS]
            if(SharedContent.canUsePoliticalMap)
            {
                Text = "EU4 Map Painter 1.1 - Generating political map";
                GeneratesPoliticalMap(txtGamePath.Text.Trim());
            }
            */

            Text = "EU4 Map Painter " + SharedContent.version + " - Initializing";
            Hide();
            new frMainScreen().ShowDialog();
            Close();
        }

        public static void LoadDefinitions(string[] definitionFile)
        {
            SharedContent.definitionData = new string[definitionFile.Length, 5];
            for (int i = 0; i < definitionFile.Length; i++)
            {
                try
                {
                    SharedContent.definitionData[i, 0] = definitionFile[i].Split(';')[0]; //ID
                    SharedContent.definitionData[i, 1] = definitionFile[i].Split(';')[1]; //Red
                    SharedContent.definitionData[i, 2] = definitionFile[i].Split(';')[2]; //Green
                    SharedContent.definitionData[i, 3] = definitionFile[i].Split(';')[3]; //Blue
                    SharedContent.definitionData[i, 4] = ""; //name (if doesnt exist)
                    SharedContent.definitionData[i, 4] += definitionFile[i].Split(';')[4]; //name (if exists)
                }
                catch
                {
                    continue;
                }
            }
        }

        public static void FindWasteLand(string[] climateFile)
        {
            Boolean foundImpassableTerrain = false;
            string impassableProvincesTemp = "";
            for (int i = 0; i < climateFile.Length; i++)
            {
                if (foundImpassableTerrain)
                {
                    if (climateFile[i].Contains('}'))
                        foundImpassableTerrain = false;
                    impassableProvincesTemp += climateFile[i].Trim().Replace("\t", " ") + " ";
                }
                else if (climateFile[i].Contains("impassable"))
                    foundImpassableTerrain = true;
            }
            SharedContent.wastelandIDs = impassableProvincesTemp.Trim().Split(' ');
        }

        public static void FindSeasAndLakes(string[] mapFile)
        {
            Boolean foundSeaStarts = false, foundLakes = false;
            string seaAndLakeProvincesTemp = "";
            for (int i = 0; i < mapFile.Length; i++)
            {
                if (foundSeaStarts)
                {
                    if (mapFile[i].Contains('}'))
                        foundSeaStarts = false;
                    seaAndLakeProvincesTemp += mapFile[i].Trim().Replace("\t", " ") + " ";
                }
                else if (mapFile[i].Contains("sea_starts"))
                    foundSeaStarts = true;

                if (foundLakes)
                {
                    if (mapFile[i].Contains('}'))
                        foundLakes = false;
                    seaAndLakeProvincesTemp += mapFile[i].Trim().Replace("\t", " ") + " ";
                }
                else if (mapFile[i].Contains("lakes"))
                    foundLakes = true;
            }
            SharedContent.seaAndLakeStarts = seaAndLakeProvincesTemp.Trim().Split(' ');
        }

        /* [WORK IN PROGRESS]
        public static void GeneratesPoliticalMap(string gamePath)
        {
            string historyPath = gamePath + "/history/provinces",
                   countriesPath = gamePath + "/common/countries",
                   tagsPath = gamePath + "/common/country_tags";
        }
        */
    }
}
