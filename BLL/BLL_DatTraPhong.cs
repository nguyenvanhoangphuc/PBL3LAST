using QuanLyPhongTroLinQ.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyPhongTroLinQ.BLL
{
    public class BLL_DatTraPhong
    {
        public QLPT db;
        private static BLL_DatTraPhong _Instance;

        public static BLL_DatTraPhong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DatTraPhong();
                }
                return _Instance;
            }
            private set { }

        }
        private BLL_DatTraPhong()
        {
            db = new QLPT();

        }
        public List<NguoiThue> GetNguoiChuaThueBySDT(string s)
        {
            List<NguoiThue> ds = new List<NguoiThue>();
            foreach (NguoiThue i in db.NguoiThues.Where(p => (p.TinhTrang == false) && ((s == "") ? true : p.SDT.Contains(s))))
            {
                ds.Add(new NguoiThue()
                {
                    ID = i.ID,
                    CCCD = i.CCCD,
                    HoTen = i.HoTen,
                    QueQuan = i.QueQuan,
                    SDT = i.SDT,
                    TinhTrang = i.TinhTrang
                });
            };
            return ds;
        }

        public List<NguoiThue> GetNguoiChuaThueVaLoaiTru(string s, string SDT)
        {
            List<NguoiThue> ds = new List<NguoiThue>();
            foreach (NguoiThue i in GetNguoiChuaThueBySDT(s))
            {
                if (i.SDT != SDT) ds.Add(new NguoiThue()
                {
                    ID = i.ID,
                    CCCD = i.CCCD,
                    HoTen = i.HoTen,
                    QueQuan = i.QueQuan,
                    SDT = i.SDT,
                    TinhTrang = i.TinhTrang
                });
            }
            return ds;
        }

        public List<PhongTro_DatPhongView> GetPhongTroViewByLoaiPhong(string id)
        {
            db = new QLPT(); 
            List<PhongTro_DatPhongView> ds = new List<PhongTro_DatPhongView>();
            foreach (PhongTro i in db.PhongTros.Where(p => p.LoaiPhong.IDLoaiPhong == id).Select(p => p))
            {
                ds.Add(new PhongTro_DatPhongView()
                {
                    IDPhong = i.ID,
                    TenPhong = i.TenPhong,
                    NgayThue = i.NgayThue,
                    TenLoaiPhong = db.LoaiPhongs.Find(id).TenLoaiPhong,
                    SoChuDIen = i.SoChuDien,
                    TinhTrang = i.TinhTrang,
                    SoTien = i.TienHienTai
                });

            }
            return ds;
        }
        public List<CBBItemLoaiPhong> GetCBBItemLoaiPhong()
        {
            List<CBBItemLoaiPhong> ds = new List<CBBItemLoaiPhong>();

            foreach (LoaiPhong i in db.LoaiPhongs.Select(p => p))
            {
                ds.Add(
                    new CBBItemLoaiPhong()
                    {
                        ID = i.IDLoaiPhong,
                        TenLoaiPhong = i.TenLoaiPhong

                    }
                    );
            }
            return ds;
        }
        public void DatPhong(List<NguoiThue> a, string id_phong)
        {

            foreach (NguoiThue i in a)
            {
                using (QLPT db = new QLPT())
                {
                    var j = db.NguoiThues.Where(p => p.ID == i.ID).FirstOrDefault();
                    j.TinhTrang = true;
                    db.SaveChanges();
                }
            }
            using (QLPT db = new QLPT())
            {
                var j1 = db.PhongTros.Where(p => p.ID == id_phong).FirstOrDefault();
                j1.TinhTrang = true;
                j1.NgayThue = DateTime.Now;
                db.SaveChanges();
            }

            foreach (NguoiThue i in a)
            {
                using (QLPT db = new QLPT())
                {
                    db.QLDatPhongs.Add(new QLDatPhong()
                    {
                        ID_NguoiThue = i.ID,
                        ID_Phong = id_phong
                    });
                    db.SaveChanges();
                }
            }

        }

        public void TraPhong(string idphong)
        {
            // khi trả phòng với idphong thì ta sẽ
            // xoá hết các QLdatphong của idphongdo
            // chuyển người thuê về tình trạng chưa thuê
            // chuyển phòng về tình trạng còn trống, chưa cho thuê

            foreach (QLDatPhong qLDatPhong in db.PhongTros.Find(idphong).QLDatPhongs)
            {
                using (QLPT db = new QLPT())
                {
                    var nguoiThue = db.NguoiThues.Find(qLDatPhong.ID_NguoiThue);
                    nguoiThue.TinhTrang = false;
                    db.SaveChanges();
                }
            }
            using (QLPT db = new QLPT())
            {
                db.QLDatPhongs.RemoveRange(db.PhongTros.Find(idphong).QLDatPhongs);
                db.SaveChanges();
            }
            using (QLPT db = new QLPT())
            {
                var j = db.PhongTros.Find(idphong);
                j.TinhTrang = false;
                j.NgayThue = null;
                db.SaveChanges();
            }
        }


        public List<NguoiThue> GetNguoiThueTrongPhongTro(string name)
        {
            string id = null;
            List<NguoiThue> ds = new List<NguoiThue>();
            foreach (PhongTro i in db.PhongTros.Select(p => p))
            {
                if (i.TenPhong == name)
                {
                    id = i.ID;
                    break;
                }

            }

            foreach (QLDatPhong j in db.QLDatPhongs.Select(p => p))
            {
                if (j.ID_Phong == id) //console.writeline("'" + j.sdt + "'");
                    foreach (NguoiThue i in db.NguoiThues.Where(p => p.ID == j.ID_NguoiThue))
                    {
                        ds.Add(new NguoiThue()
                        {
                            ID = i.ID,
                            CCCD = i.CCCD,
                            HoTen = i.HoTen,
                            QueQuan = i.QueQuan,
                            SDT = i.SDT,
                            TinhTrang = i.TinhTrang

                        });
                    }

            }
            return ds;


        }
        public void TraPhongWithTenPhong(string ten)
        {
            foreach (PhongTro i in db.PhongTros.Select(p => p))
            {
                if (i.TenPhong == ten) TraPhong(i.ID);
            }
        }

    }
}
