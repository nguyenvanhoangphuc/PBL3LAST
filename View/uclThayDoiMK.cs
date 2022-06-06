using QuanLyPhongTroLinQ.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class uclThayDoiMK : UserControl
    {
        public delegate void MyDel();
        public MyDel d;
        string ID;
        public uclThayDoiMK(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblThongBao.Text=TaiKhoanBLL.Instance.DoiMatKhau(ID, txtMatKhauHienTai.Text, txtMKMoi.Text, txtNhapLaiMK.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            d();
        }

        private void txtMatKhauHienTai_Enter(object sender, EventArgs e)
        {
            txtMatKhauHienTai.UseSystemPasswordChar = true;
            txtMatKhauHienTai.ForeColor = Color.Black;
        }

        private void txtMKMoi_Enter(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = true;
            txtMKMoi.ForeColor = Color.Black;
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = true;
            txtNhapLaiMK.ForeColor = Color.Black;
        }
    }
}
