using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.BLL
{
    public class ThongKe_NVBLL
    {
        QLPT db;
        private static ThongKe_NVBLL _Instance;
        public static ThongKe_NVBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThongKe_NVBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public List<TKLSSC> GetTKLSSCTB()
        {
            List<TKLSSC> list = new List<TKLSSC>();
            int sum = 0; 
            foreach (PhongTro pt in PhongTroBLL.Instance.GetDSPhongTro())
            {
                sum = 0; 
                foreach (ThietBi tb in pt.ThietBis)
                {
                    foreach (LichSuSuaChua lssc in tb.LichSuSuaChuas)
                    {
                        sum += lssc.SoTienSuaChua; 
                    }
                }
                list.Add(new TKLSSC
                {
                    TenPhong = pt.TenPhong,
                    TienSuaChua = sum
                });
            }
            return list; 
        }

        public int GetSoLuongPhong()
        {
            return db.PhongTros.Count(); 
        }

        public ThongKe_NVBLL()
        {
            db = new QLPT();
        }
    }
}
