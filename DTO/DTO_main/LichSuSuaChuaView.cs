﻿using System;

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
