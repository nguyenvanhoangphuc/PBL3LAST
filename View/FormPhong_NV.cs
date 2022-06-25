using QuanLyPhongTroLinQ.BLL;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormPhong_NV : Form
    {
        public FormPhong_NV()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void ShowDGV()
        {
            DGVPhongTro.DataSource = PhongTroBLL.Instance.GetDSPhongTroView(); //return List<PhongTroView>
            DGVPhongTro.Columns[0].Visible = false;
            DGVPhongTro.Columns["TenPhong"].HeaderText = "Tên phòng";
            DGVPhongTro.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";
            DGVPhongTro.Columns["TinhTrang"].HeaderText = "Tình trạng";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu check box đưa vào PhongTro
            DTO.PhongTroView pt = new DTO.PhongTroView
            {
                ID = "",
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

        private void DGVPhongTro_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormXemThietBiPhong f = new FormXemThietBiPhong(DGVPhongTro.SelectedRows[0].Cells["TenPhong"].Value.ToString(), DGVPhongTro.SelectedRows[0].Cells["ID"].Value.ToString());
            f.Show();
        }

     
    }
}
