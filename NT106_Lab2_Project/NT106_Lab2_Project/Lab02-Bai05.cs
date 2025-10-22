using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai05 : Form
    {
        // --- NESTED CLASSES ---
        public class Phim
        {
            public string TenPhim { get; set; }
            public double GiaVeChuan { get; set; }
            public List<int> PhongChieu { get; set; }
            public int SoLuongVeBanRa { get; set; }
            public double DoanhThu { get; set; }

            public int TongSoGheCuaPhim => this.PhongChieu.Count * 15;
            public int SoLuongVeTon => this.TongSoGheCuaPhim - this.SoLuongVeBanRa;
            public double TiLeVeBanRa => TongSoGheCuaPhim == 0 ? 0 : (double)SoLuongVeBanRa / TongSoGheCuaPhim;

            public override string ToString() => this.TenPhim;
        }

        public class GheNgoi
        {
            public string SoGhe { get; set; }
            public bool DaDat { get; set; }
            // Các thông tin khác có thể được tính toán thay vì lưu trữ
            public string LoaiVe
            {
                get
                {
                    if (SoGhe.StartsWith("A") || SoGhe.StartsWith("C"))
                    {
                        if (SoGhe.EndsWith("1") || SoGhe.EndsWith("5")) return "Vé vớt";
                        return "Thường";
                    }
                    return "VIP";
                }
            }
            public double HeSoGia
            {
                get
                {
                    switch (LoaiVe)
                    {
                        case "Vé vớt": return 0.25;
                        case "VIP": return 2.0;
                        default: return 1.0;
                    }
                }
            }
        }

        // --- DATA & CONFIG ---
        private readonly Dictionary<string, Phim> danhSachPhim = new Dictionary<string, Phim>();
        private readonly Dictionary<int, List<GheNgoi>> trangThaiGheTheoPhong = new Dictionary<int, List<GheNgoi>>();
        private readonly string inputFilePath;
        private readonly string outputFilePath;

        public Lab02_Bai05()
        {
            InitializeComponent();
            string startupPath = Application.StartupPath;
            inputFilePath = Path.Combine(startupPath, "input5.txt");
            outputFilePath = Path.Combine(startupPath, "output5.txt");
            LoadDataFromInputFile();
        }

        // --- CÁC HÀM XỬ LÝ DỮ LIỆU ---

        private void LoadDataFromInputFile()
        {
            try
            {
                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show($"Không tìm thấy file '{Path.GetFileName(inputFilePath)}'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(inputFilePath);
                for (int i = 0; i < lines.Length; i += 3)
                {
                    string tenPhim = lines[i].Trim();
                    if (!double.TryParse(lines[i + 1], out double giaVe)) continue; // Bỏ qua nếu giá vé sai

                    List<int> phongChieu = lines[i + 2].Split(',')
                                                       .Select(s => int.TryParse(s.Trim(), out int room) ? room : -1)
                                                       .Where(r => r != -1)
                                                       .ToList();

                    danhSachPhim[tenPhim] = new Phim { TenPhim = tenPhim, GiaVeChuan = giaVe, PhongChieu = phongChieu };
                }

                LuaChonPhim.Items.Clear();
                LuaChonPhim.Items.AddRange(danhSachPhim.Values.ToArray());

                // Tự động tạo danh sách ghế cho các phòng được định nghĩa trong file
                var allRooms = danhSachPhim.Values.SelectMany(p => p.PhongChieu).Distinct();
                foreach (var roomNumber in allRooms)
                {
                    if (!trangThaiGheTheoPhong.ContainsKey(roomNumber))
                    {
                        trangThaiGheTheoPhong[roomNumber] = CreateSeatList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi đọc file input: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<GheNgoi> CreateSeatList()
        {
            var seatList = new List<GheNgoi>();
            string[] rows = { "A", "B", "C" };
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    seatList.Add(new GheNgoi { SoGhe = rows[i] + j, DaDat = false });
                }
            }
            return seatList;
        }

        // --- CÁC HÀM SỰ KIỆN ---

        private void LuaChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LuaChonPhim.SelectedItem is Phim selectedMovie)
            {
                LuaChonPhong.Items.Clear();
                LuaChonPhong.Items.AddRange(selectedMovie.PhongChieu.Cast<object>().ToArray());
                LuaChonPhong.Text = "";
                LuaChonGhe.Items.Clear();
            }
        }

        private void LuaChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LuaChonPhong.SelectedItem == null || !(LuaChonPhim.SelectedItem is Phim selectedMovie)) return;

            int selectedRoom = (int)LuaChonPhong.SelectedItem;
            var roomSeats = trangThaiGheTheoPhong[selectedRoom];

            LuaChonGhe.Items.Clear();
            foreach (var seat in roomSeats)
            {
                double price = seat.HeSoGia * selectedMovie.GiaVeChuan;
                string status = seat.DaDat ? "[ĐÃ ĐẶT]" : $"(Giá: {price:N0}đ)";
                LuaChonGhe.Items.Add($"{seat.SoGhe} - {seat.LoaiVe} {status}", seat.DaDat);
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!(LuaChonPhim.SelectedItem is Phim selectedMovie) || LuaChonPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (LuaChonGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            int selectedRoom = (int)LuaChonPhong.SelectedItem;
            var roomSeats = trangThaiGheTheoPhong[selectedRoom];
            double totalCost = 0;
            var selectedSeatNumbers = new List<string>();

            foreach (int index in LuaChonGhe.CheckedIndices)
            {
                if (roomSeats[index].DaDat)
                {
                    MessageBox.Show($"Ghế {roomSeats[index].SoGhe} đã được đặt trước đó. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thanh toán
                }
                totalCost += roomSeats[index].HeSoGia * selectedMovie.GiaVeChuan;
                selectedSeatNumbers.Add(roomSeats[index].SoGhe);
            }

            // Cập nhật thống kê cho phim
            selectedMovie.SoLuongVeBanRa += selectedSeatNumbers.Count;
            selectedMovie.DoanhThu += totalCost;

            // Đánh dấu ghế đã đặt
            foreach (int index in LuaChonGhe.CheckedIndices)
            {
                roomSeats[index].DaDat = true;
            }

            // Hiển thị vé
            var receipt = new StringBuilder();
            receipt.AppendLine("--- VÉ XEM PHIM ---");
            receipt.AppendLine($"Họ và tên: {InHoTen.Text.Trim()}");
            receipt.AppendLine($"Tên phim: {selectedMovie.TenPhim}");
            receipt.AppendLine($"Phòng chiếu: {selectedRoom}");
            receipt.AppendLine($"Ghế đã chọn: {string.Join(", ", selectedSeatNumbers)}");
            receipt.AppendLine("--------------------");
            receipt.AppendLine($"TỔNG TIỀN: {totalCost:N0} VNĐ");
            OutKetQua.Text = receipt.ToString();

            // Làm mới giao diện
            InHoTen.Clear();
            LuaChonPhong_SelectedIndexChanged(sender, e); // Tải lại danh sách ghế
        }

        private void XuatBaoCao_Click(object sender, EventArgs e)
        {
            var sortedMovies = danhSachPhim.Values.OrderByDescending(p => p.DoanhThu).ToList();
            var report = new StringBuilder();

            ThanhTrangThai.Value = 0;
            ThanhTrangThai.Maximum = sortedMovies.Count;

            for (int i = 0; i < sortedMovies.Count; i++)
            {
                var movie = sortedMovies[i];
                report.AppendLine($"--- PHIM: {movie.TenPhim} ---");
                report.AppendLine($"Số lượng vé bán ra: {movie.SoLuongVeBanRa}");
                report.AppendLine($"Số lượng vé tồn: {movie.SoLuongVeTon}");
                report.AppendLine($"Tỉ lệ vé bán ra: {movie.TiLeVeBanRa:P2}");
                report.AppendLine($"Doanh thu: {movie.DoanhThu:N0} VNĐ");
                report.AppendLine($"Xếp hạng doanh thu: {i + 1}");
                report.AppendLine("----------------------------------------");

                ThanhTrangThai.PerformStep();
                Application.DoEvents(); // Cho phép UI cập nhật
            }

            try
            {
                File.WriteAllText(outputFilePath, report.ToString());
                MessageBox.Show($"Xuất báo cáo thành công vào file '{Path.GetFileName(outputFilePath)}'!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file output: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ThanhTrangThai.Value = 0;
            }
        }
    }
}
