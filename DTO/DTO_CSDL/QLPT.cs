using System.Data.Entity;

namespace QuanLyPhongTroLinQ.DTO
{
    public class QLPT : DbContext
    {
        public QLPT()
            : base("name=QLPT11")
        {
            Database.SetInitializer<QLPT>(new CreateDB());
        }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<PhongTro> PhongTros { get; set; }
        public virtual DbSet<DanhSachIDLTB> DanhSachIDLTBs { get; set; }
        public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<QLDatPhong> QLDatPhongs { get; set; }
        public virtual DbSet<NguoiThue> NguoiThues { get; set; }
        public virtual DbSet<LichSuSuaChua> LichSuSuaChuas { get; set; }
        public virtual DbSet<TienThang> TienThangs { get; set; }

    }
}