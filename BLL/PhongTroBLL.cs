using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.BLL
{
    public class PhongTroBLL
    {
        QLPT db;
        private static PhongTroBLL _Instance;
        public static PhongTroBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhongTroBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public PhongTroBLL()
        {
            db = new QLPT();
        }
        public List<CBBItem> GetCBBLoaiPhongTro()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (LoaiPhong i in GetDSLoaiPhongTro())
            {
                list.Add(new CBBItem
                {
                    ID = i.IDLoaiPhong,
                    Ten = i.TenLoaiPhong
                });
            }
            return list;
        }
        public List<PhongTroView> GetDSPhongTroView()
        {
            List<PhongTroView> list = new List<PhongTroView>();
            foreach (PhongTro i in GetDSPhongTro())
            {
                list.Add(new PhongTroView
                {
                    ID = i.ID,
                    TenPhong = i.TenPhong,
                    TenLoaiPhong = i.LoaiPhong.TenLoaiPhong,
                    TinhTrang = Convert.ToString(i.TinhTrang),
                    SoChuDien = i.SoChuDien
                });
            }
            return list;
        }
        private List<LoaiPhong> GetDSLoaiPhongTro()
        {
            return db.LoaiPhongs.ToList();
        }
        public List<PhongTro> GetDSPhongTro()
        {
            return db.PhongTros.ToList();
        }
        public PhongTro GetPhongByID(string id)
        {
            return db.PhongTros.Where(p => p.ID == id).FirstOrDefault();
        }
        public LoaiPhong GetLoaiPhongByID(string iD_LoaiPhong)
        {
            return db.LoaiPhongs.Where(p=>p.IDLoaiPhong==iD_LoaiPhong).FirstOrDefault();
        }
        public string AddPhongTro(PhongTro phongTro, string ID)
        {
            if (phongTro.ID == "")
            {
                return "requied_ID";
            }

            if (phongTro.TenPhong == "")
            {
                return "requied_TenPhong";
            }

            if (phongTro.ID_LoaiPhong == "")
            {
                return "requied_ID_LoaiPhong";
            }
            var l = db.PhongTros.Where(p => p.ID == phongTro.ID).ToList();
            if (ID == "")
            {
                if (l.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    db.PhongTros.Add(phongTro);
                    db.SaveChanges();
                    return "added";
                }
            }
            else
            {
                var phongtro = db.PhongTros.Where(p => p.ID == phongTro.ID).FirstOrDefault();
                phongtro.TenPhong = phongTro.TenPhong;
                phongtro.ID_LoaiPhong = phongTro.ID_LoaiPhong;
                phongtro.TinhTrang = phongTro.TinhTrang;
                phongtro.SoChuDien = phongTro.SoChuDien;
                db.SaveChanges();
                return "updated";
            }
        }
        public void DeletePhong(string id)
        {
            var s = db.PhongTros.Find(id);
            db.PhongTros.Remove(s);
            db.SaveChanges(); 
        }
        public List<PhongTroView> SearchData(PhongTroView pt)
        {
            bool tt=false, kt=false;
            if (pt.TinhTrang.ToLower() == "true" || pt.TinhTrang.ToLower() == "false")
            {
                tt = Convert.ToBoolean(pt.TinhTrang);
                kt = true;
            }
            var l = db.PhongTros.Where(p => ((pt.ID!="")?p.ID.Contains(pt.ID):false)||
            ((pt.TenPhong!= "") ? p.TenPhong.Contains(pt.TenPhong):false)||
            ((pt.TenLoaiPhong!="")?p.LoaiPhong.TenLoaiPhong.Contains(pt.TenLoaiPhong):false)||
            ((kt!=false)?(p.TinhTrang==tt):false)).ToList();
            List<PhongTroView> list = new List<PhongTroView>();
            foreach (PhongTro i in l)
            {
                list.Add(new PhongTroView
                {
                    ID = i.ID,
                    TenPhong = i.TenPhong,
                    TenLoaiPhong = i.LoaiPhong.TenLoaiPhong,
                    TinhTrang = Convert.ToString(i.TinhTrang),
                    SoChuDien = i.SoChuDien
                });
            }
            return list;
        }
        //============================================

        public object GetAll_LTB()
        {
            throw new NotImplementedException();
        }

        

        





        

        

        
    }
}
