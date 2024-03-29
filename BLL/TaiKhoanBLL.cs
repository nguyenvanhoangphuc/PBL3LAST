﻿using QuanLyPhongTroLinQ.DTO;
using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyPhongTroLinQ.BLL
{
    public class TaiKhoanBLL
    {
        QLPT db;
        private static TaiKhoanBLL _Instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TaiKhoanBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public TaiKhoanBLL()
        {
            db = new QLPT();
        }
        public string CheckLogic(TaiKhoan obj)
        {
            if (obj.TenTK == "" || obj.TenTK == "Tên đăng nhập")
            {
                return "requied_taikhoan";
            }
            if (obj.MKhau == "" || obj.MKhau == "Mật khẩu")
            {
                return "requied_password";
            }
            var l = db.TaiKhoans.Where(p => (p.TenTK == obj.TenTK) && (p.MKhau == obj.MKhau)).Select(p => p.ID);
            if (l.Any())
            {
                return l.FirstOrDefault();
            }
            else return "null";
        }

        public NguoiDung GetNDByID(string iDNhanVien)
        {
            return db.NguoiDungs.Where(p => p.ID == iDNhanVien).FirstOrDefault();
        }

        public string CheckTuCach(string id)
        {
            return db.NguoiDungs.Where(p => p.ID == id).Select(p => p.TuCach).FirstOrDefault();
        }
        public string CheckEmail(string email)
        {
            if (email.Length < 11 || email.Substring(email.Length - 10) != "@gmail.com")
            {
                return "Email không hợp lệ";
            }
            else
            {
                return db.TaiKhoans.Where(p => p.Email == email).Select(p => p.Email).FirstOrDefault();
            }
        }
        public string SetMK(string email, string MK)
        {
            var tk = db.TaiKhoans.Where((p) => p.Email == email).FirstOrDefault();
            tk.MKhau = MK;
            db.SaveChanges();
            return "Cập nhật mật khẩu thành công!";
        }
        public bool CheckTrangThai(string id)
        {
            var check = db.NguoiDungs.Where(p => p.ID_TK == id).Select(p => p.TrangThai).FirstOrDefault();
            if (check == "ChapNhan") return true;
            return false;
        }
        public string GetNowID()
        {
            return (int.Parse(db.TaiKhoans.OrderByDescending(p => p.ID).Take(1).Select(p => p.ID).FirstOrDefault()) + 1).ToString();
        }
        public void InsertTaiKhoan_NguoiDung(TaiKhoan tk, NguoiDung nd)
        {
            db.TaiKhoans.Add(tk);
            db.NguoiDungs.Add(nd);
            db.SaveChanges();
        }
        public string CheckThongTin(TaiKhoan tk, NguoiDung nd)
        {
            if (nd.Ten == null)
            {
                return "Tên người dùng không được để trống";
            }
            else if (tk.Email == null)
            {
                return "Email không được để trống";
            }
            else if (nd.SDT == null)
            {
                return "SDT không được để trống";
            }
            else if (tk.TenTK == null)
            {
                return "Tên đăng nhập không được để trống";
            }
            else if (tk.MKhau == null)
            {
                return "Mật khẩu không được để trống";
            }
            else if (nd.CCCD == null)
            {
                return "CCCD không được để trống";
            }
            else if (nd.QueQuan == null)
            {
                return "Quê quán không được để trống";
            }
            else if (nd.TuCach == null)
            {
                return "Bạn chưa lựa chọn tư cách";
            }
            else if (tk.Email == null)
            {
                return "Email không được để trống";
            }
            else if ((db.TaiKhoans.Where(p => (p.TenTK == tk.TenTK) && (p.MKhau == tk.MKhau)).Select(p => p.ID)).Count() > 0) // check Tên đăng nhập + mật khẩu đã tồn tại chưa
                return "Tài khoản đã tồn tại";
            else //kiểm tra email hợp lệ    
            {
                string KQCheckEmail = CheckEmail(tk.Email);

                if (KQCheckEmail == "Email không hợp lệ")
                {
                    return "Email không hợp lệ";
                }
                else if (KQCheckEmail == tk.Email)
                {
                    return "Email đã tồn tại";
                }
                else if (!CheckEmailExxist(tk.Email))
                {
                    return "Email không tồn tại";
                }
            }
            return "Tài khoản hợp lệ";
        }
        private bool CheckEmailExxist(string gmail)
        //Trả về True là gmail tồn tại
        {
            bool ketqua = false;
            TcpClient tClient = new TcpClient("gmail-smtp-in.l.google.com", 25);
            string CRLF = "\r\n";
            byte[] dataBuffer;
            string ResponseString;
            NetworkStream netStream = tClient.GetStream();
            StreamReader reader = new StreamReader(netStream);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("HELO VietQuan" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("MAIL FROM:<tracdiaviet.com.vn@gmail.com>" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            dataBuffer = BytesFromString("RCPT TO:<" + gmail.Trim() + ">" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            ResponseString = reader.ReadLine();
            if (GetResponseCode(ResponseString) == 550)
            {
                ketqua = false;
            }
            else
            {
                ketqua = true;
            }
            dataBuffer = BytesFromString("QUITE" + CRLF);
            netStream.Write(dataBuffer, 0, dataBuffer.Length);
            tClient.Close();

            return ketqua;
        }
        private byte[] BytesFromString(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        private int GetResponseCode(string ResponseString)
        {
            return int.Parse(ResponseString.Substring(0, 3));
        }

        public TaiKhoan GetTKByID(string IDNhanVien)
        {
            return db.TaiKhoans.Where(p => p.ID == IDNhanVien).FirstOrDefault();
        }
        public NguoiDung GetNguoiDungDByID(string IDNhanVien)
        {
            return db.NguoiDungs.Where(p => p.ID == IDNhanVien).FirstOrDefault();
        }

        public string DoiMatKhau(string ID, string nowMK, string newMK, string retypeMK)
        {
            string CheckMK = HashPass(nowMK);
            var tk = db.TaiKhoans.Where((p) => p.ID == ID && p.MKhau == CheckMK).FirstOrDefault();
            if (tk != null)
            {
                if (newMK == "")
                {
                    return "Nhập mật khẩu mới";
                }
                else if (newMK == retypeMK)
                {
                    tk.MKhau = HashPass(newMK);
                    db.SaveChanges();
                    return "Cập nhật mật khẩu thành công";
                }
                else
                {
                    return "Mật khẩu không khớp";
                }
            }
            else
            {
                return "Mật khẩu không chính xác";
            }
        }
        public void Update(TaiKhoan tk)
        {
            var p = db.TaiKhoans.Find(tk.ID);
            p.TenTK = tk.TenTK;
            db.SaveChanges();
        }
        public string HashPass(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}