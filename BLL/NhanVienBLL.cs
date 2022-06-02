using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.BLL
{
    public class NhanVienBLL
    {
        QLPT db;
        private static NhanVienBLL _Instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public NhanVienBLL()
        {
            db = new QLPT();
        }

        public List<NhanVienView> GetDSNhanVienView()
        {
            List<NhanVienView> list = new List<NhanVienView>();
            foreach (NguoiDung nguoidung in GetDSNhanVien())
            {
                list.Add(new NhanVienView
                {
                    ID = nguoidung.ID,
                    Ten = nguoidung.Ten,
                    QueQuan = nguoidung.QueQuan,
                    SDT = nguoidung.SDT,
                    CCCD = nguoidung.CCCD
                });
            }
            return list;
        }

        public List<NhanVienView> GetDSNhanVienViewByID(List<string> list)
        {
            List<NhanVienView> nhanViens = new List<NhanVienView> ();
            foreach (string i in list)
            {
                nhanViens.Add(new NhanVienView
                {
                    ID = GetNhanVienByID(i).ID,
                    Ten = GetNhanVienByID(i).Ten,
                    QueQuan = GetNhanVienByID(i).QueQuan,
                    SDT = GetNhanVienByID(i).SDT,
                    CCCD = GetNhanVienByID(i).CCCD
                });
            }
            return nhanViens; 
        }

        public void ChapNhanDSNhanVien(List<string> list)
        {
            foreach (string i in list)
            {
                ChapNhanNhanVien(i); 
            }
        }

        private void ChapNhanNhanVien(string id)
        {
            var nhanVien = db.NguoiDungs.Where(p => p.ID == id).FirstOrDefault();
            nhanVien.TrangThai = "ChoDuyet";
            db.SaveChanges();
        }

        public List<NguoiDung> GetDSNhanVien()
        {
            return db.NguoiDungs.Where(p=>p.TuCach=="NhanVien").ToList();
        }
        public NguoiDung GetNhanVienByID(string id)
        {
            return db.NguoiDungs.Find(id);
        }
        public string AddNhanVien(NguoiDung nhanvien, string iD)
        {
            if (nhanvien.ID == "")
            {
                return "requied_ID";
            }

            if (nhanvien.Ten == "")
            {
                return "requied_Ten";
            }

            if (nhanvien.SDT == "")
            {
                return "requied_SDT";
            }

            if (nhanvien.QueQuan == "")
            {
                return "requied_QueQuan";
            }

            if (nhanvien.CCCD == "")
            {
                return "requied_CCCD";
            }
            var l = db.NguoiDungs.Where(p => p.ID == nhanvien.ID).ToList();
            if (iD == "")
            {
                if (l.Count > 0)
                {
                    return "show message trung ID";
                }
                else
                {
                    db.NguoiDungs.Add(nhanvien);
                    db.SaveChanges();
                    return "added";
                }
            }
            else
            {
                var nhanVien = db.NguoiDungs.Where(p => p.ID == nhanvien.ID).FirstOrDefault();
                nhanVien.Ten = nhanvien.Ten;
                nhanVien.ID_TK = nhanvien.ID_TK;
                nhanVien.QueQuan = nhanvien.QueQuan;
                nhanVien.SDT = nhanvien.SDT;
                nhanVien.CCCD = nhanvien.CCCD;
                nhanVien.TrangThai = nhanvien.TrangThai;
                db.SaveChanges();
                return "updated";
            }
        }


        public List<NhanVienView> SearchDataNV(NhanVienView nv)
        {
            var l = db.NguoiDungs.Where(p => (p.TuCach == "NhanVien")&&(
            ((nv.Ten != "") ? p.Ten.Contains(nv.Ten):false)||
            ((nv.QueQuan != "") ? p.QueQuan.Contains(nv.QueQuan):false)||
            ((nv.SDT != "") ? p.SDT.Contains(nv.SDT):false)||
            ((nv.CCCD != "") ? p.CCCD.Contains(nv.CCCD) : false))).ToList();
            List<NhanVienView> list = new List<NhanVienView>();
            foreach (NguoiDung nguoidung in l)
            {
                list.Add(new NhanVienView
                {
                    ID = nguoidung.ID,
                    Ten = nguoidung.Ten,
                    QueQuan = nguoidung.QueQuan,
                    SDT = nguoidung.SDT,
                    CCCD = nguoidung.CCCD
                });
            }
            return list;
        }

        public void DeleteNhanVien(string id)
        {
            var nhanvien = db.NguoiDungs.Find(id);
            db.NguoiDungs.Remove(nhanvien);
            db.SaveChanges();
        }
        public List<NhanVienView> GetDSNVViewChoDuyet()
        {
            List<NhanVienView> dschoduyet = new List<NhanVienView>();
            foreach (NguoiDung nguoi in GetDSNVChoDuyet())
            {
                dschoduyet.Add(new NhanVienView
                {
                    ID = nguoi.ID,
                    Ten = nguoi.Ten,
                    QueQuan = nguoi.QueQuan,
                    SDT = nguoi.SDT,
                    CCCD = nguoi.CCCD
                });
            }
            return dschoduyet;
        }

        private List<NguoiDung> GetDSNVChoDuyet()
        {
            return db.NguoiDungs.Where(p => p.TuCach == "NhanVien" && p.TrangThai == "ChoDuyet").ToList(); 
        }
        //===========================================
    }
}
