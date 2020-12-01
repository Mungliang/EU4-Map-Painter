namespace EU4MapPainter
{
    partial class frMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMainScreen));
            this.btnHelp = new System.Windows.Forms.Button();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttProvNames = new System.Windows.Forms.ToolTip(this.components);
            this.lblProvName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(244, 36);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(3, 3);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(100, 50);
            this.picMap.TabIndex = 3;
            this.picMap.TabStop = false;
            this.picMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseClick);
            this.picMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseDoubleClick);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            // 
            // panelMap
            // 
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMap.AutoScroll = true;
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMap.Controls.Add(this.picMap);
            this.panelMap.Location = new System.Drawing.Point(262, 13);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(528, 721);
            this.panelMap.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 553);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(244, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtScript
            // 
            this.txtScript.AcceptsTab = true;
            this.txtScript.Location = new System.Drawing.Point(13, 55);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(243, 492);
            this.txtScript.TabIndex = 8;
            this.txtScript.TabStop = false;
            this.txtScript.Text = resources.GetString("txtScript.Text");
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 595);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(244, 36);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ttProvNames
            // 
            this.ttProvNames.AutoPopDelay = 1000;
            this.ttProvNames.InitialDelay = 500;
            this.ttProvNames.ReshowDelay = 100;
            // 
            // lblProvName
            // 
            this.lblProvName.AutoSize = true;
            this.lblProvName.Location = new System.Drawing.Point(12, 676);
            this.lblProvName.Name = "lblProvName";
            this.lblProvName.Size = new System.Drawing.Size(147, 34);
            this.lblProvName.TabIndex = 9;
            this.lblProvName.Text = "Name: Province name\r\nID: Province ID";
            // 
            // frMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(802, 746);
            this.Controls.Add(this.lblProvName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EU4 Map Painter 1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMainScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip ttProvNames;
        private System.Windows.Forms.Label lblProvName;
    }
}