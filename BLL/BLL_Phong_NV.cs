using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTroLinQ.DTO;
namespace QuanLyPhongTroLinQ.BLL
{
    public class BLL_Phong_NV
    {   public QLPT db;
        private static BLL_Phong_NV _Instance;

        public static BLL_Phong_NV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Phong_NV();
                    
                }
                return _Instance;
            }
            private set { }

        }
        private BLL_Phong_NV()
        {
            db = new QLPT();
        }
        public List<ThietBi> GetThietBiByIDPhong(string ID)
        { List<ThietBi> ds = new List<ThietBi>();
            foreach (var i in db.ThietBis.Where(p => p.IDPhong == ID).Select(p => p)) {
                ds.Add(new ThietBi()
                {
                    IDLoaiThietBi = i.IDLoaiThietBi,
                    IDPhong = i.IDPhong,
                    TinhTrang = i.TinhTrang
                });
            
            }
            return ds; 

        }
    }
}
