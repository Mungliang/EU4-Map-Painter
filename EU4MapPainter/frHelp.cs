using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EU4MapPainter
{
    public partial class frHelp : Form
    {
        public frHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eu4.paradoxwikis.com/History_modding");
        }

        private void btnScripts_Click(object sender, EventArgs e)
        {
            lblInstruction.Text = "owner => refers to the owner of the province by country tag.\n" +
                                  "controller => refers to the country tag that controls this province.\n" +
                                  "add_core => adds a core of a certain tag to the province.\n" +
                                  "is_city => whether this province is a proper city or a colony.\n" +
                                  "culture => the culture of the province.\n" +
                                  "religion => the religion of the province.\n" +
                                  "base_tax => the base tax of the province.\n" +
                                  "base_production => the base production of the province.\n" +
                                  "base_manpower => the base manpower of the province\n" +
                                  "trade_goods => the goods produced in this province (from 00_tradegoods.txt)\n" +
                                  "hre => whether or not this province is in the HRE.\n" +
                                  "capital => name of the capital of this province.\n" +
                                  "discovered_by => who or which technology group knows this province\n" +
                                  "(i.e. don't see it as Terra Incognita).\n" +
                                  "reformation_center => if this province is a reformation center and of which religion.\n" +
                                  "unrest => base unrest level.\n" +
                                  "<building> => if certain building is built in the province.\n" +
                                  "extra_cost => extra cost in peace deals to take this province.\n" +
                                  "center_of_trade => level of center of trade the province has (1-3).\n" +
                                  "revolt => if a revolt is happening, what kind of revolt, what size and who's the leader.\n" +
                                  "<year>.<month>.<day> => you can specify when any of the informations above shall\n" +
                                  "start having effect.";
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            lblInstruction.Text = "Double click or click while holding shift to select a province and attribute data to it.\n" +
                                  "Right click to remove the data attributed currently to said province.\n" +
                                  "\n" +
                                  "On Settings, you may choose to copy data from original province files (the ones in\n" +
                                  "the original folder). For example: province ID 1 has capital name set to \"Stockholm\".\n" +
                                  "By enabling the \"Use original capital name\", whenever you edit province 1, it will be\n" +
                                  "included the string \"capital = \"Stockholm\"\" to the code.\n" +
                                  "\n" +
                                  "You can also choose to randomize development by setting up an interval of numbers\n" +
                                  "for each type of development (base tax, base production and base manpower).";
        }
    }
}
