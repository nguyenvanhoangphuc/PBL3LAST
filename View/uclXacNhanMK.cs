using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.View
{
    public partial class uclXacNhanMK : UserControl
    {
        public delegate void Mydel(string s);
        public Mydel d;
        public static string em, code;
        public uclXacNhanMK(string email, string randomcode)
        {
            code = randomcode;
            em = email;
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuenMK que = new QuenMK();
            this.Hide();
            this.Parent.Controls.Add(que);
        }

        private void txtMaXN_Enter(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "Mã xác nhận")
            {
                txtMaXN.UseSystemPasswordChar = true;
                txtMaXN.Text = "";
                txtMaXN.ForeColor = Color.Black;
            }
        }

        private void txtMaXN_Leave(object sender, EventArgs e)
        {
            if (txtMaXN.Text == "")
            {
                txtMaXN.Text = "Mã xác nhận";
                txtMaXN.ForeColor = Color.Silver;
            }
        }

        private void btnGuiLaiMa_Click(object sender, EventArgs e)
        {
            d(em);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == code)
            {
                uclSetMK uclSetMK = new uclSetMK(em);
                this.Hide();
                this.Parent.Controls.Add(uclSetMK);

            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!");
            }
        }
    }
}
