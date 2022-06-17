using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Windows.Forms;


namespace QuanLyPhongTroLinQ.View
{
    public partial class FormThemNguoi : Form
    {
        public string s;
        public string ID;
        public bool DT;

        public delegate void ChuaCongThucTrienKhai();
        public ChuaCongThucTrienKhai TrienKhai { get; set; }
        public FormThemNguoi(string s, NguoiThue x)
        {
            InitializeComponent();
            txt_HVT.Text = x.HoTen;
            txt_SDT.Text = x.SDT;
            txt_QQ.Text = x.QueQuan;
            txt_CCCD.Text = x.CCCD;

            this.s = s;
            this.ID = x.ID;
            this.DT = x.TinhTrang;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (s == "sua") NguoiThueBLL.Instance.SuaNguoiThue(NguoiThueBLL.Instance.DoiTuongNguoiThue(ID, txt_HVT.Text, txt_SDT.Text, txt_QQ.Text, txt_CCCD.Text, DT));
            else NguoiThueBLL.Instance.ThemNguoiThue(NguoiThueBLL.Instance.DoiTuongNguoiThue(ID, txt_HVT.Text, txt_SDT.Text, txt_QQ.Text, txt_CCCD.Text, DT));
            TrienKhai();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
