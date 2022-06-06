using System;

namespace QuanLyPhongTroLinQ.DTO
{
    public class PhongTro_DatPhongView
    {
        public string IDPhong { get; set; }
        public string TenPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public DateTime? NgayThue { get; set; }
        public bool TinhTrang { get; set; }
        public int SoChuDIen { get; set; }
        public int? SoTien { get; set; }


    }
}
