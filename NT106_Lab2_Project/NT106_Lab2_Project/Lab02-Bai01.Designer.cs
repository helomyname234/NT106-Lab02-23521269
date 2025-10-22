namespace NT106_Lab2_Project
{
    partial class Lab02_Bai01
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
            this.rTBOutput = new System.Windows.Forms.RichTextBox();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTBOutput
            // 
            this.rTBOutput.Location = new System.Drawing.Point(301, 62);
            this.rTBOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTBOutput.Name = "rTBOutput";
            this.rTBOutput.Size = new System.Drawing.Size(562, 235);
            this.rTBOutput.TabIndex = 0;
            this.rTBOutput.Text = "";
            this.rTBOutput.TextChanged += new System.EventHandler(this.rTBOutput_TextChanged);
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDocFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDocFile.Location = new System.Drawing.Point(45, 62);
            this.btnDocFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(235, 92);
            this.btnDocFile.TabIndex = 1;
            this.btnDocFile.Text = "ĐỌC FILE";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGhiFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGhiFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFile.ForeColor = System.Drawing.SystemColors.HighlightText;

            this.btnGhiFile.Location = new System.Drawing.Point(45, 205);
            this.btnGhiFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(235, 92);
            this.btnGhiFile.TabIndex = 2;
            this.btnGhiFile.Text = "GHI FILE";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // Lab02_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 370);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.rTBOutput);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lab02_Bai01";
            this.Text = "Lab02_Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBOutput;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnGhiFile;
    }
}