using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormMenuChuTro : Form
    {
        public delegate void myDel();
        public myDel dExit;
        string IDChuTro;
        public FormMenuChuTro(string ID)
        {
            IDChuTro = ID;
            InitializeComponent();
        }
        public void Default()
        {
            if (pnlDSPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblDSPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlQLNV.BackColor != SystemColors.ButtonHighlight)
            {
                lblQLNV.ForeColor = SystemColors.ActiveCaptionText;
                lblQLNV.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlQLNV.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlLoaiPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblLoaiPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblLoaiPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlLoaiPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlDSNguoiThue.BackColor != SystemColors.ButtonHighlight)
            {
                lblDSNguoiThue.ForeColor = SystemColors.ActiveCaptionText;
                lblDSNguoiThue.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDSNguoiThue.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlDatPhong.BackColor != SystemColors.ButtonHighlight)
            {
                lblDatPhong.ForeColor = SystemColors.ActiveCaptionText;
                lblDatPhong.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlDatPhong.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlTraTien.BackColor != SystemColors.ButtonHighlight)
            {
                lblTraTien.ForeColor = SystemColors.ActiveCaptionText;
                lblTraTien.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlTraTien.BackColor = SystemColors.ButtonHighlight;
            }

            if (pnlThongKe.BackColor != SystemColors.ButtonHighlight)
            {
                lblThongKe.ForeColor = SystemColors.ActiveCaptionText;
                lblThongKe.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlThongKe.BackColor = SystemColors.ButtonHighlight;
            }
            if (pnlTaiKhoan.BackColor != SystemColors.ButtonHighlight)
            {
                lblTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
                lblTaiKhoan.MouseLeave += new EventHandler(this.lbl_MouseLeave);
                pnlTaiKhoan.BackColor = SystemColors.ButtonHighlight;
            }
        }
        private void lblDSPhong_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblDSPhong.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSPhong.BackColor = SystemColors.ControlDarkDark;
            lblDSPhong.ForeColor = Color.Blue;
            FormDSPhong fdsP = new FormDSPhong();
            fdsP.MdiParent = this;
            fdsP.Show();
        }
        //====================================
        private void lblDSNguoiThue_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblDSNguoiThue.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDSNguoiThue.BackColor = SystemColors.ControlDarkDark;
            lblDSNguoiThue.ForeColor = Color.Blue;
            FormNguoiThue f = new FormNguoiThue();
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

        private void lblLoaiPhong_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblLoaiPhong.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlLoaiPhong.BackColor = SystemColors.ControlDarkDark;
            lblLoaiPhong.ForeColor = Color.Blue;
            FormLoaiPhong f = new FormLoaiPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void lblTraTien_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblTraTien.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlTraTien.BackColor = SystemColors.ControlDarkDark;
            lblTraTien.ForeColor = Color.Blue;
            //FormTraTien f = new FormTraTien();
            //f.MdiParent = this;
            //f.Show();
        }

        private void lblDatPhong_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblDatPhong.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlDatPhong.BackColor = SystemColors.ControlDarkDark;
            lblDatPhong.ForeColor = Color.Blue;
            FormDatTraPhong f = new FormDatTraPhong();
            f.MdiParent = this;
            f.Show();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblThongKe.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlThongKe.BackColor = SystemColors.ControlDarkDark;
            lblThongKe.ForeColor = Color.Blue;
        }

        private void lblQLNV_Click(object sender, EventArgs e)
        {
            Default();
            panel4.Hide();
            lblQLNV.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlQLNV.BackColor = SystemColors.ControlDarkDark;
            lblQLNV.ForeColor = Color.Blue;
            FormQLNhanVien f = new FormQLNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            Default();
            lblTaiKhoan.MouseLeave -= new EventHandler(this.lbl_MouseLeave);
            pnlTaiKhoan.BackColor = SystemColors.ControlDarkDark;
            lblTaiKhoan.ForeColor = Color.Blue;
            panel4.Controls.Clear();
            panel4.Show();
            panel4.Controls.Add(new uclSuaTK(IDChuTro));
        }
    }
}