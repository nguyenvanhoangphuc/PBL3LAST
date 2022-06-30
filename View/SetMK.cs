﻿using QuanLyPhongTroLinQ.BLL;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace QuanLyPhongTroLinQ.View
{
    public partial class uclSetMK : UserControl
    {
        string em;
        static string code;
        public uclSetMK(string email, string MaXN)
        {
            em = email;
            code = MaXN;
            InitializeComponent();
        }

        private void uclSetMK_Load(object sender, EventArgs e)
        {

        }
        private void txtNhapMKMoi_Leave(object sender, EventArgs e)
        {
            if (txtNhapMKMoi.Text == "")
            {
                txtNhapMKMoi.Text = "Nhập mật khẩu mới";
                txtNhapMKMoi.ForeColor = Color.Silver;
            }
        }

        private void txtNhapMKMoi_Enter(object sender, EventArgs e)
        {
            if (txtNhapMKMoi.Text != "Nhập mật khẩu mới")
            {
                txtNhapMKMoi.UseSystemPasswordChar = true;
                txtNhapMKMoi.Text = "";
                txtNhapMKMoi.ForeColor = Color.Black;
            }

            else
            {
                txtNhapMKMoi.Text = "";
            }
        }

        private void txtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == "")
            {
                txtNhapLaiMK.Text = "Nhập lại mật khẩu";
                txtNhapLaiMK.ForeColor = Color.Silver;
            }
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text != "Nhập lại mật khẩu")
            {
                txtNhapLaiMK.UseSystemPasswordChar = true;
                txtNhapLaiMK.Text = "";
                txtNhapLaiMK.ForeColor = Color.Black;
            }
            else
            {
                txtNhapLaiMK.Text = "";
            }
        }

        private void btnHienMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtNhapMKMoi.UseSystemPasswordChar = false;
            btnHienMatKhau1.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.iconShow;
        }

        private void btnHienMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNhapMKMoi.Text != "Nhập mật khẩu mới")
            {
                txtNhapMKMoi.UseSystemPasswordChar = true;
            }
            btnHienMatKhau1.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.eyeClose;
        }

        private void btnHienMatKhau2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNhapLaiMK.UseSystemPasswordChar = false;
            btnHienMatKhau2.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.iconShow;
        }

        private void btnHienMatKhau2_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNhapLaiMK.Text != "Nhập lại mật khẩu")
            {
                txtNhapLaiMK.UseSystemPasswordChar = true;
            }
            btnHienMatKhau2.BackgroundImage = global::QuanLyPhongTroLinQ.Properties.Resources.eyeClose;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == txtNhapMKMoi.Text)
            {
                lblThongBao.Text = TaiKhoanBLL.Instance.SetMK(em, HashPass(txtNhapMKMoi.Text));
                uclDangNhap dn = new uclDangNhap();
                this.Hide();
                this.Parent.Controls.Add(dn);
            }
            else
            {
                lblThongBao.Text = "Mật khẩu không trùng khớp";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uclXacNhanMK u = new uclXacNhanMK(em, code);
            this.Hide();
            this.Parent.Controls.Add(u);
        }
        public string HashPass(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}