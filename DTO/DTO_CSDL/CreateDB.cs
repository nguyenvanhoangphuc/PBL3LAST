using System;
using System.Data.Entity;

namespace QuanLyPhongTroLinQ.DTO
{
    public class CreateDB :
    CreateDatabaseIfNotExists<QLPT>
    //DropCreateDatabaseIfModelChanges<QLPT>
    //DropCreateDatabaseAlways<QLPT>
    {
        protected override void Seed(QLPT context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan {ID = "1", TenTK = "Phuc", MKhau ="231002"},
                new TaiKhoan {ID = "2", TenTK = "Nguyen", MKhau ="060402"},
                new TaiKhoan {ID = "3", TenTK = "Phuong", MKhau ="120202"},
                new TaiKhoan {ID = "4", TenTK = "Cuong", MKhau ="280802"},
                new TaiKhoan {ID = "5", TenTK = "Tien", MKhau ="040916"},
                new TaiKhoan {ID = "6", TenTK = "Long", MKhau ="123456"},
                new TaiKhoan {ID = "7", TenTK = "Long", MKhau ="987654"}
            });
            context.NguoiDungs.AddRange(new NguoiDung[]
            {
                new NguoiDung {ID="1", ID_TK="1", Ten ="NVHPhuc", QueQuan ="DaiLoc", SDT ="0337689694", CCCD="206436708", TrangThai ="ChapNhan",TuCach ="ChuTro"},
                new NguoiDung {ID="2", ID_TK="2", Ten ="TTNguyen", QueQuan ="CamLe", SDT ="0905050523", CCCD="207112113", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="3", ID_TK="3", Ten ="TTTPhuong", QueQuan ="BacCan", SDT ="0303040401", CCCD="209114111", TrangThai ="ChapNhan", TuCach ="ChuTro"},
                new NguoiDung {ID="4", ID_TK="4", Ten ="NCCuong", QueQuan ="TamKi", SDT ="0122852703", CCCD="208224115", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="5", ID_TK="5", Ten ="PVTieen", QueQuan ="SongNuoc", SDT ="1234656789", CCCD="777776666", TrangThai ="ChapNhan" ,TuCach ="NhanVien"},
                new NguoiDung {ID="6", ID_TK="6", Ten ="LTLong", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
                new NguoiDung {ID="7", ID_TK="7", Ten ="LTLong", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TrangThai ="ChoDuyet", TuCach ="NhanVien"}
            });

            context.LoaiPhongs.AddRange(new LoaiPhong[]
            {
                new LoaiPhong {IDLoaiPhong = "1", TenLoaiPhong = "Phòng 1 người", GiaThanh = 1000000},
                new LoaiPhong {IDLoaiPhong = "2", TenLoaiPhong = "Phòng 2 người", GiaThanh = 1700000},
                new LoaiPhong {IDLoaiPhong = "3", TenLoaiPhong = "Phòng 4 người", GiaThanh = 2500000},
                new LoaiPhong {IDLoaiPhong = "4", TenLoaiPhong = "Phòng cho cả gia đình", GiaThanh = 3800000}
            });
            context.PhongTros.AddRange(new PhongTro[]
            {
                new PhongTro {ID="1", TenPhong = "P1", ID_LoaiPhong = "1", TinhTrang = true, NgayThue = new DateTime(2022,04,01), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="2", TenPhong = "P2", ID_LoaiPhong = "2", TinhTrang = true, NgayThue = new DateTime(2022,04,01), SoChuDien = 200, TienHienTai=0},
                new PhongTro {ID="3", TenPhong = "P3", ID_LoaiPhong = "3", TinhTrang = true, NgayThue = new DateTime(2021,12,06), SoChuDien = 500, TienHienTai=0},
                new PhongTro {ID="4", TenPhong = "P4", ID_LoaiPhong = "4", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="5", TenPhong = "P5", ID_LoaiPhong = "1", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="6", TenPhong = "P6", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="7", TenPhong = "P7", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0}
            });
            context.LoaiThietBis.AddRange(new LoaiThietBi[]
            {
                new LoaiThietBi {IDLoaiThietBi="1", TenLoaiThietBi = "Giường ngủ"},
                new LoaiThietBi {IDLoaiThietBi="2", TenLoaiThietBi = "Tủ quần áo"},
                new LoaiThietBi {IDLoaiThietBi="3", TenLoaiThietBi = "Điều hoà"},
                new LoaiThietBi {IDLoaiThietBi="4", TenLoaiThietBi = "Bàn trang điểm"},
                new LoaiThietBi {IDLoaiThietBi="5", TenLoaiThietBi = "Tivi"},
                new LoaiThietBi {IDLoaiThietBi="6", TenLoaiThietBi = "Đèn"},
                new LoaiThietBi {IDLoaiThietBi="7", TenLoaiThietBi = "Quạt trần"},
                new LoaiThietBi {IDLoaiThietBi="8", TenLoaiThietBi = "Tủ bếp"},
                new LoaiThietBi {IDLoaiThietBi="9", TenLoaiThietBi = "Bộ bàn ăn"},
                new LoaiThietBi {IDLoaiThietBi="10", TenLoaiThietBi = "Sofa"},
                new LoaiThietBi {IDLoaiThietBi="11", TenLoaiThietBi = "Chậu rửa mặt"},
                new LoaiThietBi {IDLoaiThietBi="12", TenLoaiThietBi = "Gương soi"},
                new LoaiThietBi {IDLoaiThietBi="13", TenLoaiThietBi = "Vòi sen"},
                new LoaiThietBi {IDLoaiThietBi="14", TenLoaiThietBi = "Bồn cầu"},
                new LoaiThietBi {IDLoaiThietBi="15", TenLoaiThietBi = "Tủ lạnh"},
                new LoaiThietBi {IDLoaiThietBi="16", TenLoaiThietBi = "Bếp điện từ"}
            });
            context.DanhSachIDLTBs.AddRange(new DanhSachIDLTB[]
            {
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="1", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="2", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="1", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="2", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="5", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="1", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="2", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="5", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="1", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="2", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="5", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="6", SoLuong=1}
            });
            context.ThietBis.AddRange(new ThietBi[]
            {
                new ThietBi {IDPhong = "1", IDLoaiThietBi = "1", TinhTrang = false},
                new ThietBi {IDPhong = "1", IDLoaiThietBi = "2", TinhTrang = false},
                new ThietBi {IDPhong = "1", IDLoaiThietBi = "4", TinhTrang = false},
                new ThietBi {IDPhong = "2", IDLoaiThietBi = "1", TinhTrang = false},
                new ThietBi {IDPhong = "2", IDLoaiThietBi = "2", TinhTrang = false},
                new ThietBi {IDPhong = "3", IDLoaiThietBi = "3", TinhTrang = false},
                new ThietBi {IDPhong = "4", IDLoaiThietBi = "1", TinhTrang = false},
                new ThietBi {IDPhong = "4", IDLoaiThietBi = "3", TinhTrang = false}
            });
            context.NguoiThues.AddRange(new NguoiThue[]
            {
                new NguoiThue {ID ="1", HoTen = "Nguyễn Văn Hoàng Phúc", SDT ="011111222", QueQuan="Đại Lộc", CCCD="115", TinhTrang=true},
                new NguoiThue {ID ="2", HoTen = "Nguyễn Công Cường", SDT ="0333333330", QueQuan="Tam Kì", CCCD="102", TinhTrang=true},
                new NguoiThue {ID ="3", HoTen = "Trần Thanh Nguyên", SDT ="0444444444", QueQuan="Cẩm Lệ", CCCD="1234", TinhTrang=true},
                new NguoiThue {ID ="4", HoTen = "Trần Thị Thu Phượng", SDT ="0555555555", QueQuan="TT Huế", CCCD="465256", TinhTrang=true}
            });
            context.QLDatPhongs.AddRange(new QLDatPhong[]
            {
                new QLDatPhong { ID_NguoiThue = "1", ID_Phong="1"},
                new QLDatPhong { ID_NguoiThue = "2", ID_Phong="2"},
                new QLDatPhong { ID_NguoiThue = "3", ID_Phong="3"}
            });
            context.LichSuSuaChuas.AddRange(new LichSuSuaChua[]
            {
                new LichSuSuaChua {ID_LichSuSuaChua= "1", IDNhanVien="2", IDPhong="1", ID_LoaiThietBi="1", NgaySuaChua = new DateTime(2022,5,10), SoTienSuaChua =50000},
                new LichSuSuaChua {ID_LichSuSuaChua= "2", IDNhanVien="4", IDPhong="2", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "3", IDNhanVien="5", IDPhong="3", ID_LoaiThietBi="3", NgaySuaChua = new DateTime(2021,02,03), SoTienSuaChua =40000}
            });
            context.TienThangs.AddRange(new TienThang[]
            {
                new TienThang {ID= "1", ID_Phong= "1", NgayThu= new DateTime(2022,04,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "2", ID_Phong= "1", NgayThu= new DateTime(2022,06,18), TienPhong= 1000000, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= false}
                //new TienThang {ID= "2", ID_Phong= "2", NgayThu= new DateTime(2022,05,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false}
            });
        }
    }
}
