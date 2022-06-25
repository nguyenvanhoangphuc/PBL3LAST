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
    public partial class FormThongKeAD : Form
    {
        public FormThongKeAD()
        {
            InitializeComponent();
            TraTienBLL.Instance.CreateDB();
            SetComboBox();
            SetLabel();
        }

        public void SetComboBox()
        {
            cbb_nam.Items.Add("All");
            cbb_nam.SelectedIndex = 0;
            cbb_nam.Items.AddRange(ThongKe_ADBLL.Instance.GetAllYear().ToArray());
    
        }
        public void SetLabel()
        {
            lbl_SoPhongTro.Text = ThongKe_ADBLL.Instance.GetSoPhongTro().ToString();
            lbl_SoNhanVien.Text = ThongKe_ADBLL.Instance.GetSoNhanVien().ToString();
            lbl_SoNguoiThue.Text = ThongKe_ADBLL.Instance.GetSoNguoiThue().ToString();

        }
        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_thang.Items.Clear();
            cbb_thang.Items.Add("All");
            cbb_thang.SelectedIndex = 0;
            cbb_thang.Items.AddRange(ThongKe_ADBLL.Instance.GetAllMonth(cbb_nam.Text).ToArray());

            GUI();
        }

        public void GUI()
        {
            dgv_ThongKe.DataSource = ThongKe_ADBLL.Instance.GetDSThongKe(cbb_nam.Text, cbb_thang.Text);
            dgv_ThongKe.Columns[0].Visible = false;

            lbl_tien.Text = ThongKe_ADBLL.Instance.Total.ToString() + " VND";
        }

        private void cbb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
        }

       
    }
}
