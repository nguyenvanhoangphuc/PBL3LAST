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
    public partial class FormShowNguoiThue : Form
    {
        string ID;
        public FormShowNguoiThue(string id)
        {
            InitializeComponent();
            ID = id;
            lblSophong.Text = NguoiThueBLL.Instance.GetTenPhongByID(ID);
            ShowDGV(); 
        }

        private void ShowDGV()
        {
            DGVNguoiThue.DataSource = NguoiThueBLL.Instance.GetNguoiThueViewByPhongTro(ID);
            DGVNguoiThue.Columns[0].Visible = false;
            //DGVNguoiThue.Columns["TinhTrang"].Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
