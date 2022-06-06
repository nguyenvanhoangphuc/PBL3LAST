using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class AddLichSuSuaChua : Form
    {
        public delegate void myDel(string idphong, DateTime date);
        public myDel dShow;
        public string idNhanVien { get; set; }
        public string id { get; set; }
        public AddLichSuSuaChua(string idNhanVien, string idLS)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
            id = idLS;
            setCBB();
            GUI();
        }

        private void setCBB()
        {
            cbbPhong.DataSource = PhongTroBLL.Instance.GetAllCBBPhong().ToArray();
            cbbPhong.ValueMember = "ID";
            cbbPhong.DisplayMember = "Ten";
            cbbPhong.Text = "";
        }

        private void GUI()
        {
            if (id != "")
            {
                txtID.Text = id;
                txtID.Enabled = false;
                cbbPhong.SelectedValue = LichSuSuaChuaBLL.Instance.GetLSSuaChuaByID(id).IDPhong;
                cbbLoaiTB.SelectedValue = LichSuSuaChuaBLL.Instance.GetLSSuaChuaByID(id).ID_LoaiThietBi;
                dateSuaChua.Value = (DateTime)LichSuSuaChuaBLL.Instance.GetLSSuaChuaByID(id).NgaySuaChua;
                txtSoTien.Text = LichSuSuaChuaBLL.Instance.GetLSSuaChuaByID(id).SoTienSuaChua.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                txtID.Text = "";
                cbbPhong.Text = "";
                cbbLoaiTB.Text = "";
                dateSuaChua.Value = DateTime.Now;
                txtSoTien.Text = "0";
            }
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLoaiTB.DataSource = ThietBiBLL.Instance.GetCBBLoaiTBByPhong(((CBBItem)cbbPhong.SelectedItem).ID).ToArray();
            cbbLoaiTB.ValueMember = "ID";
            cbbLoaiTB.DisplayMember = "Ten";
            cbbLoaiTB.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LichSuSuaChua lssc = new LichSuSuaChua
            {
                ID_LichSuSuaChua = txtID.Text,
                IDNhanVien = idNhanVien,
                IDPhong = ((CBBItem)cbbPhong.SelectedItem).ID,
                ID_LoaiThietBi = ((CBBItem)cbbLoaiTB.SelectedItem).ID,
                NgaySuaChua = dateSuaChua.Value,
                SoTienSuaChua = Convert.ToInt32(txtSoTien.Text)
            };
            string value = LichSuSuaChuaBLL.Instance.AddLichSuSuaChua(lssc, id);
            switch (value)
            {
                case "requied_ID":
                    MessageBox.Show("ID không được để trống!");
                    return;
                case "requied_Phong":
                    MessageBox.Show("Tên phòng không được để trống!");
                    return;
                case "requied_ID_LoaiTB":
                    MessageBox.Show("Tên loại thiết bị không được để trống!");
                    return;
                case "added":
                    MessageBox.Show("Đã thêm thành công lịch sử sửa chữa mới!");
                    //show lai DGVPhongTro
                    dShow("0", DateTime.Now);
                    this.Close();
                    return;
                case "updated":
                    MessageBox.Show("Đã chỉnh sửa thành công lần sửa chữa này!");
                    dShow("0", DateTime.Now);
                    this.Close();
                    return;
                case "show message trung ID":
                    MessageBox.Show("ID không hợp lệ! Đã tồn tại ID lịch sử sửa chữa này.");
                    return;
            }
        }
    }
}
