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
    public partial class FormUpdateTB : Form
    {
        public delegate void myDel();
        public myDel dShow;
        public string idphong { get; set; }
        public string idloaitb { get; set; }
        public FormUpdateTB(string IDPhong, string IDLoaiTB)
        {
            InitializeComponent();
            idphong = IDPhong;
            idloaitb = IDLoaiTB;
            setCBB(); 
            GUI();
            cbbTenPhong.Enabled = false;
            cbbTenLoaiTB.Enabled = false;
        }

        private void setCBB()
        {
            cbbTenPhong.DataSource = PhongTroBLL.Instance.GetAllCBBPhong().ToArray();
            cbbTenPhong.ValueMember = "ID";
            cbbTenPhong.DisplayMember = "Ten";
            
            cbbTenLoaiTB.DataSource = ThietBiBLL.Instance.GetAllCBBLoaiTB().ToArray();
            cbbTenLoaiTB.ValueMember = "ID";
            cbbTenLoaiTB.DisplayMember = "Ten";
        }

        private void GUI()
        {
            cbbTenPhong.SelectedValue = ThietBiBLL.Instance.GetThietBiByID(idphong, idloaitb).IDPhong;
            cbbTenLoaiTB.SelectedValue = ThietBiBLL.Instance.GetThietBiByID(idphong, idloaitb).IDLoaiThietBi;
            rbutHong.Checked = ThietBiBLL.Instance.GetThietBiByID(idphong, idloaitb).TinhTrang;
            rbutTot.Checked= !ThietBiBLL.Instance.GetThietBiByID(idphong, idloaitb).TinhTrang; 
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control cr in gbTT.Controls)
            {
                ((RadioButton)cr).Checked = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbbTenPhong.Text == "" || cbbTenLoaiTB.Text == "" || ((rbutHong.Checked==false)&&(rbutTot.Checked==false)) )
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
                return;
            }
            ThietBi tb = new ThietBi
            {
                IDPhong = ((CBBItem)cbbTenPhong.SelectedItem).ID,
                IDLoaiThietBi = ((CBBItem)cbbTenLoaiTB.SelectedItem).ID,
                TinhTrang = rbutHong.Checked
            };
            ThietBiBLL.Instance.UpdateTB(tb);
            dShow();
            this.Close(); 
        }
    }
}
