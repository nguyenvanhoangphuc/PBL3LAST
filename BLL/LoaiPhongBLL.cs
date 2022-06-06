using QuanLyPhongTroLinQ.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace QuanLyPhongTroLinQ.BLL
{
    public class LoaiPhongBLL
    {
        public QLPT db;
        private static LoaiPhongBLL _Instance;
        public static LoaiPhongBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiPhongBLL();
                }
                return _Instance;
            }
            private set { }
        }
        private LoaiPhongBLL()
        {
            db = new QLPT();
        }


        public List<LoaiPhong> hienthi()
        {
            List<LoaiPhong> ds = new List<LoaiPhong>();
            foreach (var i in db.LoaiPhongs.Select(p => p))
            {
                ds.Add(new LoaiPhong()
                {
                    GiaThanh = i.GiaThanh,
                    IDLoaiPhong = i.IDLoaiPhong,
                    TenLoaiPhong = i.TenLoaiPhong,

                });

            }
            return ds;
        }



        public List<LoaiThietBi_VIew> GetLoaiThietBiByLoaiPhong(string ID)
        {
            List<LoaiThietBi_VIew> ds = new List<LoaiThietBi_VIew>();
            foreach (var i in db.DanhSachIDLTBs.Where(p => p.IDLoaiPhong == ID).Select(p => p))
            {
                foreach (var j in db.LoaiThietBis.Where(p => p.IDLoaiThietBi == i.IDLoaiThietBi).Select(p => p))
                    ds.Add(new LoaiThietBi_VIew()
                    {
                        SoLuong = i.SoLuong,
                        TenLoaiTB = j.TenLoaiThietBi

                    });
            }

            return ds;
        }
        public string GetTenLoaiPhong(String id)
        {

            return db.LoaiPhongs.Where(p => p.IDLoaiPhong == id).Select(p => p).FirstOrDefault().TenLoaiPhong;

        }


    }
}


