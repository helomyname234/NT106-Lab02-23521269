using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai06 : Form
    {
        private readonly DatabaseManager dbManager;
        private List<MonAnDayDu> danhSachMonAn;
        private readonly Random randomGenerator = new Random();

        public Lab02_Bai06()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            try
            {
                dbManager.InitializeDatabase();
                danhSachMonAn = dbManager.LayDanhSachMonAn();
                UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo cơ sở dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListView()
        {
            lsVCacMonAn.Items.Clear();
            if (danhSachMonAn == null) return;

            foreach (var monAn in danhSachMonAn)
            {
                var item = new ListViewItem(monAn.TenMonAn);
                item.SubItems.Add(monAn.TenNguoiDongGop);
                lsVCacMonAn.Items.Add(item);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = IntxtTenMonAn.Text.Trim();
            string hinhAnh = IntxtFileAnh.Text.Trim();
            string nguoiDongGop = IntxtTenNguoiDongGop.Text.Trim();

            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(nguoiDongGop))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn và tên người đóng góp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbManager.ThemMonAn(tenMon, hinhAnh, nguoiDongGop);
                MessageBox.Show("Thêm món ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật danh sách trong bộ nhớ để cải thiện hiệu năng
                danhSachMonAn.Add(new MonAnDayDu { TenMonAn = tenMon, HinhAnh = hinhAnh, TenNguoiDongGop = nguoiDongGop });
                UpdateListView(); 

                IntxtTenMonAn.Clear();
                IntxtFileAnh.Clear();
                IntxtTenNguoiDongGop.Clear();
            }
            catch (SQLiteException sqlEx) when (sqlEx.ResultCode == SQLiteErrorCode.Constraint)
            {
                MessageBox.Show($"Lỗi: Món ăn '{tenMon}' đã tồn tại.", "Lỗi Trùng Lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Chọn hình ảnh món ăn";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = ofd.FileName;
                        string fileName = Path.GetFileName(sourcePath);
                        string imageDirectory = Path.Combine(Application.StartupPath, "images");
                        Directory.CreateDirectory(imageDirectory); // Đảm bảo thư mục tồn tại
                        string destinationPath = Path.Combine(imageDirectory, fileName);
                        
                        File.Copy(sourcePath, destinationPath, true);
                        
                        IntxtFileAnh.Text = Path.Combine("images", fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sao chép ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn == null || !danhSachMonAn.Any())
            {
                MessageBox.Show("Chưa có món ăn nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int randomIndex = randomGenerator.Next(danhSachMonAn.Count);
            var selectedDish = danhSachMonAn[randomIndex];

            OutxtTenMonAn.Text = selectedDish.TenMonAn;
            OutxtTenNguoiDongGop.Text = selectedDish.TenNguoiDongGop;
            
            picAnhMonAn.Image = null; // Xóa ảnh cũ trước khi tải ảnh mới
            string relativePath = selectedDish.HinhAnh;
            if (!string.IsNullOrEmpty(relativePath))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, relativePath);
                    if (File.Exists(fullPath))
                    {
                        using (var stream = new MemoryStream(File.ReadAllBytes(fullPath)))
                        {
                            picAnhMonAn.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
