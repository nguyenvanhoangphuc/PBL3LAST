using QuanLyPhongTroLinQ.BLL;
using System;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormDSPhong : Form
    {
        public FormDSPhong()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void ShowDGV()
        {
            DGVPhongTro.DataSource = PhongTroBLL.Instance.GetDSPhongTroView(); //return List<PhongTroView>
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPhong ap = new AddPhong("");
            ap.dShow = new AddPhong.myDel(ShowDGV);
            ap.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVPhongTro.SelectedRows.Count == 1)
            {
                AddPhong up = new AddPhong(DGVPhongTro.SelectedRows[0].Cells["ID"].Value.ToString());
                up.dShow = new AddPhong.myDel(ShowDGV);
                up.Show();
            }
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGVPhongTro.SelectedRows.Count > 0)
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xoá phòng này?", "Xoá", MessageBoxButtons.OKCancel);
                if (dlrs == DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in DGVPhongTro.SelectedRows)
                    {
                        PhongTroBLL.Instance.DeletePhong(dr.Cells[0].Value.ToString());
                    }
                    ShowDGV();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu check box đưa vào PhongTro
            PhongTroView pt = new PhongTroView
            {
                ID = (cbID.Checked) ? txtSearch.Text : "",
                TenPhong = (cbTen.Checked) ? txtSearch.Text : "",
                TenLoaiPhong = (cbLoai.Checked) ? txtSearch.Text : "",
                TinhTrang = (cbTT.Checked) ? txtSearch.Text : ""
            };
            DGVPhongTro.DataSource = PhongTroBLL.Instance.SearchData(pt);
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
    }
}
