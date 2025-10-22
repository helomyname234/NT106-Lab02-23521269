namespace NT106_Lab2_Project
{
    partial class Lab02_Bai07
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trVCayThuMuc = new System.Windows.Forms.TreeView();
            this.trbNoiDung = new System.Windows.Forms.RichTextBox();
            this.picBoxHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trVCayThuMuc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trbNoiDung);
            this.splitContainer1.Panel2.Controls.Add(this.picBoxHinhAnh);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // trVCayThuMuc
            // 
            this.trVCayThuMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trVCayThuMuc.Location = new System.Drawing.Point(0, 0);
            this.trVCayThuMuc.Name = "trVCayThuMuc";
            this.trVCayThuMuc.Size = new System.Drawing.Size(266, 450);
            this.trVCayThuMuc.TabIndex = 0;
            this.trVCayThuMuc.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trVCayThuMuc_BeforeExpand);
            this.trVCayThuMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trVCayThuMuc_AfterSelect);
            // 
            // trbNoiDung
            // 
            this.trbNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbNoiDung.Location = new System.Drawing.Point(0, 0);
            this.trbNoiDung.Name = "trbNoiDung";
            this.trbNoiDung.Size = new System.Drawing.Size(530, 450);
            this.trbNoiDung.TabIndex = 1;
            this.trbNoiDung.Text = "";
            // 
            // picBoxHinhAnh
            // 
            this.picBoxHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxHinhAnh.Location = new System.Drawing.Point(0, 0);
            this.picBoxHinhAnh.Name = "picBoxHinhAnh";
            this.picBoxHinhAnh.Size = new System.Drawing.Size(530, 450);
            this.picBoxHinhAnh.TabIndex = 0;
            this.picBoxHinhAnh.TabStop = false;
            this.picBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // Lab02_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Lab02_Bai07";
            this.Text = "Lab02_Bai07";
            this.Load += new System.EventHandler(this.Lab02_Bai07_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trVCayThuMuc;
        private System.Windows.Forms.PictureBox picBoxHinhAnh;
        private System.Windows.Forms.RichTextBox trbNoiDung;
    }
}