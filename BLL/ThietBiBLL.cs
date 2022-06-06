using QuanLyPhongTroLinQ.DTO;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyPhongTroLinQ.BLL
{
    public class ThietBiBLL
    {
        QLPT db;
        private static ThietBiBLL _Instance;
        public static ThietBiBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThietBiBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public ThietBiBLL()
        {
            db = new QLPT();
        }
        public List<ThietBiView> GetThietBiViews()
        {
            List<ThietBiView> thietBiViews = new List<ThietBiView>();
            foreach (ThietBi thietBi in GetThietBis())
            {
                thietBiViews.Add(new ThietBiView
                {
                    TenPhong = new CBBItem { ID = thietBi.IDPhong, Ten = thietBi.PhongTro.TenPhong },
                    TenLoaiTB = new CBBItem { ID = thietBi.IDLoaiThietBi, Ten = thietBi.LoaiThietBi.TenLoaiThietBi },
                    TinhTrang = (thietBi.TinhTrang) ? "Hong" : "Tot"
                });
            }
            return thietBiViews;
        }

        public ThietBi GetThietBiByID(string idphong, string idloaitb)
        {
            return db.ThietBis.Where(p => (p.IDPhong == idphong) && (p.IDLoaiThietBi == idloaitb)).FirstOrDefault();
        }

        public List<CBBItem> GetAllCBBLoaiTB()
        {
            List<CBBItem> cBBItems = new List<CBBItem>();
            foreach (LoaiThietBi ltb in GetDSLoaiTB())
            {
                cBBItems.Add(new CBBItem { ID = ltb.IDLoaiThietBi, Ten = ltb.TenLoaiThietBi });
            }
            return cBBItems;
        }

        public List<CBBItem> GetCBBLoaiTBByPhong(string idPhong)
        {
            List<CBBItem> cBBItems = new List<CBBItem>();
            foreach (LoaiThietBi ltb in GetLoaiTBByPhong(idPhong))
            {
                cBBItems.Add(new CBBItem
                {
                    ID = ltb.IDLoaiThietBi,
                    Ten = ltb.TenLoaiThietBi
                });
            }
            return cBBItems;
        }

        private List<LoaiThietBi> GetLoaiTBByPhong(string idPhong)
        {
            return db.ThietBis.Where(p => p.IDPhong == idPhong).Select(p => p.LoaiThietBi).ToList();
        }

        public List<ThietBiView> SearchData(ThietBiView tb)
        {
            List<ThietBiView> thietBiViews = new List<ThietBiView>();
            var l = db.ThietBis.Where(p => ((tb.TenPhong.Ten != "") ? p.PhongTro.TenPhong.Contains(tb.TenPhong.Ten) : false) ||
            ((tb.TenLoaiTB.Ten != "") ? p.LoaiThietBi.TenLoaiThietBi.Contains(tb.TenLoaiTB.Ten) : false) ||
            ((tb.TinhTrang != "") ? (p.TinhTrang == (tb.TinhTrang == "Hong") ? true : false) : false)).ToList();
            foreach (ThietBi tbi in l)
            {
                thietBiViews.Add(new ThietBiView
                {
                    TenPhong = new CBBItem { ID = tbi.IDPhong, Ten = tbi.PhongTro.TenPhong },
                    TenLoaiTB = new CBBItem { ID = tbi.IDLoaiThietBi, Ten = tbi.LoaiThietBi.TenLoaiThietBi },
                    TinhTrang = tbi.TinhTrang ? "Hong" : "Tot"
                });
            }
            return thietBiViews;
        }

        private List<LoaiThietBi> GetDSLoaiTB()
        {
            return db.LoaiThietBis.ToList();
        }



        private List<ThietBi> GetThietBis()
        {
            return db.ThietBis.ToList();
        }

        public void UpdateTB(ThietBi tb)
        {
            var tbi = db.ThietBis.Where(p => (p.IDPhong == tb.IDPhong) && (p.IDLoaiThietBi == tb.IDLoaiThietBi)).FirstOrDefault();
            tbi.TinhTrang = tb.TinhTrang;
            db.SaveChanges();
        }
    }
}
