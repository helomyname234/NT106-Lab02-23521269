using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai01: Form
    {
    	static string startupPath = Application.StartupPath;
        static string Ifilepath = Path.Combine(startupPath, "input1.txt");
        static string Ofilepath = Path.Combine(startupPath, "output1.txt");
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void rTBOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader reader = new StreamReader(Ifilepath))
                {
                    string content = reader.ReadToEnd();
                    rTBOutput.Text = content;	
                    MessageBox.Show($"Đã đọc thành công nội dung từ file {Ifilepath}");
                }
	
            } 
            catch(FileNotFoundException fnf)
            {
                MessageBox.Show("Không tìm thấy file để đọc!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi khác xảy ra " + ex.ToString());
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(rTBOutput.Text))
	    {
		MessageBox.Show("Không có nội dung để ghi vào file.", "Cảnh báo", 	     			MessageBoxButtons.OK, MessageBoxIcon.Warning);
		return; // Dừng lại không thực hiện tiếp
	    }
            try
            {
                string content = rTBOutput.Text;
                content = content.ToUpper();
                using (StreamWriter writer = new StreamWriter(Ofilepath))
                {
                    writer.Write(content);
                }
                MessageBox.Show($"Ghi file {Ofilepath} thành công !!");

            } 
            catch(FileNotFoundException) // Bạn có thể bỏ biến fnf nếu không dùng đến
		{
		    MessageBox.Show("Lỗi: Không tìm thấy file input1.txt.", "Lỗi", 			    MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		catch(Exception ex)
		{
		    MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", 			    MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
        }
    }
}
