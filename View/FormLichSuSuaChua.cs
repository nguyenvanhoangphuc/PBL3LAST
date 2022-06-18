using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormLichSuSuaChua : Form
    {
        public string idNhanVien { get; set; }
        public FormLichSuSuaChua(string idNhanVien)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
            SetCBB();
            ShowDGV("0", new DateTime(2022-10-8));
        }

        private void SetCBB()
        {
            cbbPhong.DataSource = PhongTroBLL.Instance.GetAllCBBPhongFull();
            cbbPhong.ValueMember = "ID";
            cbbPhong.DisplayMember = "Ten";
        }

        private void ShowDGV(string idPhong, DateTime date)
        {
            DGVLSSuaChua.DataSource = LichSuSuaChuaBLL.Instance.GetLSSuaChuaViewByPhong(idPhong, date);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLichSuSuaChua f = new AddLichSuSuaChua(idNhanVien, "");
            f.dShow = new AddLichSuSuaChua.myDel(ShowDGV);
            f.Show();
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDGV(((CBBItem)cbbPhong.SelectedItem).ID, dateSuaChua.Value);
        }

        private void dateSuaChua_ValueChanged(object sender, EventArgs e)
        {
            ShowDGV(((CBBItem)cbbPhong.SelectedItem).ID, dateSuaChua.Value);
        }

        private void butDefault_Click(object sender, EventArgs e)
        {
            cbbPhong.SelectedIndex = 0;
            dateSuaChua.Value = DateTime.Now;
            ShowDGV("0", DateTime.Now);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVLSSuaChua.SelectedRows.Count == 1)
            {
                AddLichSuSuaChua f = new AddLichSuSuaChua(idNhanVien, DGVLSSuaChua.SelectedRows[0].Cells[0].Value.ToString());
                f.dShow = new AddLichSuSuaChua.myDel(ShowDGV);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGVLSSuaChua.SelectedRows.Count > 0)
            {
                DialogResult dlrs = MessageBox.Show("Bạn có chắc muốn xoá phòng này?", "Xoá", MessageBoxButtons.OKCancel);
                if (dlrs == DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in DGVLSSuaChua.SelectedRows)
                    {
                        LichSuSuaChuaBLL.Instance.Delete(dr.Cells[0].Value.ToString());
                    }
                    ShowDGV("0", DateTime.Now);
                }
            }
        }
    }
}
