using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormMenuNhanVien : Form
    {
        public string idNhanVien { get; set; }
        public delegate void myDel();
        public myDel dExit;
        public FormMenuNhanVien(string idNV)
        {
            InitializeComponent();
            idNhanVien = idNV;
        }

        public void Default()
        {
            if (pnlDSThietBi.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSThietBi.ForeColor = SystemColors.ActiveCaptionText;
                lblDSThietBi.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSThietBi.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlLoaiPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblLoaiPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblLoaiPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlLoaiPhong.BackColor = SystemColors.ButtonHighlight;
            }
            if (pnlLSSuaChua.BackColor != SystemColors.ButtonHighlight)
            {
                lblLichSuSuaChua.ForeColor = SystemColors.ActiveCaptionText;
                lblLichSuSuaChua.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlLSSuaChua.BackColor = SystemColors.ButtonHighlight;
            }
            if (pnlTaiKhoan.BackColor != SystemColors.ButtonHighlight)
            {
                lblTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
                lblTaiKhoan.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlTaiKhoan.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlThongKe.BackColor != SystemColors.ButtonHighlight)
            {
                lblThongKe.ForeColor = SystemColors.ActiveCaptionText;
                lblThongKe.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlThongKe.BackColor = SystemColors.ButtonHighlight;
            }
        }
        private void lblDSThietBi_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblDSThietBi.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSThietBi.BackColor = SystemColors.ControlDarkDark;
            lblDSThietBi.ForeColor = Color.Blue;
            FormQLTB f = new FormQLTB();
            f.MdiParent = this;
            f.Show();
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Blue;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ActiveCaptionText;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            dExit();
            this.Close();
        }

        private void lblLichSuSuaChua_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblLichSuSuaChua.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlLSSuaChua.BackColor = SystemColors.ControlDarkDark;
            lblLichSuSuaChua.ForeColor = Color.Blue;
            FormLichSuSuaChua f = new FormLichSuSuaChua(idNhanVien);
            f.MdiParent = this;
            f.Show();
        }

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblThongKe.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlThongKe.BackColor = SystemColors.ControlDarkDark;
            lblThongKe.ForeColor = Color.Blue;
            FormThongKe f = new FormThongKe();
            f.MdiParent = this;
            f.Show();
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
