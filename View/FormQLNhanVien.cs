using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void ShowDGV()
        {
            DGVNhanVien.DataSource = NhanVienBLL.Instance.GetDSNhanVienView();
            DGVNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            DGVNhanVien.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien ap = new AddNhanVien("");
            ap.dShow = new AddNhanVien.myDel(ShowDGV);
            ap.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.SelectedRows.Count == 1)
            {
                AddNhanVien ap = new AddNhanVien(DGVNhanVien.SelectedRows[0].Cells["ID"].Value.ToString());
                ap.dShow = new AddNhanVien.myDel(ShowDGV);
                ap.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGVNhanVien.SelectedRows.Count > 0)
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xoá", MessageBoxButtons.OKCancel);
                if (dlrs == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in DGVNhanVien.SelectedRows)
                    {
                        NhanVienBLL.Instance.DeleteNhanVien(i.Cells[0].Value.ToString());
                    }
                    ShowDGV();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanVienView nv = new NhanVienView
            {
                Ten = (cbTen.Checked) ? txtSearch.Text : "",
                QueQuan = (cbQueQuan.Checked) ? txtSearch.Text : "",
                SDT = (cbSDT.Checked) ? txtSearch.Text : "",
                CCCD = (cbCCCD.Checked) ? txtSearch.Text : ""
            };
            DGVNhanVien.DataSource = NhanVienBLL.Instance.SearchDataNV(nv);
        }

        private void butDefault_Click(object sender, EventArgs e)
        {
            foreach (Control cr in gbSearch.Controls)
            {
                ((CheckBox)cr).Checked = false;
            }
            txtSearch.Text = "";
            ShowDGV();
        }

        private void lblChoDuyet_Click(object sender, EventArgs e)
        {
            FormNVChoDuyet f = new FormNVChoDuyet();
            f.Show();
        }
        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Blue;
        }
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.RoyalBlue;
        }
    }
}
