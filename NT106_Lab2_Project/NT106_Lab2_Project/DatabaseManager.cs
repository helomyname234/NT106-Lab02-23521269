using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public class MonAnDayDu
    {
        public string TenMonAn { get; set; }
        public string HinhAnh { get; set; }
        public string TenNguoiDongGop { get; set; }
    }

    public class DatabaseManager
    {
        private readonly string connectionString;
        private readonly string fullPathToDb;

        public DatabaseManager()
        {
            // Đường dẫn trỏ thẳng đến file trong thư mục output (bin\Debug)
            this.fullPathToDb = Path.Combine(Application.StartupPath, "MonAn.db");
            this.connectionString = $"Data Source={fullPathToDb};Version=3;";
        }

        public void InitializeDatabase()
        {
            // Chỉ kiểm tra file, không cần kiểm tra thư mục
            if (!File.Exists(this.fullPathToDb))
            {
                SQLiteConnection.CreateFile(this.fullPathToDb); // Tạo file ở đúng vị trí

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    // ... (phần code tạo bảng và thêm dữ liệu mẫu giữ nguyên như cũ)
                    
                    string sqlNguoiDung = "CREATE TABLE NguoiDung (IDNCC INTEGER PRIMARY KEY AUTOINCREMENT, HoVaTen TEXT NOT NULL);";
                    new SQLiteCommand(sqlNguoiDung, connection).ExecuteNonQuery();

                    string sqlMonAn = @"
                    CREATE TABLE MonAn (
                        IDMA     INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT NOT NULL UNIQUE,
                        HinhAnh  TEXT,
                        IDNCC    INTEGER,
                        FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                    );";
                    new SQLiteCommand(sqlMonAn, connection).ExecuteNonQuery();
                    
                    // Thêm dữ liệu mẫu...
                    string insertNguoiDung = "INSERT INTO NguoiDung (HoVaTen) VALUES ('Bếp Trưởng UIT'), ('Sinh Viên Khéo Tay');";
                    new SQLiteCommand(insertNguoiDung, connection).ExecuteNonQuery();
                    
                    string insertMonAn = @"
                    INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES 
                        ('Cơm Tấm Sườn Bì Chả', 'images/com-tam.jpg', 1),
                        ('Phở Bò Tái Nạm', 'images/pho-bo.jpg', 1),
                        ('Bún Chả Cá Đà Nẵng', 'images/bun-cha-ca.jpg', 2);";
                    new SQLiteCommand(insertMonAn, connection).ExecuteNonQuery();
                }
            }
        }
        
        // ... (các hàm LayDanhSachMonAn, TimHoacTaoNguoiDung, ThemMonAn giữ nguyên)
        public List<MonAnDayDu> LayDanhSachMonAn()
        {
            var danhSach = new List<MonAnDayDu>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen
                FROM MonAn m
                INNER JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                var command = new SQLiteCommand(sql, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new MonAnDayDu
                        {
                            TenMonAn = reader["TenMonAn"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            TenNguoiDongGop = reader["HoVaTen"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }

        private int TimHoacTaoNguoiDung(string hoVaTen, SQLiteConnection connection)
        {
            string sqlTim = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @hoVaTen";
            var commandTim = new SQLiteCommand(sqlTim, connection);
            commandTim.Parameters.AddWithValue("@hoVaTen", hoVaTen);
            object result = commandTim.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                string sqlThem = "INSERT INTO NguoiDung (HoVaTen) VALUES (@hoVaTen)";
                var commandThem = new SQLiteCommand(sqlThem, connection);
                commandThem.Parameters.AddWithValue("@hoVaTen", hoVaTen);
                commandThem.ExecuteNonQuery();
                return (int)connection.LastInsertRowId;
            }
        }

        public void ThemMonAn(string tenMonAn, string hinhAnh, string tenNguoiDongGop)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                int idNcc = TimHoacTaoNguoiDung(tenNguoiDongGop, connection);
                string sql = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@tenMonAn, @hinhAnh, @idNcc)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tenMonAn", tenMonAn);
                    command.Parameters.AddWithValue("@hinhAnh", hinhAnh);
                    command.Parameters.AddWithValue("@idNcc", idNcc);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
