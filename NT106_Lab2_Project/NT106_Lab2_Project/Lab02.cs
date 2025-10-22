using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02: Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 fr = new Lab02_Bai01();
            fr.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 fr = new Lab02_Bai02();
            fr.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 fr = new Lab02_Bai03();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 fr = new Lab02_Bai04();
            fr.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 fr = new Lab02_Bai05();
            fr.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 fr = new Lab02_Bai06();
            fr.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 fr = new Lab02_Bai07();
            fr.Show();
        }
    }
}
