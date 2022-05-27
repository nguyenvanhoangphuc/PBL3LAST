using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;

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
            if (obj.TenTK == "")
            {
                return "requied_taikhoan";
            }

            if (obj.MKhau == "")
            {
                return "requied_password";
            }
            var l = db.TaiKhoans.Where(p => (p.TenTK == obj.TenTK) && (p.MKhau == obj.MKhau)).Select(p => p.ID);
            if (l.Any())
            {
                return db.TaiKhoans.Where(p => (p.TenTK == obj.TenTK) && (p.MKhau == obj.MKhau)).Select(p => p.ID).FirstOrDefault();
            }
            else return "null"; 
        }
        public string CheckTuCach(string id)
        {
            return db.NguoiDungs.Where(p=>p.ID == id).Select(p => p.TuCach).FirstOrDefault();
        }
    }
}
