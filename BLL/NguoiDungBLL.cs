using QuanLyPhongTroLinQ.DTO;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyPhongTroLinQ.BLL
{
    public class NguoiDungBLL
    {
        QLPT db;
        private static NguoiDungBLL _Instance;
        public static NguoiDungBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoiDungBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public NguoiDungBLL()
        {
            db = new QLPT();
        }
        public List<NguoiDungView> GetNguoiDungViews()
        {
            List<NguoiDungView> nguoiDungViews = new List<NguoiDungView>();
            foreach (NguoiDung nguoiDung in GetNguoiDungs())
            {
                nguoiDungViews.Add(new NguoiDungView
                {
                    ID = nguoiDung.ID,
                    Ten = nguoiDung.Ten,
                    QueQuan = nguoiDung.QueQuan,
                    SDT = nguoiDung.SDT,
                    CCCD = nguoiDung.CCCD,
                    TuCach = nguoiDung.TuCach
                });
            }
            return nguoiDungViews;
        }

        private List<NguoiDung> GetNguoiDungs()
        {
            return db.NguoiDungs.ToList();
        }
    }
}
