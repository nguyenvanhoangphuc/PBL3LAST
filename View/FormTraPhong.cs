using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;
namespace QuanLyPhongTroLinQ.View
{
    public partial class FormTraPhong : Form
    {
        public delegate void Mydel();
        public Mydel t;

        public FormTraPhong()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            cboLoaiPhong.Items.AddRange(BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong().ToArray());
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataForDGV();


        }
        public void GetDataForDGV()
        {
            foreach (CBBItemLoaiPhong i in BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong())
            {
                if (i.TenLoaiPhong == cboLoaiPhong.SelectedItem.ToString())
                {
                    dgvPhong.DataSource = BLL_DatTraPhong.Instance.GetPhongTroViewByLoaiPhong(i.ID);

                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            t();
            this.Close();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvPhong.SelectedRows[0].Cells["SoTien"].Value.ToString()) >= 0)
            {
                foreach (DataGridViewRow i in dgvPhong.SelectedRows)
                    BLL_DatTraPhong.Instance.TraPhong(i.Cells["IDPhong"].Value.ToString());

            }
            GetDataForDGV();
        }

        private void dgvPhong_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPhong.SelectedRows[0].Cells["TinhTrang"].Value.ToString() == "True")
            {
                PhongTro_DatPhongView t = new PhongTro_DatPhongView()
                {
                    TenPhong = dgvPhong.SelectedRows[0].Cells["TenPhong"].Value.ToString(),
                    NgayThue = DateTime.Parse(dgvPhong.SelectedRows[0].Cells["NgayThue"].Value.ToString()),
                    SoChuDIen = Convert.ToInt32(dgvPhong.SelectedRows[0].Cells["SoChuDien"].Value.ToString()),
                    SoTien = Convert.ToInt32(dgvPhong.SelectedRows[0].Cells["SoTien"].Value.ToString())
                };
                FormTTPhong f = new FormTTPhong(t, cboLoaiPhong.SelectedItem.ToString());
                f.t = new FormTTPhong.Mydel(GetDataForDGV);
                f.Show();
            }
        }
    }
}
