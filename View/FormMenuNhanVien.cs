using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormMenuNhanVien : Form
    {
        public string idNhanVien { get; set; }
        public delegate void myDel();
        public myDel dExit;
        public FormMenuNhanVien(string idNV)
        {
            InitializeComponent();
            idNhanVien = idNV;
        }


        private void btnDSThietBi_Click(object sender, EventArgs e)
        {

            panel4.Hide();
            FormQLTB f = new FormQLTB();
            f.MdiParent = this;
            f.Show();
        }

      

   
        private void btnThoat_Click(object sender, EventArgs e)
        {
            dExit();
            this.Close();
        }

        private void btnLichSuSuaChua_Click(object sender, EventArgs e)
        {

            panel4.Hide();

            FormLichSuSuaChua f = new FormLichSuSuaChua(idNhanVien);
            f.MdiParent = this;
            f.Show();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {

            panel4.Hide();

            FormPhong_NV f = new FormPhong_NV();
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            panel4.Hide();

            FormThongKe f = new FormThongKe();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

            panel4.Show();
            panel4.Controls.Clear();
            panel4.Controls.Add(new uclSuaTK(idNhanVien));
        }


    }
}
