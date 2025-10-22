using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
        }

        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {
            LoadDriveNodes();
        }

        private void LoadDriveNodes()
        {
            this.Cursor = Cursors.WaitCursor;
            trVCayThuMuc.Nodes.Clear();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    var driveNode = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    driveNode.Nodes.Add("dummy");
                    trVCayThuMuc.Nodes.Add(driveNode);
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void trVCayThuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "dummy")
            {
                this.Cursor = Cursors.WaitCursor;
                e.Node.Nodes.Clear();
                PopulateNode(e.Node);
                this.Cursor = Cursors.Default;
            }
        }

        private void PopulateNode(TreeNode parentNode)
        {
            string path = parentNode.Tag.ToString();
            try
            {
                // Tải thư mục con
                foreach (string dir in Directory.GetDirectories(path))
                {
                    var dirInfo = new DirectoryInfo(dir);
                    var dirNode = new TreeNode(dirInfo.Name) { Tag = dir };
                    dirNode.Nodes.Add("dummy");
                    parentNode.Nodes.Add(dirNode);
                }

                // Tải file
                foreach (string file in Directory.GetFiles(path))
                {
                    var fileInfo = new FileInfo(file);
                    var fileNode = new TreeNode(fileInfo.Name) { Tag = file };
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException) { /* Bỏ qua thư mục không có quyền truy cập */ }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nội dung thư mục: " + ex.Message);
            }
        }

        private void trVCayThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag?.ToString();
            
            // Chỉ hiển thị nội dung nếu đó là một file
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                DisplayFileContent(path);
            }
            else
            {
                // Nếu là thư mục, ẩn cả hai control
                picBoxHinhAnh.Visible = false;
                trbNoiDung.Visible = false;
            }
        }

        private void DisplayFileContent(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string[] textExtensions = { ".txt", ".cs", ".xml", ".config", ".log", ".html", ".css", ".js" };
            string extension = Path.GetExtension(filePath).ToLower();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (Array.Exists(imageExtensions, ext => ext == extension))
                {
                    picBoxHinhAnh.Visible = true;
                    trbNoiDung.Visible = false;

                    picBoxHinhAnh.Image?.Dispose(); // Giải phóng ảnh cũ
                    using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                    {
                        picBoxHinhAnh.Image = Image.FromStream(stream);
                    }
                }
                else if (Array.Exists(textExtensions, ext => ext == extension))
                {
                    picBoxHinhAnh.Visible = false;
                    trbNoiDung.Visible = true;

                    var fileInfo = new FileInfo(filePath);
                    const long MAX_FILE_SIZE = 5 * 1024 * 1024; // 5 MB

                    if (fileInfo.Length > MAX_FILE_SIZE)
                    {
                        trbNoiDung.Text = $"--- FILE QUÁ LỚN ({fileInfo.Length / 1024.0 / 1024.0:F2} MB) ---\n--- Không thể hiển thị nội dung ---";
                    }
                    else
                    {
                        trbNoiDung.Text = File.ReadAllText(filePath);
                    }
                }
                else
                {
                    picBoxHinhAnh.Visible = false;
                    trbNoiDung.Visible = true;
                    trbNoiDung.Text = $"Không hỗ trợ xem trước nội dung cho loại file này: {Path.GetFileName(filePath)}";
                }
            }
            catch (Exception ex)
            {
                trbNoiDung.Visible = true;
                trbNoiDung.Text = "Lỗi khi đọc file: " + ex.Message;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
