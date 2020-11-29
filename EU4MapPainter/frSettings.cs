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
    public partial class frSettings : Form
    {
        public frSettings()
        {
            InitializeComponent();
            //checks if it is possible to gather data from original folder
            if(SharedContent.canCopyData)
            {
                //checks saved settings
                //general tab
                if (SharedContent.originalCulture)
                    cbCulture.Checked = true;
                if (SharedContent.originalReligion)
                    cbReligion.Checked = true;
                if (SharedContent.originalHRE)
                    cbHRE.Checked = true;
                if (SharedContent.originalTradeGood)
                    cbTradeGood.Checked = true;
                if (SharedContent.originalCapital)
                    cbCapitalName.Checked = true;
                if (SharedContent.originalExtraCost)
                    cbExtraCost.Checked = true;
                if (SharedContent.originalCoT)
                    cbCoT.Checked = true;

                //base tax tab
                if (SharedContent.btChoice == 0)
                    rbScriptBT.Checked = true;
                else if (SharedContent.btChoice == 1)
                    rbOriginalBT.Checked = true;
                else
                {
                    rbRandomBT.Checked = true;
                    numFromBT.Value = SharedContent.btFromValue;
                    numToBT.Value = SharedContent.btToValue;
                }

                //base production tab
                if (SharedContent.bpChoice == 0)
                    rbScriptBP.Checked = true;
                else if (SharedContent.bpChoice == 1)
                    rbOriginalBP.Checked = true;
                else
                {
                    rbRandomBP.Checked = true;
                    numFromBP.Value = SharedContent.bpFromValue;
                    numToBP.Value = SharedContent.bpToValue;
                }

                //base manpower tab
                if (SharedContent.bmChoice == 0)
                    rbScriptBM.Checked = true;
                else if (SharedContent.bmChoice == 1)
                    rbOriginalBM.Checked = true;
                else
                {
                    rbRandomBM.Checked = true;
                    numFromBM.Value = SharedContent.bmFromValue;
                    numToBM.Value = SharedContent.bmToValue;
                }
            }
            else
            {
                cbCulture.Enabled = false;
                cbReligion.Enabled = false;
                cbHRE.Enabled = false;
                cbTradeGood.Enabled = false;
                cbCapitalName.Enabled = false;
                cbExtraCost.Enabled = false;
                cbCoT.Enabled = false;
                rbOriginalBT.Enabled = false;
                rbOriginalBP.Enabled = false;
                rbOriginalBM.Enabled = false;
            }
        }

        private void rbScriptBT_CheckedChanged(object sender, EventArgs e)
        {
            numFromBT.Enabled = false;
            numFromBT.Value = 0;
            numToBT.Enabled = false;
            numToBT.Value = 0;
        }

        private void rbOriginalBT_CheckedChanged(object sender, EventArgs e)
        {
            numFromBT.Enabled = false;
            numFromBT.Value = 0;
            numToBT.Enabled = false;
            numToBT.Value = 0;
        }

        private void rbRandomBT_CheckedChanged(object sender, EventArgs e)
        {
            numFromBT.Enabled = true;
            numToBT.Enabled = true;
        }

        private void rbScriptBP_CheckedChanged(object sender, EventArgs e)
        {
            numFromBP.Enabled = false;
            numFromBP.Value = 0;
            numToBP.Enabled = false;
            numToBP.Value = 0;
        }

        private void rbOriginalBP_CheckedChanged(object sender, EventArgs e)
        {
            numFromBP.Enabled = false;
            numFromBP.Value = 0;
            numToBP.Enabled = false;
            numToBP.Value = 0;
        }

        private void rbRandomBP_CheckedChanged(object sender, EventArgs e)
        {
            numFromBP.Enabled = true;
            numToBP.Enabled = true;
        }

        private void rbScriptBM_CheckedChanged(object sender, EventArgs e)
        {
            numFromBM.Enabled = false;
            numFromBM.Value = 0;
            numToBM.Enabled = false;
            numToBM.Value = 0;
        }

        private void rbOriginalBM_CheckedChanged(object sender, EventArgs e)
        {
            numFromBM.Enabled = false;
            numFromBM.Value = 0;
            numToBM.Enabled = false;
            numToBM.Value = 0;
        }

        private void rbRandomBM_CheckedChanged(object sender, EventArgs e)
        {
            numFromBM.Enabled = true;
            numToBM.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saves settings
            //general tab
            if (cbCulture.Checked)
                SharedContent.originalCulture = true;
            if (cbReligion.Checked)
                SharedContent.originalReligion = true;
            if (cbHRE.Checked)
                SharedContent.originalHRE = true;
            if (cbTradeGood.Checked)
                SharedContent.originalTradeGood = true;
            if (cbCapitalName.Checked)
                SharedContent.originalCapital = true;
            if (cbExtraCost.Checked)
                SharedContent.originalExtraCost = true;
            if (cbCoT.Checked)
                SharedContent.originalCoT = true;

            //base tax tab
            if (rbScriptBT.Checked)
                SharedContent.btChoice = 0;
            else if (rbOriginalBT.Checked)
                SharedContent.btChoice = 1;
            else if (rbRandomBT.Checked)
                SharedContent.btChoice = 2;

            //base production tab
            if (rbScriptBP.Checked)
                SharedContent.bpChoice = 0;
            else if (rbOriginalBP.Checked)
                SharedContent.bpChoice = 1;
            else if(rbRandomBP.Checked)
            {
                SharedContent.bpChoice = 2;
            }

            //base manpower tab
            if (rbScriptBM.Checked)
                SharedContent.bmChoice = 0;
            else if (rbOriginalBM.Checked)
                SharedContent.bmChoice = 1;
            else if (rbRandomBM.Checked)
                SharedContent.bmChoice = 2;

            //saves random values
            if(numToBT.Value >= numFromBT.Value)
            {
                SharedContent.btFromValue = Convert.ToInt32(numFromBT.Value);
                SharedContent.btToValue = Convert.ToInt32(numToBT.Value);
            }
            else
            {
                MessageBox.Show("The random interval of base tax value must be from a smaller number to a bigger number.", "Wrong random interval", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numToBP.Value >= numFromBP.Value)
            {
                SharedContent.bpFromValue = Convert.ToInt32(numFromBP.Value);
                SharedContent.bpToValue = Convert.ToInt32(numToBP.Value);
            }
            else
            {
                MessageBox.Show("The random interval of base production value must be from a smaller number to a bigger number.", "Wrong random interval", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numToBM.Value >= numFromBM.Value)
            {
                SharedContent.bmFromValue = Convert.ToInt32(numFromBM.Value);
                SharedContent.bmToValue = Convert.ToInt32(numToBM.Value);
            }
            else
            {
                MessageBox.Show("The random interval of base manpower value must be from a smaller number to a bigger number.", "Wrong random interval", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SharedContent.originalCulture || SharedContent.originalReligion || SharedContent.originalHRE ||
               SharedContent.originalTradeGood || SharedContent.originalCapital || SharedContent.originalExtraCost ||
               SharedContent.originalCoT || SharedContent.btChoice == 2 || SharedContent.bpChoice == 2 ||
               SharedContent.bmChoice == 2)
                SharedContent.usingOriginalFiles = true;
            else
                SharedContent.usingOriginalFiles = false;

            Close();
        }
    }
}
