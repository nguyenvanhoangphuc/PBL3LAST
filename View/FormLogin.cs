using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;
using QuanLyPhongTroLinQ.BLL;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //gọi đến class MatKhau
            TaiKhoan obj = new TaiKhoan();
            obj.TenTK = txtTenDangNhap.Text;
            obj.MKhau = txtMatKhau.Text;

            string getuser = TaiKhoanBLL.Instance.CheckLogic(obj);
            switch (getuser)
            {
                case "requied_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống!");
                    return;
                case "requied_password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "null":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            //MessageBox.Show("Bạn đã đăng nhập thành công hệ thống!!!");
            //Check tư cách để vào form cho mình 
            if (TaiKhoanBLL.Instance.CheckTuCach(getuser) == "ChuTro")
            {
                FormMenuChuTro fCT = new FormMenuChuTro();
                fCT.dExit = new FormMenuChuTro.myDel(xuathien);
                fCT.Show();
                this.Hide();
            }
            else if (TaiKhoanBLL.Instance.CheckTuCach(getuser) == "NhanVien")
            {
                FormMenuNhanVien fCT = new FormMenuNhanVien(getuser);
                fCT.dExit = new FormMenuNhanVien.myDel(xuathien);
                fCT.Show();
                this.Hide();
            }
        }
        private void xuathien()
        {
            this.Show();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ 0337689694 để xác nhận thông tin và lấy lại mật khẩu.");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tài khoản phải được người quản lí thêm. Liên hệ 0337689694 để yêu cần thêm tài khoản.");
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnHienMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
            btnHienMatKhau.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.iconShow;
        }

        private void btnHienMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtMatKhau.Text != "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            btnHienMatKhau.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.eyeClose;
        }
    }
}
