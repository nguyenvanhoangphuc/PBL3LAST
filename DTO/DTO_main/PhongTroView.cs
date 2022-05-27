using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class PhongTroView
    {
        public string ID { get; set; }
        public string TenPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public string TinhTrang { get; set; }
        public int SoChuDien { get; set; }
    }
}
