namespace EU4MapPainter
{
    partial class frHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frHelp));
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnCommands = new System.Windows.Forms.Button();
            this.btnScripts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(636, 200);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = resources.GetString("lblInstruction.Text");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(501, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(12, 478);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(157, 43);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "EU4 wiki";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnCommands
            // 
            this.btnCommands.Location = new System.Drawing.Point(175, 478);
            this.btnCommands.Name = "btnCommands";
            this.btnCommands.Size = new System.Drawing.Size(157, 43);
            this.btnCommands.TabIndex = 3;
            this.btnCommands.Text = "Commands";
            this.btnCommands.UseVisualStyleBackColor = true;
            this.btnCommands.Click += new System.EventHandler(this.btnCommands_Click);
            // 
            // btnScripts
            // 
            this.btnScripts.Location = new System.Drawing.Point(338, 478);
            this.btnScripts.Name = "btnScripts";
            this.btnScripts.Size = new System.Drawing.Size(157, 43);
            this.btnScripts.TabIndex = 4;
            this.btnScripts.Text = "Scripting";
            this.btnScripts.UseVisualStyleBackColor = true;
            this.btnScripts.Click += new System.EventHandler(this.btnScripts_Click);
            // 
            // frHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(672, 533);
            this.Controls.Add(this.btnScripts);
            this.Controls.Add(this.btnCommands);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInstruction);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help - province modding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnCommands;
        private System.Windows.Forms.Button btnScripts;
    }
}