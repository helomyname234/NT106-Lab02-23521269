namespace NT106_Lab2_Project
{
    partial class Lab02_Bai02
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.laTenFile = new System.Windows.Forms.Label();
            this.laKichThuoc = new System.Windows.Forms.Label();
            this.laURL = new System.Windows.Forms.Label();
            this.laSoDong = new System.Windows.Forms.Label();
            this.laSoTu = new System.Windows.Forms.Label();
            this.laSoChu = new System.Windows.Forms.Label();
            this.outTenFile = new System.Windows.Forms.TextBox();
            this.outKichThuoc = new System.Windows.Forms.TextBox();
            this.outURL = new System.Windows.Forms.TextBox();
            this.outSoDong = new System.Windows.Forms.TextBox();
            this.outSoTu = new System.Windows.Forms.TextBox();
            this.outSoChu = new System.Windows.Forms.TextBox();
            this.outNoiDungFile = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDocFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDocFile.Location = new System.Drawing.Point(57, 51);
            this.btnDocFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(360, 43);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "ĐỌC FILE";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // laTenFile
            // 
            this.laTenFile.AutoSize = true;
            this.laTenFile.Location = new System.Drawing.Point(53, 130);
            this.laTenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laTenFile.Name = "laTenFile";
            this.laTenFile.Size = new System.Drawing.Size(66, 23);
            this.laTenFile.TabIndex = 1;
            this.laTenFile.Text = "Tên File";
            // 
            // laKichThuoc
            // 
            this.laKichThuoc.AutoSize = true;
            this.laKichThuoc.Location = new System.Drawing.Point(53, 219);
            this.laKichThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laKichThuoc.Name = "laKichThuoc";
            this.laKichThuoc.Size = new System.Drawing.Size(94, 23);
            this.laKichThuoc.TabIndex = 2;
            this.laKichThuoc.Text = "Kích Thước";
            // 
            // laURL
            // 
            this.laURL.AutoSize = true;
            this.laURL.Location = new System.Drawing.Point(53, 308);
            this.laURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laURL.Name = "laURL";
            this.laURL.Size = new System.Drawing.Size(36, 23);
            this.laURL.TabIndex = 3;
            this.laURL.Text = "URl";
            // 
            // laSoDong
            // 
            this.laSoDong.AutoSize = true;
            this.laSoDong.Location = new System.Drawing.Point(53, 397);
            this.laSoDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSoDong.Name = "laSoDong";
            this.laSoDong.Size = new System.Drawing.Size(76, 23);
            this.laSoDong.TabIndex = 4;
            this.laSoDong.Text = "Số Dòng";
            // 
            // laSoTu
            // 
            this.laSoTu.AutoSize = true;
            this.laSoTu.Location = new System.Drawing.Point(53, 486);
            this.laSoTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSoTu.Name = "laSoTu";
            this.laSoTu.Size = new System.Drawing.Size(53, 23);
            this.laSoTu.TabIndex = 5;
            this.laSoTu.Text = "Số Từ";
            // 
            // laSoChu
            // 
            this.laSoChu.AutoSize = true;
            this.laSoChu.Location = new System.Drawing.Point(53, 575);
            this.laSoChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laSoChu.Name = "laSoChu";
            this.laSoChu.Size = new System.Drawing.Size(62, 23);
            this.laSoChu.TabIndex = 6;
            this.laSoChu.Text = "Số chữ";
            // 
            // outTenFile
            // 
            this.outTenFile.Location = new System.Drawing.Point(153, 130);
            this.outTenFile.Margin = new System.Windows.Forms.Padding(4);
            this.outTenFile.Name = "outTenFile";
            this.outTenFile.ReadOnly = true;
            this.outTenFile.Size = new System.Drawing.Size(264, 30);
            this.outTenFile.TabIndex = 7;
            this.outTenFile.TextChanged += new System.EventHandler(this.outTenFile_TextChanged);
            // 
            // outKichThuoc
            // 
            this.outKichThuoc.Location = new System.Drawing.Point(153, 218);
            this.outKichThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.outKichThuoc.Name = "outKichThuoc";
            this.outKichThuoc.ReadOnly = true;
            this.outKichThuoc.Size = new System.Drawing.Size(264, 30);
            this.outKichThuoc.TabIndex = 8;
            this.outKichThuoc.TextChanged += new System.EventHandler(this.outKichThuoc_TextChanged);
            // 
            // outURL
            // 
            this.outURL.Location = new System.Drawing.Point(153, 306);
            this.outURL.Margin = new System.Windows.Forms.Padding(4);
            this.outURL.Name = "outURL";
            this.outURL.ReadOnly = true;
            this.outURL.Size = new System.Drawing.Size(264, 30);
            this.outURL.TabIndex = 9;
            // 
            // outSoDong
            // 
            this.outSoDong.Location = new System.Drawing.Point(153, 394);
            this.outSoDong.Margin = new System.Windows.Forms.Padding(4);
            this.outSoDong.Name = "outSoDong";
            this.outSoDong.ReadOnly = true;
            this.outSoDong.Size = new System.Drawing.Size(264, 30);
            this.outSoDong.TabIndex = 10;
            // 
            // outSoTu
            // 
            this.outSoTu.Location = new System.Drawing.Point(153, 482);
            this.outSoTu.Margin = new System.Windows.Forms.Padding(4);
            this.outSoTu.Name = "outSoTu";
            this.outSoTu.ReadOnly = true;
            this.outSoTu.Size = new System.Drawing.Size(264, 30);
            this.outSoTu.TabIndex = 11;
            // 
            // outSoChu
            // 
            this.outSoChu.Location = new System.Drawing.Point(153, 570);
            this.outSoChu.Margin = new System.Windows.Forms.Padding(4);
            this.outSoChu.Name = "outSoChu";
            this.outSoChu.ReadOnly = true;
            this.outSoChu.Size = new System.Drawing.Size(264, 30);
            this.outSoChu.TabIndex = 12;
            // 
            // outNoiDungFile
            // 
            this.outNoiDungFile.Location = new System.Drawing.Point(474, 51);
            this.outNoiDungFile.Margin = new System.Windows.Forms.Padding(4);
            this.outNoiDungFile.Name = "outNoiDungFile";
            this.outNoiDungFile.Size = new System.Drawing.Size(653, 557);
            this.outNoiDungFile.TabIndex = 13;
            this.outNoiDungFile.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(57, 637);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(360, 43);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "EXIT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 709);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.outNoiDungFile);
            this.Controls.Add(this.outSoChu);
            this.Controls.Add(this.outSoTu);
            this.Controls.Add(this.outSoDong);
            this.Controls.Add(this.outURL);
            this.Controls.Add(this.outKichThuoc);
            this.Controls.Add(this.outTenFile);
            this.Controls.Add(this.laSoChu);
            this.Controls.Add(this.laSoTu);
            this.Controls.Add(this.laSoDong);
            this.Controls.Add(this.laURL);
            this.Controls.Add(this.laKichThuoc);
            this.Controls.Add(this.laTenFile);
            this.Controls.Add(this.btnDocFile);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.Load += new System.EventHandler(this.Lab02_Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Label laTenFile;
        private System.Windows.Forms.Label laKichThuoc;
        private System.Windows.Forms.Label laURL;
        private System.Windows.Forms.Label laSoDong;
        private System.Windows.Forms.Label laSoTu;
        private System.Windows.Forms.Label laSoChu;
        private System.Windows.Forms.TextBox outTenFile;
        private System.Windows.Forms.TextBox outKichThuoc;
        private System.Windows.Forms.TextBox outURL;
        private System.Windows.Forms.TextBox outSoDong;
        private System.Windows.Forms.TextBox outSoTu;
        private System.Windows.Forms.TextBox outSoChu;
        private System.Windows.Forms.RichTextBox outNoiDungFile;
        private System.Windows.Forms.Button btnThoat;
    }
}