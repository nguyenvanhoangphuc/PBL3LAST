using QuanLyPhongTroLinQ.BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            TKSoPhong();
            ShowDGV();
            SetCBB();
        }

        private void SetCBB()
        {
            cbbYear.Items.Add("All"); 
            cbbYear.Items.AddRange(LichSuSuaChuaBLL.Instance.GetNamOfLSSC().Distinct().ToArray());
            cbbYear.SelectedIndex = 0;
        }

        private void ShowDGV()
        {
            DGVThongKe.DataSource = ThongKe_NVBLL.Instance.GetTKLSSCTB(cbbYear.Text, cbbMonth.Text);
        }

        private void TKSoPhong()
        {
            lblSophong.Text = ThongKe_NVBLL.Instance.GetSoLuongPhong().ToString();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (DGVThongKe.SelectedRows.Count == 1)
            {
                lblPhongHienTai.Text = DGVThongKe.SelectedRows[0].Cells[0].Value.ToString();
                DGVThongKe.DataSource = LichSuSuaChuaBLL.Instance.GetThongKeLSSuaChuaViewByPhong(
                    PhongTroBLL.Instance.GetIDByTen(DGVThongKe.SelectedRows[0].Cells[0].Value.ToString()),
                    cbbYear.Text, cbbMonth.Text);
            }
        }
        private void btnRevert_Click(object sender, EventArgs e)
        {
            ShowDGV();
            lblPhongHienTai.Text = "?";
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMonth.Items.Clear(); 
            cbbMonth.Items.Add("All");
            cbbMonth.Items.AddRange(LichSuSuaChuaBLL.Instance.GetThangOfLSSC(cbbYear.Text).Distinct().ToArray());
            cbbMonth.SelectedIndex = 0;
            ShowDGV(); 
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV(); 
        }
    }
}
