using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class CBBItemLoaiPhong
    {
        public string ID { get; set; }
        public string TenLoaiPhong { get; set; }
        public override string ToString()
        {
            return TenLoaiPhong;
        }

    }
}
