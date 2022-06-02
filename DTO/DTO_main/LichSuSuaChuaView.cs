using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class LichSuSuaChuaView
    {
        public string ID_LichSuSuaChua { get; set; }
        public string TenNhanVien { get; set; }
        public string TenPhong { get; set; }
        public string TenLoaiThietBi { get; set; }
        public DateTime NgaySuaChua { get; set; }
        public int SoTienSuaChua { get; set; }
    }
}
