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
    public partial class FormViewTB_LoaiPhong : Form
    {
        string IDLoaiPhong;
        public FormViewTB_LoaiPhong(string Id)
        {
            this.IDLoaiPhong = Id;
            InitializeComponent();
            GUI();
        }
        public FormViewTB_LoaiPhong()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            txtTenLoaiPhong.Text = BLL.LoaiPhongBLL.Instance.GetTenLoaiPhong(IDLoaiPhong);
            dgv.DataSource = BLL.LoaiPhongBLL.Instance.GetLoaiThietBiByLoaiPhong(IDLoaiPhong);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}