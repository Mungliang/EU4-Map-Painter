namespace EU4MapPainter
{
    partial class frSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSettings));
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbCoT = new System.Windows.Forms.CheckBox();
            this.cbExtraCost = new System.Windows.Forms.CheckBox();
            this.cbCapitalName = new System.Windows.Forms.CheckBox();
            this.cbTradeGood = new System.Windows.Forms.CheckBox();
            this.cbHRE = new System.Windows.Forms.CheckBox();
            this.cbReligion = new System.Windows.Forms.CheckBox();
            this.cbCulture = new System.Windows.Forms.CheckBox();
            this.gbBaseTax = new System.Windows.Forms.GroupBox();
            this.numToBT = new System.Windows.Forms.NumericUpDown();
            this.lblToBT = new System.Windows.Forms.Label();
            this.lblFromBT = new System.Windows.Forms.Label();
            this.numFromBT = new System.Windows.Forms.NumericUpDown();
            this.rbRandomBT = new System.Windows.Forms.RadioButton();
            this.rbOriginalBT = new System.Windows.Forms.RadioButton();
            this.rbScriptBT = new System.Windows.Forms.RadioButton();
            this.gbBaseProduction = new System.Windows.Forms.GroupBox();
            this.numToBP = new System.Windows.Forms.NumericUpDown();
            this.lblToBP = new System.Windows.Forms.Label();
            this.lblFromBP = new System.Windows.Forms.Label();
            this.numFromBP = new System.Windows.Forms.NumericUpDown();
            this.rbRandomBP = new System.Windows.Forms.RadioButton();
            this.rbOriginalBP = new System.Windows.Forms.RadioButton();
            this.rbScriptBP = new System.Windows.Forms.RadioButton();
            this.gbBaseManpower = new System.Windows.Forms.GroupBox();
            this.numToBM = new System.Windows.Forms.NumericUpDown();
            this.lblToBM = new System.Windows.Forms.Label();
            this.lblFromBM = new System.Windows.Forms.Label();
            this.numFromBM = new System.Windows.Forms.NumericUpDown();
            this.rbRandomBM = new System.Windows.Forms.RadioButton();
            this.rbOriginalBM = new System.Windows.Forms.RadioButton();
            this.rbScriptBM = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttSettings = new System.Windows.Forms.ToolTip(this.components);
            this.gbGeneral.SuspendLayout();
            this.gbBaseTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBT)).BeginInit();
            this.gbBaseProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBP)).BeginInit();
            this.gbBaseManpower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBM)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.cbCoT);
            this.gbGeneral.Controls.Add(this.cbExtraCost);
            this.gbGeneral.Controls.Add(this.cbCapitalName);
            this.gbGeneral.Controls.Add(this.cbTradeGood);
            this.gbGeneral.Controls.Add(this.cbHRE);
            this.gbGeneral.Controls.Add(this.cbReligion);
            this.gbGeneral.Controls.Add(this.cbCulture);
            this.gbGeneral.ForeColor = System.Drawing.Color.White;
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(282, 220);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            this.ttSettings.SetToolTip(this.gbGeneral, "Use the informations given by the files in the original folder.");
            // 
            // cbCoT
            // 
            this.cbCoT.AutoSize = true;
            this.cbCoT.Location = new System.Drawing.Point(6, 183);
            this.cbCoT.Name = "cbCoT";
            this.cbCoT.Size = new System.Drawing.Size(235, 21);
            this.cbCoT.TabIndex = 6;
            this.cbCoT.Text = "Use original center of trade level";
            this.cbCoT.UseVisualStyleBackColor = true;
            // 
            // cbExtraCost
            // 
            this.cbExtraCost.AutoSize = true;
            this.cbExtraCost.Location = new System.Drawing.Point(6, 156);
            this.cbExtraCost.Name = "cbExtraCost";
            this.cbExtraCost.Size = new System.Drawing.Size(170, 21);
            this.cbExtraCost.TabIndex = 5;
            this.cbExtraCost.Text = "Use original extra cost";
            this.cbExtraCost.UseVisualStyleBackColor = true;
            // 
            // cbCapitalName
            // 
            this.cbCapitalName.AutoSize = true;
            this.cbCapitalName.Location = new System.Drawing.Point(6, 129);
            this.cbCapitalName.Name = "cbCapitalName";
            this.cbCapitalName.Size = new System.Drawing.Size(189, 21);
            this.cbCapitalName.TabIndex = 4;
            this.cbCapitalName.Text = "Use original capital name";
            this.cbCapitalName.UseVisualStyleBackColor = true;
            // 
            // cbTradeGood
            // 
            this.cbTradeGood.AutoSize = true;
            this.cbTradeGood.Location = new System.Drawing.Point(6, 102);
            this.cbTradeGood.Name = "cbTradeGood";
            this.cbTradeGood.Size = new System.Drawing.Size(178, 21);
            this.cbTradeGood.TabIndex = 3;
            this.cbTradeGood.Text = "Use original trade good";
            this.cbTradeGood.UseVisualStyleBackColor = true;
            // 
            // cbHRE
            // 
            this.cbHRE.AutoSize = true;
            this.cbHRE.Location = new System.Drawing.Point(6, 75);
            this.cbHRE.Name = "cbHRE";
            this.cbHRE.Size = new System.Drawing.Size(180, 21);
            this.cbHRE.TabIndex = 2;
            this.cbHRE.Text = "Use original HRE status";
            this.cbHRE.UseVisualStyleBackColor = true;
            // 
            // cbReligion
            // 
            this.cbReligion.AutoSize = true;
            this.cbReligion.Location = new System.Drawing.Point(6, 48);
            this.cbReligion.Name = "cbReligion";
            this.cbReligion.Size = new System.Drawing.Size(155, 21);
            this.cbReligion.TabIndex = 1;
            this.cbReligion.Text = "Use original religion";
            this.cbReligion.UseVisualStyleBackColor = true;
            // 
            // cbCulture
            // 
            this.cbCulture.AutoSize = true;
            this.cbCulture.Location = new System.Drawing.Point(6, 21);
            this.cbCulture.Name = "cbCulture";
            this.cbCulture.Size = new System.Drawing.Size(152, 21);
            this.cbCulture.TabIndex = 0;
            this.cbCulture.Text = "Use original culture";
            this.cbCulture.UseVisualStyleBackColor = true;
            // 
            // gbBaseTax
            // 
            this.gbBaseTax.Controls.Add(this.numToBT);
            this.gbBaseTax.Controls.Add(this.lblToBT);
            this.gbBaseTax.Controls.Add(this.lblFromBT);
            this.gbBaseTax.Controls.Add(this.numFromBT);
            this.gbBaseTax.Controls.Add(this.rbRandomBT);
            this.gbBaseTax.Controls.Add(this.rbOriginalBT);
            this.gbBaseTax.Controls.Add(this.rbScriptBT);
            this.gbBaseTax.ForeColor = System.Drawing.Color.White;
            this.gbBaseTax.Location = new System.Drawing.Point(300, 12);
            this.gbBaseTax.Name = "gbBaseTax";
            this.gbBaseTax.Size = new System.Drawing.Size(140, 220);
            this.gbBaseTax.TabIndex = 1;
            this.gbBaseTax.TabStop = false;
            this.gbBaseTax.Text = "Base Tax";
            this.ttSettings.SetToolTip(this.gbBaseTax, "Sets how base tax value is going to be defined.");
            // 
            // numToBT
            // 
            this.numToBT.Enabled = false;
            this.numToBT.Location = new System.Drawing.Point(6, 163);
            this.numToBT.Name = "numToBT";
            this.numToBT.Size = new System.Drawing.Size(120, 22);
            this.numToBT.TabIndex = 6;
            // 
            // lblToBT
            // 
            this.lblToBT.AutoSize = true;
            this.lblToBT.Location = new System.Drawing.Point(6, 143);
            this.lblToBT.Name = "lblToBT";
            this.lblToBT.Size = new System.Drawing.Size(24, 17);
            this.lblToBT.TabIndex = 5;
            this.lblToBT.Text = "to:";
            // 
            // lblFromBT
            // 
            this.lblFromBT.AutoSize = true;
            this.lblFromBT.Location = new System.Drawing.Point(6, 98);
            this.lblFromBT.Name = "lblFromBT";
            this.lblFromBT.Size = new System.Drawing.Size(40, 17);
            this.lblFromBT.TabIndex = 4;
            this.lblFromBT.Text = "from:";
            // 
            // numFromBT
            // 
            this.numFromBT.Enabled = false;
            this.numFromBT.Location = new System.Drawing.Point(7, 118);
            this.numFromBT.Name = "numFromBT";
            this.numFromBT.Size = new System.Drawing.Size(120, 22);
            this.numFromBT.TabIndex = 3;
            // 
            // rbRandomBT
            // 
            this.rbRandomBT.AutoSize = true;
            this.rbRandomBT.Location = new System.Drawing.Point(7, 74);
            this.rbRandomBT.Name = "rbRandomBT";
            this.rbRandomBT.Size = new System.Drawing.Size(110, 21);
            this.rbRandomBT.TabIndex = 2;
            this.rbRandomBT.Text = "Use random:";
            this.rbRandomBT.UseVisualStyleBackColor = true;
            this.rbRandomBT.CheckedChanged += new System.EventHandler(this.rbRandomBT_CheckedChanged);
            // 
            // rbOriginalBT
            // 
            this.rbOriginalBT.AutoSize = true;
            this.rbOriginalBT.Location = new System.Drawing.Point(7, 47);
            this.rbOriginalBT.Name = "rbOriginalBT";
            this.rbOriginalBT.Size = new System.Drawing.Size(104, 21);
            this.rbOriginalBT.TabIndex = 1;
            this.rbOriginalBT.Text = "Use original";
            this.rbOriginalBT.UseVisualStyleBackColor = true;
            this.rbOriginalBT.CheckedChanged += new System.EventHandler(this.rbOriginalBT_CheckedChanged);
            // 
            // rbScriptBT
            // 
            this.rbScriptBT.AutoSize = true;
            this.rbScriptBT.Checked = true;
            this.rbScriptBT.Location = new System.Drawing.Point(7, 21);
            this.rbScriptBT.Name = "rbScriptBT";
            this.rbScriptBT.Size = new System.Drawing.Size(65, 21);
            this.rbScriptBT.TabIndex = 0;
            this.rbScriptBT.TabStop = true;
            this.rbScriptBT.Text = "Script";
            this.rbScriptBT.UseVisualStyleBackColor = true;
            this.rbScriptBT.CheckedChanged += new System.EventHandler(this.rbScriptBT_CheckedChanged);
            // 
            // gbBaseProduction
            // 
            this.gbBaseProduction.Controls.Add(this.numToBP);
            this.gbBaseProduction.Controls.Add(this.lblToBP);
            this.gbBaseProduction.Controls.Add(this.lblFromBP);
            this.gbBaseProduction.Controls.Add(this.numFromBP);
            this.gbBaseProduction.Controls.Add(this.rbRandomBP);
            this.gbBaseProduction.Controls.Add(this.rbOriginalBP);
            this.gbBaseProduction.Controls.Add(this.rbScriptBP);
            this.gbBaseProduction.ForeColor = System.Drawing.Color.White;
            this.gbBaseProduction.Location = new System.Drawing.Point(446, 12);
            this.gbBaseProduction.Name = "gbBaseProduction";
            this.gbBaseProduction.Size = new System.Drawing.Size(140, 220);
            this.gbBaseProduction.TabIndex = 7;
            this.gbBaseProduction.TabStop = false;
            this.gbBaseProduction.Text = "Base Production";
            this.ttSettings.SetToolTip(this.gbBaseProduction, "Sets how base production value is going to be defined.");
            // 
            // numToBP
            // 
            this.numToBP.Enabled = false;
            this.numToBP.Location = new System.Drawing.Point(6, 163);
            this.numToBP.Name = "numToBP";
            this.numToBP.Size = new System.Drawing.Size(120, 22);
            this.numToBP.TabIndex = 6;
            // 
            // lblToBP
            // 
            this.lblToBP.AutoSize = true;
            this.lblToBP.Location = new System.Drawing.Point(6, 143);
            this.lblToBP.Name = "lblToBP";
            this.lblToBP.Size = new System.Drawing.Size(24, 17);
            this.lblToBP.TabIndex = 5;
            this.lblToBP.Text = "to:";
            // 
            // lblFromBP
            // 
            this.lblFromBP.AutoSize = true;
            this.lblFromBP.Location = new System.Drawing.Point(6, 98);
            this.lblFromBP.Name = "lblFromBP";
            this.lblFromBP.Size = new System.Drawing.Size(40, 17);
            this.lblFromBP.TabIndex = 4;
            this.lblFromBP.Text = "from:";
            // 
            // numFromBP
            // 
            this.numFromBP.Enabled = false;
            this.numFromBP.Location = new System.Drawing.Point(7, 118);
            this.numFromBP.Name = "numFromBP";
            this.numFromBP.Size = new System.Drawing.Size(120, 22);
            this.numFromBP.TabIndex = 3;
            // 
            // rbRandomBP
            // 
            this.rbRandomBP.AutoSize = true;
            this.rbRandomBP.Location = new System.Drawing.Point(7, 74);
            this.rbRandomBP.Name = "rbRandomBP";
            this.rbRandomBP.Size = new System.Drawing.Size(110, 21);
            this.rbRandomBP.TabIndex = 2;
            this.rbRandomBP.Text = "Use random:";
            this.rbRandomBP.UseVisualStyleBackColor = true;
            this.rbRandomBP.CheckedChanged += new System.EventHandler(this.rbRandomBP_CheckedChanged);
            // 
            // rbOriginalBP
            // 
            this.rbOriginalBP.AutoSize = true;
            this.rbOriginalBP.Location = new System.Drawing.Point(7, 47);
            this.rbOriginalBP.Name = "rbOriginalBP";
            this.rbOriginalBP.Size = new System.Drawing.Size(104, 21);
            this.rbOriginalBP.TabIndex = 1;
            this.rbOriginalBP.Text = "Use original";
            this.rbOriginalBP.UseVisualStyleBackColor = true;
            this.rbOriginalBP.CheckedChanged += new System.EventHandler(this.rbOriginalBP_CheckedChanged);
            // 
            // rbScriptBP
            // 
            this.rbScriptBP.AutoSize = true;
            this.rbScriptBP.Checked = true;
            this.rbScriptBP.Location = new System.Drawing.Point(7, 21);
            this.rbScriptBP.Name = "rbScriptBP";
            this.rbScriptBP.Size = new System.Drawing.Size(65, 21);
            this.rbScriptBP.TabIndex = 0;
            this.rbScriptBP.TabStop = true;
            this.rbScriptBP.Text = "Script";
            this.rbScriptBP.UseVisualStyleBackColor = true;
            this.rbScriptBP.CheckedChanged += new System.EventHandler(this.rbScriptBP_CheckedChanged);
            // 
            // gbBaseManpower
            // 
            this.gbBaseManpower.Controls.Add(this.numToBM);
            this.gbBaseManpower.Controls.Add(this.lblToBM);
            this.gbBaseManpower.Controls.Add(this.lblFromBM);
            this.gbBaseManpower.Controls.Add(this.numFromBM);
            this.gbBaseManpower.Controls.Add(this.rbRandomBM);
            this.gbBaseManpower.Controls.Add(this.rbOriginalBM);
            this.gbBaseManpower.Controls.Add(this.rbScriptBM);
            this.gbBaseManpower.ForeColor = System.Drawing.Color.White;
            this.gbBaseManpower.Location = new System.Drawing.Point(592, 12);
            this.gbBaseManpower.Name = "gbBaseManpower";
            this.gbBaseManpower.Size = new System.Drawing.Size(140, 220);
            this.gbBaseManpower.TabIndex = 8;
            this.gbBaseManpower.TabStop = false;
            this.gbBaseManpower.Text = "Base Production";
            this.ttSettings.SetToolTip(this.gbBaseManpower, "Sets how base manpower value is going to be defined.");
            // 
            // numToBM
            // 
            this.numToBM.Enabled = false;
            this.numToBM.Location = new System.Drawing.Point(6, 163);
            this.numToBM.Name = "numToBM";
            this.numToBM.Size = new System.Drawing.Size(120, 22);
            this.numToBM.TabIndex = 6;
            // 
            // lblToBM
            // 
            this.lblToBM.AutoSize = true;
            this.lblToBM.Location = new System.Drawing.Point(6, 143);
            this.lblToBM.Name = "lblToBM";
            this.lblToBM.Size = new System.Drawing.Size(24, 17);
            this.lblToBM.TabIndex = 5;
            this.lblToBM.Text = "to:";
            // 
            // lblFromBM
            // 
            this.lblFromBM.AutoSize = true;
            this.lblFromBM.Location = new System.Drawing.Point(6, 98);
            this.lblFromBM.Name = "lblFromBM";
            this.lblFromBM.Size = new System.Drawing.Size(40, 17);
            this.lblFromBM.TabIndex = 4;
            this.lblFromBM.Text = "from:";
            // 
            // numFromBM
            // 
            this.numFromBM.Enabled = false;
            this.numFromBM.Location = new System.Drawing.Point(7, 118);
            this.numFromBM.Name = "numFromBM";
            this.numFromBM.Size = new System.Drawing.Size(120, 22);
            this.numFromBM.TabIndex = 3;
            // 
            // rbRandomBM
            // 
            this.rbRandomBM.AutoSize = true;
            this.rbRandomBM.Location = new System.Drawing.Point(7, 74);
            this.rbRandomBM.Name = "rbRandomBM";
            this.rbRandomBM.Size = new System.Drawing.Size(110, 21);
            this.rbRandomBM.TabIndex = 2;
            this.rbRandomBM.Text = "Use random:";
            this.rbRandomBM.UseVisualStyleBackColor = true;
            this.rbRandomBM.CheckedChanged += new System.EventHandler(this.rbRandomBM_CheckedChanged);
            // 
            // rbOriginalBM
            // 
            this.rbOriginalBM.AutoSize = true;
            this.rbOriginalBM.Location = new System.Drawing.Point(7, 47);
            this.rbOriginalBM.Name = "rbOriginalBM";
            this.rbOriginalBM.Size = new System.Drawing.Size(104, 21);
            this.rbOriginalBM.TabIndex = 1;
            this.rbOriginalBM.Text = "Use original";
            this.rbOriginalBM.UseVisualStyleBackColor = true;
            this.rbOriginalBM.CheckedChanged += new System.EventHandler(this.rbOriginalBM_CheckedChanged);
            // 
            // rbScriptBM
            // 
            this.rbScriptBM.AutoSize = true;
            this.rbScriptBM.Checked = true;
            this.rbScriptBM.Location = new System.Drawing.Point(7, 21);
            this.rbScriptBM.Name = "rbScriptBM";
            this.rbScriptBM.Size = new System.Drawing.Size(65, 21);
            this.rbScriptBM.TabIndex = 0;
            this.rbScriptBM.TabStop = true;
            this.rbScriptBM.Text = "Script";
            this.rbScriptBM.UseVisualStyleBackColor = true;
            this.rbScriptBM.CheckedChanged += new System.EventHandler(this.rbScriptBM_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(18, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(712, 57);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(742, 307);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbBaseManpower);
            this.Controls.Add(this.gbBaseProduction);
            this.Controls.Add(this.gbBaseTax);
            this.Controls.Add(this.gbGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EU4 Map Painter - Settings";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbBaseTax.ResumeLayout(false);
            this.gbBaseTax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBT)).EndInit();
            this.gbBaseProduction.ResumeLayout(false);
            this.gbBaseProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBP)).EndInit();
            this.gbBaseManpower.ResumeLayout(false);
            this.gbBaseManpower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromBM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbCulture;
        private System.Windows.Forms.CheckBox cbHRE;
        private System.Windows.Forms.CheckBox cbReligion;
        private System.Windows.Forms.CheckBox cbTradeGood;
        private System.Windows.Forms.CheckBox cbCapitalName;
        private System.Windows.Forms.CheckBox cbCoT;
        private System.Windows.Forms.CheckBox cbExtraCost;
        private System.Windows.Forms.GroupBox gbBaseTax;
        private System.Windows.Forms.NumericUpDown numToBT;
        private System.Windows.Forms.Label lblToBT;
        private System.Windows.Forms.Label lblFromBT;
        private System.Windows.Forms.NumericUpDown numFromBT;
        private System.Windows.Forms.RadioButton rbRandomBT;
        private System.Windows.Forms.RadioButton rbOriginalBT;
        private System.Windows.Forms.RadioButton rbScriptBT;
        private System.Windows.Forms.GroupBox gbBaseProduction;
        private System.Windows.Forms.NumericUpDown numToBP;
        private System.Windows.Forms.Label lblToBP;
        private System.Windows.Forms.Label lblFromBP;
        private System.Windows.Forms.NumericUpDown numFromBP;
        private System.Windows.Forms.RadioButton rbRandomBP;
        private System.Windows.Forms.RadioButton rbOriginalBP;
        private System.Windows.Forms.RadioButton rbScriptBP;
        private System.Windows.Forms.GroupBox gbBaseManpower;
        private System.Windows.Forms.NumericUpDown numToBM;
        private System.Windows.Forms.Label lblToBM;
        private System.Windows.Forms.Label lblFromBM;
        private System.Windows.Forms.NumericUpDown numFromBM;
        private System.Windows.Forms.RadioButton rbRandomBM;
        private System.Windows.Forms.RadioButton rbOriginalBM;
        private System.Windows.Forms.RadioButton rbScriptBM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip ttSettings;
    }
}