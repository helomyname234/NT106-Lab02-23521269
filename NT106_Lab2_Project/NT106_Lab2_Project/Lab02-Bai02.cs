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

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai02: Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void outTenFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void outKichThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab02_Bai02_Load(object sender, EventArgs e)
        {

        }

       private void btnDocFile_Click(object sender, EventArgs e)
	{
	    try
	    {
		using (OpenFileDialog ofd = new OpenFileDialog())
		{
		    ofd.Filter = "Text files (*.txt)|*.txt";
		    ofd.Title = "Vui lòng chọn một file văn bản";

		    if (ofd.ShowDialog() == DialogResult.OK)
		    {
		        string filepath = ofd.FileName;
		        FileInfo fileInfo = new FileInfo(filepath);

		        const long MAX_FILE_SIZE = 5 * 1024 * 1024; // 5 MB
		        if (fileInfo.Length > MAX_FILE_SIZE)
		        {
		            MessageBox.Show("File quá lớn (hơn 5MB). Vui lòng chọn file nhỏ hơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		            return;
		        }

		        outTenFile.Text = fileInfo.Name;
		        outURL.Text = fileInfo.FullName;
		        outKichThuoc.Text = fileInfo.Length.ToString() + " bytes";

		        string content = File.ReadAllText(filepath);
		        outNoiDungFile.Text = content;

		        outSoDong.Text = content.Split('\n').Length.ToString();

		        string[] words = content.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		        outSoTu.Text = words.Length.ToString();
		        
		        outSoChu.Text = content.Length.ToString();
		    }
		}
	    }
	    catch (Exception ex)
	    {
		MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
	    }
	}
    }
}
