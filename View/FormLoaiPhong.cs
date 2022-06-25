using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
            HienThi();
        }

        public  void HienThi()
        {
           
            dgv.DataSource = BLL.LoaiPhongBLL.Instance.hienthi();
            dgv.Columns["IDLoaiPhong"].Visible = false;
            dgv.Columns["PhongTros"].Visible = false;
            dgv.Columns["DanhSachIDLTB"].Visible = false;

        }

        private void btnXemThietBi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(BLL.LoaiPhongBLL.Instance.ShowDSThietBi(dgv.SelectedRows[0].Cells[0].Value.ToString()));
            if (dgv.SelectedRows.Count == 1)
            {
                FormViewTB_LoaiPhong f = new FormViewTB_LoaiPhong(dgv.SelectedRows[0].Cells[0].Value.ToString());
                f.Show();
            }
        }
    }
}