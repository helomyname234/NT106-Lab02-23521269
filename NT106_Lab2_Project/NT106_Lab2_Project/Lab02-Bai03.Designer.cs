namespace NT106_Lab2_Project
{
    partial class Lab02_Bai03
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
            this.grInput3 = new System.Windows.Forms.GroupBox();
            this.txtInput3 = new System.Windows.Forms.RichTextBox();
            this.grOutput3 = new System.Windows.Forms.GroupBox();
            this.txtOuput3 = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grInput3.SuspendLayout();
            this.grOutput3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grInput3
            // 
            this.grInput3.Controls.Add(this.txtInput3);
            this.grInput3.Location = new System.Drawing.Point(26, 29);
            this.grInput3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grInput3.Name = "grInput3";
            this.grInput3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grInput3.Size = new System.Drawing.Size(447, 498);
            this.grInput3.TabIndex = 0;
            this.grInput3.TabStop = false;
            this.grInput3.Text = "Input";
            // 
            // txtInput3
            // 
            this.txtInput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput3.Location = new System.Drawing.Point(3, 22);
            this.txtInput3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(441, 472);
            this.txtInput3.TabIndex = 0;
            this.txtInput3.Text = "";
            // 
            // grOutput3
            // 
            this.grOutput3.Controls.Add(this.txtOuput3);
            this.grOutput3.Location = new System.Drawing.Point(569, 29);
            this.grOutput3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grOutput3.Name = "grOutput3";
            this.grOutput3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grOutput3.Size = new System.Drawing.Size(449, 498);
            this.grOutput3.TabIndex = 1;
            this.grOutput3.TabStop = false;
            this.grOutput3.Text = "Output";
            // 
            // txtOuput3
            // 
            this.txtOuput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOuput3.Location = new System.Drawing.Point(3, 22);
            this.txtOuput3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOuput3.Name = "txtOuput3";
            this.txtOuput3.ReadOnly = true;
            this.txtOuput3.Size = new System.Drawing.Size(443, 472);
            this.txtOuput3.TabIndex = 1;
            this.txtOuput3.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(29, 552);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(989, 48);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Tính toán & Lưu File";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Lab02_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 615);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grOutput3);
            this.Controls.Add(this.grInput3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lab02_Bai03";
            this.Text = "Lab02_Bai03";
            this.grInput3.ResumeLayout(false);
            this.grOutput3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grInput3;
        private System.Windows.Forms.RichTextBox txtInput3;
        private System.Windows.Forms.GroupBox grOutput3;
        private System.Windows.Forms.RichTextBox txtOuput3;
        private System.Windows.Forms.Button btnCalculate;
    }
}
