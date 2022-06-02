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

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            TKSoPhong();
            ShowDGV(); 
        }

        private void ShowDGV()
        {
            DGVThongKe.DataSource = ThongKe_NVBLL.Instance.GetTKLSSCTB(); 
        }

        private void TKSoPhong()
        {
            lblSophong.Text = ThongKe_NVBLL.Instance.GetSoLuongPhong().ToString(); 
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (DGVThongKe.SelectedRows.Count ==1)
            {
                lblPhongHienTai.Text = DGVThongKe.SelectedRows[0].Cells[0].Value.ToString(); 
                DGVThongKe.DataSource = LichSuSuaChuaBLL.Instance.GetLSSuaChuaViewByPhong(
                    PhongTroBLL.Instance.GetIDByTen(DGVThongKe.SelectedRows[0].Cells[0].Value.ToString()), 
                    DateTime.Now);
            }
        }
        private void btnRevert_Click(object sender, EventArgs e)
        {
            DGVThongKe.DataSource = ThongKe_NVBLL.Instance.GetTKLSSCTB();
            lblPhongHienTai.Text = "?"; 
        }
    }
}
