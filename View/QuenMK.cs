using QuanLyPhongTroLinQ.BLL;
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace QuanLyPhongTroLinQ.View
{
    public partial class QuenMK : UserControl
    {
        private static QuenMK _Instance;
        public QuenMK()
        {
            InitializeComponent();
        }
        public static string RandomCode;
        public static string ToEmail;
        public static QuenMK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QuenMK();
                }
                return _Instance;
            }
            private set => Instance = value;
        }

        private void lblTimTK_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uclDangNhap dn = new uclDangNhap();
            this.Hide();
            this.Parent.Controls.Add(dn);

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void btnLayMaXacNhan_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string Check = TaiKhoanBLL.Instance.CheckEmail(email);
            if (Check == email)
            {
                SendEmail(txtEmail.Text);
                uclXacNhanMK uclXacNhanMK = new uclXacNhanMK(email, RandomCode);
                uclXacNhanMK.d = SendEmail;
                this.Hide();
                this.Parent.Controls.Add(uclXacNhanMK);
            }
            else if (Check == null)
            {
                lblThongBao.Text = "Tài khoản không tồn tại";
            }
            else
            {
                lblThongBao.Text = Check;
            }
        }
        public string SendEmail(string email)
        {
            string FromEmail = "p2ncteam@gmail.com";
            string PWFromEmail = "vwlhuzgohqjyuwxc";
            Random rand = new Random();
            RandomCode = (rand.Next(999999)).ToString();
            string MessageBody = $"Mã xác nhận của bạn là {RandomCode}";
            MailMessage message = new MailMessage();
            ToEmail = email;
            message.To.Add(email);
            message.From = new MailAddress(FromEmail);
            message.Body = MessageBody;
            message.Subject = "Mã xác nhận mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(FromEmail, PWFromEmail);
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
            return RandomCode;
        }

    }
}