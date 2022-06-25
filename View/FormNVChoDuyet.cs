using QuanLyPhongTroLinQ.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormNVChoDuyet : Form
    {
        public FormNVChoDuyet()
        {
            InitializeComponent();
            showDGV();
        }

        private void showDGV()
        {
            DGVNVChon.DataSource = NhanVienBLL.Instance.GetDSNVViewChoDuyet();
            DGVNVChon.Columns[0].Visible = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (DGVNVChon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in DGVNVChon.SelectedRows)
                {
                    list.Add(dgvr.Cells[0].Value.ToString());
                }
            }
            DGVNVDuyet.DataSource = NhanVienBLL.Instance.GetDSNhanVienViewByID(list);
        }

        private void butConf_Click(object sender, EventArgs e)
        {
            if (DGVNVDuyet.Rows.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow dgvr in DGVNVDuyet.Rows)
                {
                    list.Add(dgvr.Cells[0].Value.ToString());
                }
                NhanVienBLL.Instance.ChapNhanDSNhanVien(list);
                MessageBox.Show("Đã duyệt nhân viên trên thành nhân viên chính thức.");
                showDGV();
                DGVNVDuyet.DataSource = null; 
            }
        }

        private void btnUnChoose_Click(object sender, EventArgs e)
        {
            if (DGVNVDuyet.SelectedRows.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow dgvr in DGVNVDuyet.Rows)
                {
                    list.Add(dgvr.Cells[0].Value.ToString());
                }
                foreach (DataGridViewRow noDGVR in DGVNVDuyet.SelectedRows)
                {
                    list.Remove(noDGVR.Cells[0].Value.ToString());
                }
                DGVNVDuyet.DataSource = NhanVienBLL.Instance.GetDSNhanVienViewByID(list);
            }
        }
    }
}
