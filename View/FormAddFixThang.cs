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
using QuanLyPhongTroLinQ.DTO.DTO_CSDL;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormAddFixThang : Form
    {
        public delegate void HamTrienKhai();
        public HamTrienKhai TrienKhai;

        public delegate void HamTrienKhai1();
        public HamTrienKhai1 TrienKhai1;


        public string ID_Thang;
        public string ID_Phong;
        public TienThang x;

        public FormAddFixThang(string ID_Phong, string ID_Thang="")
        {
            InitializeComponent();
            this.ID_Phong = ID_Phong;
            this.ID_Thang = ID_Thang;

            if (ID_Thang != "")
            {
                TienThang x = TraTienBLL.Instance.GetTienThangByID(ID_Thang);
                this.x = x;

                this.Text = "Chỉnh sửa tháng mới nhất";
                txt_TienPhong.Text = x.TienPhong.ToString();
                txt_ChuDien.Text = x.ChuDien.ToString();
                txt_ChuNuoc.Text = x.ChuNuoc.ToString();
                txt_TienPhong.Text = x.TienPhong.ToString();
                txt_TMCD.Text = x.TienMotChuDien.ToString();
                txt_TMCN.Text = x.TienMotChuNuoc.ToString();
                dtp_ThuTien.Value = x.NgayThu;
            }
            else
            {
                this.Text = "Thêm tháng mới";
                txt_TienPhong.Text = TraTienBLL.Instance.GetTienPhongByID_Phong(ID_Phong).ToString();

            }
                   

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {   
            if (dtp_ThuTien.Value < TraTienBLL.Instance.GetNgayThuMoiNhat(ID_Phong))
            {
                MessageBox.Show("Ngày thu hiện tại không được nhỏ hơn tháng trước !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            try
            {

                    if (Convert.ToInt32(txt_ChuDien.Text) < TraTienBLL.Instance.GetChuDienMoiNhat(ID_Phong))
                    {
                        MessageBox.Show("Số chữ điện hiện tại không được nhỏ hơn tháng trước !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (Convert.ToInt32(txt_ChuNuoc.Text) < TraTienBLL.Instance.GetChuNuocMoiNhat(ID_Phong))
                    {
                        MessageBox.Show("Số chữ nước hiện tại không được nhỏ hơn tháng trước !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (ID_Thang == "")
                            TraTienBLL.Instance.ThemThangMoi(TraTienBLL.Instance.EpVeTienThang((TraTienBLL.Instance.GetTongSoThang() + 1).ToString(), ID_Phong, dtp_ThuTien.Value, Convert.ToInt32(txt_TienPhong.Text), Convert.ToInt32(txt_ChuDien.Text), Convert.ToInt32(txt_ChuNuoc.Text), Convert.ToInt32(txt_TMCD.Text), Convert.ToInt32(txt_TMCN.Text), false));
                        else
                            TraTienBLL.Instance.SuaThangMoiNhat(x.ID, TraTienBLL.Instance.EpVeTienThang(x.ID, x.ID_Phong, dtp_ThuTien.Value, Convert.ToInt32(txt_TienPhong.Text), Convert.ToInt32(txt_ChuDien.Text), Convert.ToInt32(txt_ChuNuoc.Text), Convert.ToInt32(txt_TMCD.Text), Convert.ToInt32(txt_TMCN.Text), false));
                        TrienKhai();
                        TrienKhai1();
                        this.Close();
                    }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Dự liệu nhập vào không hợp lệ vui lòng kiểm tra lại !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
