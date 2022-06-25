using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormMenuChuTro : Form
    {
        public delegate void myDel();
        public myDel dExit;
        string IDChuTro;
        public FormMenuChuTro(string ID)
        {
            IDChuTro = ID;
            InitializeComponent();
        }

        private void btnDSPhong_Click(object sender, EventArgs e)
        {

            panel4.Hide();
            FormDSPhong fdsP = new FormDSPhong();
            fdsP.MdiParent = this;
            fdsP.Show();
        }
        //====================================
        private void btnDSNguoiThue_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormNguoiThue f = new FormNguoiThue();
            f.MdiParent = this;
            f.Show();
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            dExit();
            this.Close();
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormLoaiPhong f = new FormLoaiPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTraTien_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormTraTien f = new FormTraTien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormDatTraPhong f = new FormDatTraPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormThongKeAD f = new FormThongKeAD();
            f.MdiParent = this;
            f.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            FormQLNhanVien f = new FormQLNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Show();
            panel4.Controls.Add(new uclSuaTK(IDChuTro));
        }


    }
}