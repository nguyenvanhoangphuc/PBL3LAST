using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
namespace QuanLyPhongTroLinQ.View
{
    public partial class FormTTPhong : Form
    {
        public delegate void Mydel();
        public Mydel t;
        public PhongTro_DatPhongView phong;
        public string LoaiPhong;
        public FormTTPhong(PhongTro_DatPhongView x, string LP)
        {
            InitializeComponent();
            this.phong = x;
            LoaiPhong = LP;
            GUI();

        }
        public void GUI()
        {
            txtTenPhong.Text = phong.TenPhong;
            txtLoaiPhong.Text = LoaiPhong;
            txtSoChuDien.Text = phong.SoChuDIen.ToString();
            txtSoTien.Text = phong.SoTien.ToString();
            dgvNguoiThue.DataSource = BLL_DatTraPhong.Instance.GetNguoiThueTrongPhongTro(phong.TenPhong);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnTraPhong_Click(object sender, EventArgs e)
        {


            BLL_DatTraPhong.Instance.TraPhongWithTenPhong(phong.TenPhong);
            t();
        }
    }
}

