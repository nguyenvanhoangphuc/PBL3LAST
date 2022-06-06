using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormQLTB : Form
    {
        public FormQLTB()
        {
            InitializeComponent();
            showDGV();
        }

        public void showDGV()
        {
            DGVThietBi.DataSource = ThietBiBLL.Instance.GetThietBiViews();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVThietBi.SelectedRows.Count == 1)
            {
                ThietBi tb = new ThietBi
                {
                    IDPhong = ((CBBItem)(DGVThietBi.SelectedRows[0].Cells["TenPhong"].Value)).ID,
                    IDLoaiThietBi = ((CBBItem)(DGVThietBi.SelectedRows[0].Cells["TenLoaiTB"].Value)).ID,
                    TinhTrang = (DGVThietBi.SelectedRows[0].Cells["TinhTrang"].Value.ToString() == "Hong")
                };
                FormUpdateTB f = new FormUpdateTB(tb.IDPhong, tb.IDLoaiThietBi);
                f.dShow = new FormUpdateTB.myDel(showDGV);
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ThietBiView tb = new ThietBiView
            {
                TenPhong = new CBBItem { ID = "", Ten = (cbPhong.Checked) ? txtSearch.Text : "" },
                TenLoaiTB = new CBBItem { ID = "", Ten = (cbLoaiTB.Checked) ? txtSearch.Text : "" },
                TinhTrang = (cbTT.Checked) ? txtSearch.Text : ""
            };
            DGVThietBi.DataSource = ThietBiBLL.Instance.SearchData(tb);
        }

        private void butDefault_Click(object sender, EventArgs e)
        {
            foreach (Control cr in gbSearch.Controls)
            {
                ((CheckBox)cr).Checked = false;
            }
            txtSearch.Text = "";
            showDGV();
        }
    }
}