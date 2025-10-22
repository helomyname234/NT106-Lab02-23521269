namespace NT106_Lab2_Project
{
    partial class Lab02_Bai05
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LuaChonPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LuaChonPhim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LuaChonGhe = new System.Windows.Forms.CheckedListBox();
            this.ThanhToan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutKetQua = new System.Windows.Forms.TextBox();
            this.XuatBaoCao = new System.Windows.Forms.Button();
            this.ThanhTrangThai = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuaChonPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LuaChonPhim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.InHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(394, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // LuaChonPhong
            // 
            this.LuaChonPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LuaChonPhong.FormattingEnabled = true;
            this.LuaChonPhong.Location = new System.Drawing.Point(135, 158);
            this.LuaChonPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LuaChonPhong.Name = "LuaChonPhong";
            this.LuaChonPhong.Size = new System.Drawing.Size(236, 31);
            this.LuaChonPhong.TabIndex = 5;
            this.LuaChonPhong.SelectedIndexChanged += new System.EventHandler(this.LuaChonPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn phòng:";
            // 
            // LuaChonPhim
            // 
            this.LuaChonPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LuaChonPhim.FormattingEnabled = true;
            this.LuaChonPhim.Location = new System.Drawing.Point(135, 101);
            this.LuaChonPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LuaChonPhim.Name = "LuaChonPhim";
            this.LuaChonPhim.Size = new System.Drawing.Size(236, 31);
            this.LuaChonPhim.TabIndex = 3;
            this.LuaChonPhim.SelectedIndexChanged += new System.EventHandler(this.LuaChonPhim_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn phim:";
            // 
            // InHoTen
            // 
            this.InHoTen.Location = new System.Drawing.Point(135, 43);
            this.InHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InHoTen.Name = "InHoTen";
            this.InHoTen.Size = new System.Drawing.Size(236, 30);
            this.InHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LuaChonGhe);
            this.groupBox2.Location = new System.Drawing.Point(428, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(459, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn ghế";
            // 
            // LuaChonGhe
            // 
            this.LuaChonGhe.FormattingEnabled = true;
            this.LuaChonGhe.Location = new System.Drawing.Point(17, 43);
            this.LuaChonGhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LuaChonGhe.Name = "LuaChonGhe";
            this.LuaChonGhe.Size = new System.Drawing.Size(427, 254);
            this.LuaChonGhe.TabIndex = 0;
            // 
            // ThanhToan
            // 
            this.ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhToan.Location = new System.Drawing.Point(14, 255);
            this.ThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Size = new System.Drawing.Size(394, 41);
            this.ThanhToan.TabIndex = 2;
            this.ThanhToan.Text = "Thanh Toán";
            this.ThanhToan.UseVisualStyleBackColor = true;
            this.ThanhToan.Click += new System.EventHandler(this.ThanhToan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutKetQua);
            this.groupBox3.Location = new System.Drawing.Point(14, 427);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(873, 256);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin vé";
            // 
            // OutKetQua
            // 
            this.OutKetQua.Location = new System.Drawing.Point(20, 43);
            this.OutKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutKetQua.Multiline = true;
            this.OutKetQua.Name = "OutKetQua";
            this.OutKetQua.ReadOnly = true;
            this.OutKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutKetQua.Size = new System.Drawing.Size(832, 185);
            this.OutKetQua.TabIndex = 0;
            // 
            // XuatBaoCao
            // 
            this.XuatBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBaoCao.Location = new System.Drawing.Point(14, 307);
            this.XuatBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XuatBaoCao.Name = "XuatBaoCao";
            this.XuatBaoCao.Size = new System.Drawing.Size(394, 41);
            this.XuatBaoCao.TabIndex = 4;
            this.XuatBaoCao.Text = "Xuất Báo Cáo";
            this.XuatBaoCao.UseVisualStyleBackColor = true;
            this.XuatBaoCao.Click += new System.EventHandler(this.XuatBaoCao_Click);
            // 
            // progressBar2
            // 
            this.ThanhTrangThai.Location = new System.Drawing.Point(14, 371);
            this.ThanhTrangThai.Name = "progressBar2";
            this.ThanhTrangThai.Size = new System.Drawing.Size(873, 23);
            this.ThanhTrangThai.TabIndex = 1;
            // 
            // Lab02_Bai05
            // 
            this.AcceptButton = this.ThanhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 696);
            this.Controls.Add(this.ThanhTrangThai);
            this.Controls.Add(this.XuatBaoCao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ThanhToan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Lab02_Bai05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình Quản lý vé xem phim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox LuaChonPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LuaChonPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox LuaChonGhe;
        private System.Windows.Forms.Button ThanhToan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox OutKetQua;
        private System.Windows.Forms.Button XuatBaoCao;
        private System.Windows.Forms.ProgressBar ThanhTrangThai;
    }
}