using QuanLyPhongTroLinQ.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuanLyPhongTroLinQ.BLL
{
    public class LichSuSuaChuaBLL
    {
        QLPT db;
        private static LichSuSuaChuaBLL _Instance;
        public static LichSuSuaChuaBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LichSuSuaChuaBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public LichSuSuaChuaBLL()
        {
            db = new QLPT(); 
        }

        public List<string> GetThangOfLSSC(string Nam)
        {
            db = new QLPT(); 
            if (Nam == "All")
            {
                return db.LichSuSuaChuas.Select(p=>p.NgaySuaChua.Value.Month.ToString()).ToList();
            }
            else return db.LichSuSuaChuas.Where(p=>p.NgaySuaChua.Value.Year.ToString() == Nam).Select(p => p.NgaySuaChua.Value.Month.ToString()).ToList();
        }

        public List<string> GetNamOfLSSC()
        {
            db = new QLPT();
            return db.LichSuSuaChuas.Select(p => p.NgaySuaChua.Value.Year.ToString()).ToList();
        }

        public List<LichSuSuaChua> GetLSSuaChuaByPhong(string idPhong, DateTime date)
        {
            db = new QLPT();
            if (idPhong == "0")
            {
                return db.LichSuSuaChuas.Where(p => DbFunctions.TruncateTime(p.NgaySuaChua) <= date.Date).ToList();
            }
            else
            {
                return db.LichSuSuaChuas.Where(p => (DbFunctions.TruncateTime(p.NgaySuaChua) <= date.Date) && (p.IDPhong == idPhong)).ToList();
            }
        }

        public List<LichSuSuaChua> GetThongKeLSSuaChuaByPhong(string idPhong, string year, string month)
        {
            db = new QLPT();
            if (idPhong == "0")
            {
                if (year == "All")
                {
                    if (month == "All")
                    {
                        return db.LichSuSuaChuas.ToList();
                    }
                    else
                    {
                        return db.LichSuSuaChuas.Where(p=>p.NgaySuaChua.Value.Month.ToString()==month).ToList();
                    }
                }
                else
                {
                    if (month == "All")
                    {
                        return db.LichSuSuaChuas.Where(p => p.NgaySuaChua.Value.Year.ToString() == year).ToList();
                    } 
                    else
                    {
                        return db.LichSuSuaChuas.Where(p => (p.NgaySuaChua.Value.Month.ToString() == month)&&(p.NgaySuaChua.Value.Year.ToString() == year)).ToList();
                    }
                }
            }
            else
            {
                if (year == "All")
                {
                    if (month == "All")
                    {
                        return db.LichSuSuaChuas.Where(p=>p.IDPhong==idPhong).ToList();
                    }
                    else
                    {
                        return db.LichSuSuaChuas.Where(p => (p.NgaySuaChua.Value.Month.ToString() == month)&& (p.IDPhong == idPhong)).ToList();
                    }
                }
                else
                {
                    if (month == "All")
                    {
                        return db.LichSuSuaChuas.Where(p => (p.NgaySuaChua.Value.Year.ToString() == year) && (p.IDPhong == idPhong)).ToList();
                    }
                    else
                    {
                        return db.LichSuSuaChuas.Where(p => (p.NgaySuaChua.Value.Month.ToString() == month) && (p.NgaySuaChua.Value.Year.ToString() == year) && (p.IDPhong == idPhong)).ToList();
                    }
                }
            }
        }

        public LichSuSuaChua GetLSSuaChuaByID(string id)
        {
            return db.LichSuSuaChuas.Find(id);
        }

        public List<LichSuSuaChuaView> GetLSSuaChuaViewByPhong(string idPhong, DateTime date)
        {
            db = new QLPT();
            List<LichSuSuaChuaView> lichSus = new List<LichSuSuaChuaView>();
            foreach (LichSuSuaChua ls in GetLSSuaChuaByPhong(idPhong, date))
            {
                lichSus.Add(new LichSuSuaChuaView
                {
                    ID_LichSuSuaChua = ls.ID_LichSuSuaChua,
                    TenNhanVien = ls.NhanVien.Ten,
                    TenPhong = ls.ThietBi.PhongTro.TenPhong,
                    TenLoaiThietBi = ls.ThietBi.LoaiThietBi.TenLoaiThietBi,
                    NgaySuaChua = (DateTime)ls.NgaySuaChua,
                    SoTienSuaChua = ls.SoTienSuaChua
                });
            }
            return lichSus;
        }

        public List<LichSuSuaChuaView> GetThongKeLSSuaChuaViewByPhong(string idPhong, string year, string month)
        {
            db = new QLPT();
            List<LichSuSuaChuaView> lichSus = new List<LichSuSuaChuaView>();
            foreach (LichSuSuaChua ls in GetThongKeLSSuaChuaByPhong(idPhong, year, month))
            {
                lichSus.Add(new LichSuSuaChuaView
                {
                    ID_LichSuSuaChua = ls.ID_LichSuSuaChua,
                    TenNhanVien = ls.NhanVien.Ten,
                    TenPhong = ls.ThietBi.PhongTro.TenPhong,
                    TenLoaiThietBi = ls.ThietBi.LoaiThietBi.TenLoaiThietBi,
                    NgaySuaChua = (DateTime)ls.NgaySuaChua,
                    SoTienSuaChua = ls.SoTienSuaChua
                });
            }
            return lichSus;
        }

        public string AddLichSuSuaChua(LichSuSuaChua lssc, string ID)
        {
            if (lssc.ID_LichSuSuaChua == "")
            {
                return "requied_ID";
            }

            if (lssc.IDPhong == "")
            {
                return "requied_Phong";
            }

            if (lssc.ID_LoaiThietBi == "")
            {
                return "requied_ID_LoaiTB";
            }
            var l = db.LichSuSuaChuas.Where(p => p.ID_LichSuSuaChua == lssc.ID_LichSuSuaChua).ToList();
            if (ID == "")
            {
                if (l.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    db.LichSuSuaChuas.Add(lssc);
                    db.SaveChanges();
                    return "added";
                }
            }
            else
            {
                var lsscUpdate = db.LichSuSuaChuas.Where(p => p.ID_LichSuSuaChua == lssc.ID_LichSuSuaChua).FirstOrDefault();
                lsscUpdate.IDPhong = lssc.IDPhong;
                lsscUpdate.IDNhanVien = lssc.IDNhanVien;
                lsscUpdate.ID_LoaiThietBi = lssc.ID_LoaiThietBi;
                lsscUpdate.NgaySuaChua = lssc.NgaySuaChua;
                lsscUpdate.SoTienSuaChua = lssc.SoTienSuaChua;
                db.SaveChanges();
                return "updated";
            }
        }

        public void Delete(string id)
        {
            var lssc = db.LichSuSuaChuas.Find(id);
            db.LichSuSuaChuas.Remove(lssc);
            db.SaveChanges();
        }
    }
}
