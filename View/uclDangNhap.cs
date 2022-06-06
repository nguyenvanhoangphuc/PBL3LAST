using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class uclDangNhap : UserControl
    {
        public uclDangNhap()
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
            if(getuser == "requied_taikhoan")
                    lblThongBao.Text="Tài khoản không được để trống!";
            else if(getuser == "requied_password") 
                    lblThongBao.Text=("Mật khẩu không được để trống!");
            else if (getuser == "null")
                lblThongBao.Text=("Tài khoản hoặc mật khẩu không chính xác!");
            else
            {
                if (TaiKhoanBLL.Instance.CheckTrangThai(getuser))
                {
                    //Check tư cách để vào form cho mình 
                    if (TaiKhoanBLL.Instance.CheckTuCach(getuser) == "ChuTro")
                    {

                        FormMenuChuTro fCT = new FormMenuChuTro(getuser); //thêm id để sửa tài khoản
                        fCT.dExit = new FormMenuChuTro.myDel(xuathien);
                        fCT.Show();
                        this.Hide();
                    }
                    else if (TaiKhoanBLL.Instance.CheckTuCach(getuser) == "NhanVien")
                    {
                        FormMenuNhanVien fNV = new FormMenuNhanVien(getuser); //thêm id để sửa tài khoản
                        fNV.dExit = new FormMenuNhanVien.myDel(xuathien);
                        fNV.Show();
                        this.Hide();
                    }
                    lblThongBao.Text = "";
                }
                else
                {
                    lblThongBao.Text = ("Tài khoản của bạn chưa được cấp quyền truy cập.");
                }
            }
        }
        private void xuathien()
        {
            this.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            uclDangKy ucl = new uclDangKy();
            this.Hide();
            this.Parent.Controls.Add(ucl);
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

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            this.Hide();
            this.Parent.Controls.Add(quenMK);
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
