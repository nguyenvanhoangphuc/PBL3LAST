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

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormNguoiThue : Form
    {
        public void GUI()
        {
            dGV_NguoiThue.DataSource = NguoiThueBLL.Instance.GetAllNguoiThueView(txt_TimKiem.Text, rdo_HVT.Checked, rdo_SDT.Checked, rdo_QQ.Checked, rdo_CCCD.Checked, rdo_DT.Checked);
            dGV_NguoiThue.Columns[0].Visible = false;
        }
        public FormNguoiThue()
        {
            InitializeComponent();
            GUI();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            GUI();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FormThemNguoi f = new FormThemNguoi("them", new NguoiThue { ID=(dGV_NguoiThue.Rows.Count+1).ToString()});
            f.TrienKhai = new FormThemNguoi.ChuaCongThucTrienKhai(GUI);
            f.Show();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dGV_NguoiThue.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dGV_NguoiThue.SelectedRows[0];

                FormThemNguoi f = new FormThemNguoi("sua", NguoiThueBLL.Instance.DoiTuongNguoiThue(r.Cells["ID"].Value.ToString(), r.Cells["Họ và tên"].Value.ToString(), r.Cells["Số điện thoại"].Value.ToString(), r.Cells["Quê quán"].Value.ToString(), r.Cells["Căn cước công dân"].Value.ToString(), r.Cells["Tình trạng"].Value.ToString()=="Đã thuê"?true:false));
                f.TrienKhai = new FormThemNguoi.ChuaCongThucTrienKhai(GUI);
                f.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa thông tin người thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dGV_NguoiThue.SelectedRows.Count >= 1)
            {
                int error = 0;
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa những người thuê đã chọn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    foreach (DataGridViewRow r in dGV_NguoiThue.SelectedRows)
                        error += NguoiThueBLL.Instance.XoaNguoiThue(r.Cells["ID"].Value.ToString(), r.Cells["Tình trạng"].Value.ToString()=="Đã thuê"?true:false);
                if (error > 0)
                    MessageBox.Show(error.ToString() + " hàng không được xóa vì chưa trả phòng khi phòng chỉ còn một người thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GUI();
            }
            else
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa người thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
