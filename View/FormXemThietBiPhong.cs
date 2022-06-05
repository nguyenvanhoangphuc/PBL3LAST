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
    public partial class FormXemThietBiPhong : Form
    {
        public string TenPhong, ID;
        public FormXemThietBiPhong(string TenPhong, string ID)
        {
            InitializeComponent();
            this.TenPhong = TenPhong;
            this.ID = ID;
            GUI();
        }
        public void GUI()
        {
            txtTenPhong.Text = TenPhong;
            DGVPhongTro.DataSource = BLL_Phong_NV.Instance.GetThietBiByIDPhong(ID);
            DGVPhongTro.Columns["PhongTro"].Visible = false;
            DGVPhongTro.Columns["LoaiThietBi"].Visible = false;
            DGVPhongTro.Columns["LichSuSuaChuas"].Visible = false;

            Console.WriteLine(ID);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
