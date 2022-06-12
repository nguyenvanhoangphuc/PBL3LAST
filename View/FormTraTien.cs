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

using QuanLyPhongTroLinQ.DTO;
using QuanLyPhongTroLinQ.DTO.DTO_CSDL;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormTraTien : Form
    {
        QLPT db = new QLPT();
        public FormTraTien()
        {
            InitializeComponent();
            CreateDB();
            rdo_CaHai.Checked = true;
            GUI();
        }
        public void CreateDB()
        {
            TraTienBLL.Instance.CreateDB();
        }

        public void GUI()
        {

            dgv_TraTien.DataSource = TraTienBLL.Instance.GetDSTraTien(txt_TimKiem.Text, rdo_CaHai.Checked, rdo_DaNop.Checked);
            dgv_TraTien.Columns[0].Visible = false;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void rdo_ChuaNop_CheckedChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void rdo_DaNop_CheckedChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void rdo_CaHai_CheckedChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (dgv_TraTien.SelectedRows.Count == 1 && dgv_TraTien.SelectedRows[0].Index != dgv_TraTien.Rows.Count-1)
            {
                var r = dgv_TraTien.SelectedRows[0];
                FormAllThang f = new FormAllThang(r.Cells["ID_Phong"].Value.ToString(), r.Cells["Tên phòng"].Value.ToString());
                f.TrienKhai1 = new FormAllThang.HamTrienKhai1(GUI);
                f.Show();
            }
            else MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }
    }
}
