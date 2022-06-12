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
    public partial class FormAllThang : Form
    {
        public delegate void HamTrienKhai1();

        public HamTrienKhai1 TrienKhai1;

        public string ID_Phong;

        public string TenPhong;
        public FormAllThang(string ID_Phong, string TenPhong)
        {
            InitializeComponent();

            lbl_TenPhong.Text = TenPhong;
            this.ID_Phong = ID_Phong;
            rdo_CaHai.Checked = true;
            this.TenPhong = TenPhong;
            TraTienBLL.Instance.CreateDB();
            GUI();
        }

        public void GUI()
        {

            dgv_DSThang.DataSource = TraTienBLL.Instance.GetDSTienThang(txt_TimKiem.Text, rdo_CaHai.Checked, rdo_DaNop.Checked, ID_Phong);
            dgv_DSThang.Columns[0].Visible = false;
            
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

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormAddFixThang f = new FormAddFixThang(ID_Phong);
            f.TrienKhai = new FormAddFixThang.HamTrienKhai(GUI);
            f.TrienKhai1 = new FormAddFixThang.HamTrienKhai1(TrienKhai1);
            f.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa tháng mới nhất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
              
                TraTienBLL.Instance.XoaThangMoiNhat(dgv_DSThang.Rows[dgv_DSThang.Rows.Count-2].Cells["ID"].Value.ToString());
                GUI();
                TrienKhai1();
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn chỉnh sửa tháng mới nhất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                 
                FormAddFixThang f = new FormAddFixThang(ID_Phong, dgv_DSThang.Rows[dgv_DSThang.Rows.Count - 2].Cells["ID"].Value.ToString());
                f.TrienKhai = new FormAddFixThang.HamTrienKhai(GUI);
                f.TrienKhai1 = new FormAddFixThang.HamTrienKhai1(TrienKhai1);
                f.Show();
            }
        }

        private void btn_nap_Click(object sender, EventArgs e)
        {
            if (dgv_DSThang.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Click OK để nạp tiền hoặc chuyển về chưa nạp tiền", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK) { 
                    TraTienBLL.Instance.NapTien(dgv_DSThang.SelectedRows[0].Cells["ID"].Value.ToString());
                    GUI();
                    TrienKhai1();
                }

            }
            else MessageBox.Show("Vui lòng chọn một tháng để nộp tiền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string s = TraTienBLL.Instance.XuatHoaDon(ID_Phong, TenPhong, dgv_DSThang);

            FormHoaDon f= new FormHoaDon(TenPhong, s);
            f.Show();
        }
    }
}
