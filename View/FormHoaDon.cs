using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using QuanLyPhongTroLinQ.BLL;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormHoaDon : Form
    {
        public FolderBrowserDialog FBD= new FolderBrowserDialog();
        public string TenPhong;
        public FormHoaDon(string TenPhong, string s)
        {
            InitializeComponent();
            text_HoaDon.Text = s;
            this.TenPhong = TenPhong;
        }

        private void but_Browse_Click(object sender, EventArgs e)
        {
            FBD.Description = "Hãy chọn thư mục xuất hóa đơn";
            FBD.ShowDialog();
            txt_Path.Text = FBD.SelectedPath;
           
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            if (txt_Path.Text != "")
            {
                File.WriteAllText(txt_Path.Text + "\\HoaDon" + TenPhong + ".txt", text_HoaDon.Text);
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng click vào Browse để chọn đường dẫn xuất file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_xuat_Click_1(object sender, EventArgs e)
        {
            if (txt_Path.Text != "")
            {
                File.WriteAllText(txt_Path.Text + "\\HoaDon" + TenPhong + ".txt", text_HoaDon.Text);
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng click vào Browse để chọn đường dẫn xuất file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
