using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai04 : Form
    {
        // Định nghĩa lớp SinhVien ngay bên trong Form
        public class SinhVien
        {
            public string HoVaTen { get; set; }
            public int MSSV { get; set; }
            public string SoDienThoai { get; set; }
            public float DMon1 { get; set; }
            public float DMon2 { get; set; }
            public float DMon3 { get; set; }
            public float DTB { get; set; }

            public void TinhDiemTrungBinh()
            {
                // Làm tròn đến 2 chữ số thập phân
                this.DTB = (float)Math.Round((DMon1 + DMon2 + DMon3) / 3.0, 2);
            }
        }

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private int currentIndex = -1;
        private readonly string inputFilePath;
        private readonly string outputFilePath;
        private readonly JsonSerializerOptions jsonOptions;

        public Lab02_Bai04()
        {
            InitializeComponent();

            string startupPath = Application.StartupPath;
            inputFilePath = Path.Combine(startupPath, "input4.txt");
            outputFilePath = Path.Combine(startupPath, "output4.txt");

            jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            LoadDataFromFile();
            UpdateDisplay();
        }

        private void LoadDataFromFile()
        {
            try
            {
                if (File.Exists(inputFilePath))
                {
                    string jsonContent = File.ReadAllText(inputFilePath);
                    if (!string.IsNullOrWhiteSpace(jsonContent))
                    {
                        danhSachSinhVien = JsonSerializer.Deserialize<List<SinhVien>>(jsonContent, jsonOptions);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ input4.txt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToInputFile()
        {
            try
            {
                string jsonContent = JsonSerializer.Serialize(danhSachSinhVien, jsonOptions);
                File.WriteAllText(inputFilePath, jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu vào input4.txt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // --- SỰ KIỆN CÁC NÚT ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            // === VALIDATION ===
            if (string.IsNullOrWhiteSpace(IntxtHoVaTen.Text))
            {
                MessageBox.Show("Họ và tên không được để trống.", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!int.TryParse(IntxtMSSV.Text, out int mssv) || IntxtMSSV.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải là số và có đúng 8 chữ số.", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (danhSachSinhVien.Any(sv => sv.MSSV == mssv))
            {
                MessageBox.Show("MSSV này đã tồn tại trong danh sách.", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string sdt = IntxtSoDienThoai.Text;
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là số, có 10 chữ số và bắt đầu bằng 0.", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!float.TryParse(IntxtDiemMon1.Text, out float d1) || !float.TryParse(IntxtDiemMon2.Text, out float d2) || !float.TryParse(IntxtDiemMon3.Text, out float d3))
            {
                MessageBox.Show("Điểm phải là một con số (có thể là số thực).", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            // === XỬ LÝ ===
            var newStudent = new SinhVien
            {
                HoVaTen = IntxtHoVaTen.Text,
                MSSV = mssv,
                SoDienThoai = sdt,
                DMon1 = d1,
                DMon2 = d2,
                DMon3 = d3
            };
            
            danhSachSinhVien.Add(newStudent);
            
            ClearInputFields();
            UpdateDisplay();
            MessageBox.Show("Thêm sinh viên vào danh sách tạm thời thành công!\nNhấn 'Ghi vào File' để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGhiVaoFile_Click(object sender, EventArgs e)
        {
            if (danhSachSinhVien.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào để ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveDataToInputFile();
            MessageBox.Show("Đã lưu danh sách sinh viên vào file input4.txt thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDocMotFile_Click(object sender, EventArgs e)
        {
            if (danhSachSinhVien.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Tính điểm trung bình cho tất cả
            danhSachSinhVien.ForEach(sv => sv.TinhDiemTrungBinh());
            
            // Cập nhật lại hiển thị
            UpdateDisplay();
            
            // Ghi kết quả ra file output
            try
            {
                string jsonContent = JsonSerializer.Serialize(danhSachSinhVien, jsonOptions);
                File.WriteAllText(outputFilePath, jsonContent);
                MessageBox.Show("Đã tính điểm trung bình và xuất kết quả ra file output4.txt thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file output4.txt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateStudentDetailView();
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if (currentIndex < danhSachSinhVien.Count - 1)
            {
                currentIndex++;
                UpdateStudentDetailView();
            }
        }

        // --- CÁC HÀM HỖ TRỢ ---

        private void UpdateDisplay()
        {
            txtMangSinhVien.Text = JsonSerializer.Serialize(danhSachSinhVien, jsonOptions);

            if (danhSachSinhVien.Any())
            {
                if (currentIndex == -1 || currentIndex >= danhSachSinhVien.Count)
                {
                    currentIndex = 0;
                }
                UpdateStudentDetailView();
            }
            else
            {
                ClearDetailView();
                currentIndex = -1;
            }
        }

        private void UpdateStudentDetailView()
        {
            if (currentIndex < 0 || currentIndex >= danhSachSinhVien.Count) return;

            SinhVien sv = danhSachSinhVien[currentIndex];
            OutxtHoVaTen.Text = sv.HoVaTen;
            OutxtMSSV.Text = sv.MSSV.ToString();
            OutxtSDT.Text = sv.SoDienThoai;
            OutxtMon1.Text = sv.DMon1.ToString();
            OutxtMon2.Text = sv.DMon2.ToString();
            OutxtMon3.Text = sv.DMon3.ToString();
            OutxtTb.Text = sv.DTB.ToString();
            
            OuLbSoTrang.Text = $"{currentIndex + 1}";

            btnQuayLai.Enabled = currentIndex > 0;
            btnTiepTheo.Enabled = currentIndex < danhSachSinhVien.Count - 1;
        }
        
        private void ClearInputFields()
        {
            IntxtHoVaTen.Clear();
            IntxtMSSV.Clear();
            IntxtSoDienThoai.Clear();
            IntxtDiemMon1.Clear();
            IntxtDiemMon2.Clear();
            IntxtDiemMon3.Clear();
        }

        private void ClearDetailView()
        {
            OutxtHoVaTen.Clear();
            OutxtMSSV.Clear();
            OutxtSDT.Clear();
            OutxtMon1.Clear();
            OutxtMon2.Clear();
            OutxtMon3.Clear();
            OutxtTb.Clear();
            OuLbSoTrang.Text = "0";
            btnQuayLai.Enabled = false;
            btnTiepTheo.Enabled = false;
        }
    }
}
