namespace EU4MapPainter
{
    partial class frPathSelectionScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPathSelectionScreen));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblGamePath = new System.Windows.Forms.Label();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.txtModPath = new System.Windows.Forms.TextBox();
            this.lblModPath = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblGamePath
            // 
            this.lblGamePath.AutoSize = true;
            this.lblGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePath.Location = new System.Drawing.Point(12, 21);
            this.lblGamePath.Name = "lblGamePath";
            this.lblGamePath.Size = new System.Drawing.Size(156, 29);
            this.lblGamePath.TabIndex = 0;
            this.lblGamePath.Text = "Original path:";
            // 
            // txtGamePath
            // 
            this.txtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePath.Location = new System.Drawing.Point(17, 63);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(539, 34);
            this.txtGamePath.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtGamePath, "Double click to find folder");
            this.txtGamePath.DoubleClick += new System.EventHandler(this.txtGamePath_DoubleClick);
            // 
            // txtModPath
            // 
            this.txtModPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModPath.Location = new System.Drawing.Point(17, 197);
            this.txtModPath.Name = "txtModPath";
            this.txtModPath.Size = new System.Drawing.Size(539, 34);
            this.txtModPath.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtModPath, "Double click to find folder");
            this.txtModPath.DoubleClick += new System.EventHandler(this.txtModPath_DoubleClick);
            // 
            // lblModPath
            // 
            this.lblModPath.AutoSize = true;
            this.lblModPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModPath.Location = new System.Drawing.Point(12, 155);
            this.lblModPath.Name = "lblModPath";
            this.lblModPath.Size = new System.Drawing.Size(119, 29);
            this.lblModPath.TabIndex = 3;
            this.lblModPath.Text = "Mod path:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(481, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 46);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 150;
            // 
            // frPathSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtModPath);
            this.Controls.Add(this.lblModPath);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.lblGamePath);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frPathSelectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EU4 Map Painter " + SharedContent.version + " - Select paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblGamePath;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.TextBox txtModPath;
        private System.Windows.Forms.Label lblModPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

