using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.BLL
{
    public class ThongKe_ADBLL
    {
        QLPT db;
        public int Total = 0;

        private static ThongKe_ADBLL _Instance;
        public static ThongKe_ADBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThongKe_ADBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public ThongKe_ADBLL()
        {
            db = new QLPT(); 
        }

        public List<string> GetAllYear()
        {
            return db.TienThangs.OrderBy(x => x.NgayThu).Where(x => x.TienPhong != 0).Select(x => x.NgayThu.Year.ToString()).Distinct().ToList();
                
        }

        public int GetSoNhanVien()
        {
            return db.NguoiDungs.Where(x=>x.TuCach=="NhanVien").Count();
        }
     
        public int GetSoNguoiThue()
        {
            return db.NguoiThues.Count();
        }

        public int GetSoPhongTro()
        {
            return db.PhongTros.Count();
        }

        public List<string> GetAllMonth(string nam="All")
        {
            var list= db.TienThangs.Where(x=>(x.NgayThu.Year.ToString() == nam || nam=="All") && x.TienPhong!=0).Select(x=>x.NgayThu.Month).Distinct().ToList();
            List<string> result= new List<string>();    
            
            for(int i=1; i<=12; i++)
                foreach(int thang in list)
                    if (i==thang) result.Add(thang.ToString());
            return result;
        }

        public DataTable GetDSThongKe(string nam, string thang)
        {
            DataTable dt= new DataTable();

            dt.Columns.AddRange(new DataColumn[] {

                new DataColumn("ID"),
                new DataColumn("Ngày thu tiền"),
                new DataColumn("Tên Phòng"),
                new DataColumn("Tổng tiền"),

            });

            Total = 0;
            foreach(TienThang sau in db.TienThangs.OrderBy(x=>x.ID_Phong).Where(x=>(x.NgayThu.Year.ToString()==nam || nam=="All") && (x.NgayThu.Month.ToString() == thang || thang=="All") && x.TienPhong != 0 && x.DaNop == true))
            {
                TienThang truoc = db.TienThangs.OrderByDescending(x => x.NgayThu).Where(x => x.NgayThu < sau.NgayThu && x.ID_Phong == sau.ID_Phong).FirstOrDefault();

                int TienDien = (sau.ChuDien - truoc.ChuDien) * sau.TienMotChuDien;
                int TienNuoc = (sau.ChuNuoc - truoc.ChuNuoc) * sau.TienMotChuNuoc;
                int TienSCTB = TraTienBLL.Instance.GetTienSuaChuaTB(sau.ID_Phong, sau.NgayThu)- TraTienBLL.Instance.GetTienSuaChuaTB(truoc.ID_Phong, truoc.NgayThu);
                int TongTien= sau.TienPhong + TienDien + TienNuoc + TienSCTB;
                Total += TongTien;

                dt.Rows.Add(sau.ID, sau.NgayThu.ToString("d"), ThongKe_ADBLL.Instance.GetTenPhong(sau.ID_Phong), TongTien);
            } 
                
            return dt;
        }

        public string GetTenPhong(string iD_Phong)
        {
            return db.PhongTros.Find(iD_Phong).TenPhong;
        }

        public int GetTienByNamThang(string nam, string thang)
        {
            return 0;
        }
    }
}
