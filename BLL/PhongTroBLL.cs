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

        public object GetAll_LTB()
        {
            throw new NotImplementedException();
        }

        public List<CBBItem> GetAll_LoaiPhongTro()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (LoaiPhong i in GetDSLoaiPhongTro())
            {
                list.Add(new CBBItem
                {
                    ID = i.IDLoaiPhong,
                    TenLoaiPhong = i.TenLoaiPhong
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
                    TinhTrang = Convert.ToString(i.TinhTrang)
                });
            }
            return list;
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
            return null;
            //return PhongTroDAL.Instance.AddPhongTro(phongTro, ID);
        }

        public static void DeletePhong(string id)
        {
            //PhongTroDAL.Instance.DeletePhong(id);
        }

        public List<PhongTroView> SearchData(PhongTroView pt)
        {
            //return PhongTroDAL.Instance.SearchData(pt);
            return null;
        }
    }
}
