using System;
using System.Data.Entity;

namespace QuanLyPhongTroLinQ.DTO
{
    public class CreateDB :
    DropCreateDatabaseIfModelChanges<QLPT>
    //DropCreateDatabaseAlways<QLPT>
    {
        protected override void Seed(QLPT context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan {ID = "1", TenTK = "Phuc", MKhau ="W7xAd7bjo+iK7jSmkomLh7LLDKA=", Email="phucknguyen123456789@gmail.com"},
                new TaiKhoan {ID = "2", TenTK = "Nguyen", MKhau ="sF/RVM1Zc/AzaNEsJP7pIMY4Wog=", Email="trannguyen.06042002@gmail.com"},
                new TaiKhoan {ID = "3", TenTK = "Phuong", MKhau ="sodnj7qpXuxwi9T+KsTbksdOzgw=",Email= "tttp2002@gmail.com"},
                new TaiKhoan {ID = "4", TenTK = "Cuong", MKhau ="EtWKyScBk62SdLPLTKSQZ4skZaw=", Email= "cuongtk2002gmail.com"},
                new TaiKhoan {ID = "5", TenTK = "Tien", MKhau ="dByzKqgtHxB97Xt7i0Y5AUGMpAI=", Email="tien123@gmail.com"},
                new TaiKhoan {ID = "6", TenTK = "Long", MKhau ="fEqNCco3Yq9h5ZUglD3CZJT4lBs=", Email="long123@gmail.com"},
                new TaiKhoan {ID = "7", TenTK = "Long", MKhau ="3qdC4WaXkCeucLKOCpAG+xAQ52A=", Email="long2123@gmail.com"},
                new TaiKhoan {ID = "8", TenTK = "Anh", MKhau ="PU8r8H3BvjiyDNbkaUmhBx+dDj0=", Email="long123@gmail.com"}, //111111
                new TaiKhoan {ID = "9", TenTK = "Nhung", MKhau ="JzoMe9PGebqab12ZB4426F0CuVI", Email="long21234@gmail.com"},
                new TaiKhoan {ID = "10", TenTK = "Huong", MKhau ="d7zp+xj5d+pXa7zRQ7K1IQc/DNY=", Email="long1235@gmail.com"},
                new TaiKhoan {ID = "11", TenTK = "Hung", MKhau ="Qs/oVJE1lP5XLLlxKhiOgpgwKR8=", Email="long21236@gmail.com"},
                new TaiKhoan {ID = "12", TenTK = "Minh", MKhau ="t8QLnGa8iNOKWeVUxjnXQ+d/G2U=", Email="long1237@gmail.com"},
                new TaiKhoan {ID = "13", TenTK = "Tuyet", MKhau ="FBFnigueJe4vfIsveskranSz+cU=", Email="long21238@gmail.com"},
                new TaiKhoan {ID = "14", TenTK = "Hoang", MKhau ="+6nxya4qiv54FcnN1JJRJiKmYwI=", Email="long1239@gmail.com"},
                new TaiKhoan {ID = "15", TenTK = "Quy", MKhau ="H4LJQr79optu1IelHaGZ94/OfwU=", Email="long212310@gmail.com"}
            });
            context.NguoiDungs.AddRange(new NguoiDung[]
            {
                new NguoiDung {ID="1", ID_TK="1", Ten ="Nguyễn Văn Hoàng Phúc", QueQuan ="Đại Lộc", SDT ="0337689694", CCCD="206436708", TrangThai ="ChapNhan",TuCach ="ChuTro"},
                new NguoiDung {ID="2", ID_TK="2", Ten ="Trần Thanh Nguyên", QueQuan ="Cẩm Lệ", SDT ="0905050523", CCCD="207112113", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="3", ID_TK="3", Ten ="Trần Thị Thu Phượng", QueQuan ="Bắc Cạn", SDT ="0303040401", CCCD="209114111", TrangThai ="ChapNhan", TuCach ="ChuTro"},
                new NguoiDung {ID="4", ID_TK="4", Ten ="Nguyễn Công Cường", QueQuan ="Tam Kì", SDT ="0122852703", CCCD="208224115", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="5", ID_TK="5", Ten ="Phạm Văn Tiến", QueQuan ="Sông Nước", SDT ="1234656789", CCCD="777776666", TrangThai ="ChapNhan" ,TuCach ="NhanVien"},
                new NguoiDung {ID="6", ID_TK="6", Ten ="Lê Thành Long", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
                new NguoiDung {ID="7", ID_TK="7", Ten ="Lê Thành Long", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
                new NguoiDung {ID="8", ID_TK="8", Ten ="Nguyễn Tiến Anh", QueQuan ="Đại Lộc", SDT ="0337689694", CCCD="121121212", TrangThai ="ChapNhan",TuCach ="ChuTro"},
                new NguoiDung {ID="9", ID_TK="9", Ten ="Lê Hồng Nhung", QueQuan ="Cẩm Lệ", SDT ="0905050523", CCCD="123412154", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="10", ID_TK="10", Ten ="Phạm Hương", QueQuan ="Bắc Cạn", SDT ="0303040401", CCCD="422452154", TrangThai ="ChapNhan", TuCach ="ChuTro"},
                new NguoiDung {ID="11", ID_TK="11", Ten ="Nguyễn Đại Hùng", QueQuan ="Tam Kì", SDT ="0122852703", CCCD="123546215", TrangThai ="ChapNhan", TuCach ="NhanVien"},
                new NguoiDung {ID="12", ID_TK="12", Ten ="Hoàng Nhật Minh", QueQuan ="Sông Nước", SDT ="1234656789", CCCD="012023244", TrangThai ="ChapNhan" ,TuCach ="NhanVien"},
                new NguoiDung {ID="13", ID_TK="13", Ten ="Nguyễn Thị Ánh Tuyết", QueQuan ="Hà Nội", SDT ="0123456987", CCCD="144525412", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
                new NguoiDung {ID="14", ID_TK="14", Ten ="Lê Văn Hoàng", QueQuan ="HongKong", SDT ="0123456987", CCCD="846585325", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
                new NguoiDung {ID="15", ID_TK="15", Ten ="Ngô Quý", QueQuan ="Tiền Giang", SDT ="0123456987", CCCD="542154223", TrangThai ="ChoDuyet", TuCach ="NhanVien"},
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
                new PhongTro {ID="1", TenPhong = "P1", ID_LoaiPhong = "1", TinhTrang = true, NgayThue = new DateTime(2021,09,18), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="2", TenPhong = "P2", ID_LoaiPhong = "2", TinhTrang = true, NgayThue = new DateTime(2020,08,12), SoChuDien = 200, TienHienTai=0},
                new PhongTro {ID="3", TenPhong = "P3", ID_LoaiPhong = "3", TinhTrang = true, NgayThue = new DateTime(2021,12,06), SoChuDien = 500, TienHienTai=0},
                new PhongTro {ID="4", TenPhong = "P4", ID_LoaiPhong = "4", TinhTrang = true, NgayThue = new DateTime(2022,02,11), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="5", TenPhong = "P5", ID_LoaiPhong = "1", TinhTrang = true, NgayThue = new DateTime(2021, 04, 12), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="6", TenPhong = "P6", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="7", TenPhong = "P7", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="8", TenPhong = "P8", ID_LoaiPhong = "1", TinhTrang = true, NgayThue = new DateTime(2021,01,18), SoChuDien = 300, TienHienTai=0},
                new PhongTro {ID="9", TenPhong = "P9", ID_LoaiPhong = "2", TinhTrang = true, NgayThue = new DateTime(2021,03,12), SoChuDien = 400, TienHienTai=0},
                new PhongTro {ID="10", TenPhong = "P10", ID_LoaiPhong = "3", TinhTrang = true, NgayThue = new DateTime(2021,05,06), SoChuDien = 600, TienHienTai=0},
                new PhongTro {ID="11", TenPhong = "P11", ID_LoaiPhong = "4", TinhTrang = true, NgayThue = new DateTime(2020, 07, 11), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="12", TenPhong = "P12", ID_LoaiPhong = "1", TinhTrang = true, NgayThue = new DateTime(2020, 12, 12), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="13", TenPhong = "P13", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0},
                new PhongTro {ID="14", TenPhong = "P14", ID_LoaiPhong = "2", TinhTrang = false, NgayThue = new DateTime(), SoChuDien = 100, TienHienTai=0}
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
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="5", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="13", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="14", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="1", IDLoaiThietBi="11", SoLuong=1},

                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="1", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="2", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="5", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="7", SoLuong=3},
                new DanhSachIDLTB {IDLoaiPhong ="2", IDLoaiThietBi="12", SoLuong=2},

                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="1", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="2", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="5", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="9", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="3", IDLoaiThietBi="10", SoLuong=1},

                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="1", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="2", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="3", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="4", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="5", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="6", SoLuong=1},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="7", SoLuong=2},
                new DanhSachIDLTB {IDLoaiPhong ="4", IDLoaiThietBi="11", SoLuong=1},

            });
            context.ThietBis.AddRange(new ThietBi[]
            {
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="1", TinhTrang=false},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="2", TinhTrang=true},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="3", TinhTrang=true},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="4", TinhTrang=true},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="5", TinhTrang=false},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="13", TinhTrang=false},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="14", TinhTrang=true},
                new ThietBi {IDPhong ="1", IDLoaiThietBi ="11", TinhTrang=false},

                new ThietBi {IDPhong ="2", IDLoaiThietBi="1",TinhTrang=true},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="2",TinhTrang=false},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="3",TinhTrang=true},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="4",TinhTrang=false},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="5",TinhTrang=true},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="7",TinhTrang=false},
                new ThietBi {IDPhong ="2", IDLoaiThietBi="12",TinhTrang=false},

                new ThietBi {IDPhong ="3", IDLoaiThietBi="9", TinhTrang=true},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="1", TinhTrang=false},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="5", TinhTrang=false},
                new ThietBi {IDPhong ="3", IDLoaiThietBi="10", TinhTrang=true},

                new ThietBi {IDPhong ="4", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="6", TinhTrang=false},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="7", TinhTrang=true},
                new ThietBi {IDPhong ="4", IDLoaiThietBi="11", TinhTrang=true},

                new ThietBi {IDPhong ="5", IDLoaiThietBi="1", TinhTrang=false},
                new ThietBi {IDPhong ="5", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi {IDPhong ="5", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi {IDPhong ="5", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi {IDPhong ="5", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi {IDPhong ="5", IDLoaiThietBi="13", TinhTrang=true},
                new ThietBi  {IDPhong ="5", IDLoaiThietBi="11", TinhTrang=false},
                new ThietBi  {IDPhong ="5", IDLoaiThietBi="14", TinhTrang=false},

                new ThietBi  {IDPhong ="6", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="2", TinhTrang=false},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="5", TinhTrang=false},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="7", TinhTrang=true},
                new ThietBi  {IDPhong ="6", IDLoaiThietBi="12", TinhTrang=false},

                new ThietBi  {IDPhong ="7", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="7", TinhTrang=false},
                new ThietBi  {IDPhong ="7", IDLoaiThietBi="12", TinhTrang=true},

                new ThietBi  {IDPhong ="8", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="2", TinhTrang=false},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="13", TinhTrang=false},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="11", TinhTrang=true},
                new ThietBi  {IDPhong ="8", IDLoaiThietBi="14", TinhTrang=false},

                new ThietBi  {IDPhong ="9", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="7", TinhTrang=true},
                new ThietBi  {IDPhong ="9", IDLoaiThietBi="12", TinhTrang=false},

                new ThietBi  {IDPhong ="10", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="9", TinhTrang=true},
                new ThietBi  {IDPhong ="10", IDLoaiThietBi="10", TinhTrang=true},

                new ThietBi  {IDPhong ="11", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="4", TinhTrang=false},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="6", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="7", TinhTrang=true},
                new ThietBi  {IDPhong ="11", IDLoaiThietBi="11", TinhTrang=false},

                new ThietBi  {IDPhong ="12", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="3", TinhTrang=false},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="13", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="11", TinhTrang=true},
                new ThietBi  {IDPhong ="12", IDLoaiThietBi="14", TinhTrang=false},

                new ThietBi  {IDPhong ="13", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="2", TinhTrang=true},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="5", TinhTrang=false},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="7", TinhTrang=true},
                new ThietBi  {IDPhong ="13", IDLoaiThietBi="12", TinhTrang=false},

                new ThietBi  {IDPhong ="14", IDLoaiThietBi="1", TinhTrang=true},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="2", TinhTrang=false},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="3", TinhTrang=true},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="4", TinhTrang=true},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="5", TinhTrang=true},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="7",  TinhTrang=true},
                new ThietBi  {IDPhong ="14", IDLoaiThietBi="12", TinhTrang=true}


            });
            context.NguoiThues.AddRange(new NguoiThue[]
            {
                new NguoiThue {ID ="1", HoTen = "Nguyễn Văn Hoàng Phúc", SDT ="011111222", QueQuan="Đại Lộc", CCCD="115", TinhTrang=true},
                new NguoiThue {ID ="2", HoTen = "Nguyễn Công Cường", SDT ="0333333330", QueQuan="Tam Kì", CCCD="102", TinhTrang=true},
                new NguoiThue {ID ="3", HoTen = "Trần Thanh Nguyên", SDT ="0444444444", QueQuan="Cẩm Lệ", CCCD="1234", TinhTrang=true},
                new NguoiThue {ID ="4", HoTen = "Trần Thị Thu Phượng", SDT ="0555555555", QueQuan="TT Huế", CCCD="465256", TinhTrang=true},
                new NguoiThue {ID="5",  HoTen ="Phạm Văn Tiến", QueQuan ="Sông Nước", SDT ="1234656789", CCCD="777776666", TinhTrang =true },
                new NguoiThue {ID="6",  HoTen ="Lê Thành Long", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TinhTrang =false },
                new NguoiThue {ID="7",    HoTen ="Lê Thành Long", QueQuan ="HongKong", SDT ="0123456987", CCCD="145234657", TinhTrang =false },
                new NguoiThue {ID="8",    HoTen ="Nguyễn Tiến Anh", QueQuan ="Đại Lộc", SDT ="0337689694", CCCD="121121212", TinhTrang =true  },
                new NguoiThue {ID="9",    HoTen ="Lê Hồng Nhung", QueQuan ="Cẩm Lệ", SDT ="0905050523", CCCD="123412154", TinhTrang =true },
                new NguoiThue {ID="10",    HoTen ="Phạm Hương", QueQuan ="Bắc Cạn", SDT ="0303040401", CCCD="422452154", TinhTrang =true},
                new NguoiThue {ID="11",    HoTen ="Nguyễn Đại Hùng", QueQuan ="Tam Kì", SDT ="0122852703", CCCD="123546215", TinhTrang =true },
                new NguoiThue {ID="12",    HoTen ="Hoàng Nhật Minh", QueQuan ="Sông Nước", SDT ="1234656789", CCCD="012023244", TinhTrang =true },
                new NguoiThue {ID="13",    HoTen ="Nguyễn Thị Ánh Tuyết", QueQuan ="Hà Nội", SDT ="0123456987", CCCD="144525412", TinhTrang =false },
                new NguoiThue {ID="14",    HoTen ="Lê Văn Hoàng", QueQuan ="HongKong", SDT ="0123456987", CCCD="846585325", TinhTrang =false },
                new NguoiThue {ID="15",    HoTen ="Ngô Quý", QueQuan ="Tiền Giang", SDT ="0123456987", CCCD="542154223", TinhTrang =false }

            });
            context.QLDatPhongs.AddRange(new QLDatPhong[]
            {
                new QLDatPhong { ID_NguoiThue = "1", ID_Phong="1"},
                new QLDatPhong { ID_NguoiThue = "2", ID_Phong="2"},
                new QLDatPhong { ID_NguoiThue = "4", ID_Phong="4"},
                new QLDatPhong { ID_NguoiThue = "5", ID_Phong="5"},

                new QLDatPhong { ID_NguoiThue = "8", ID_Phong="8"},
                new QLDatPhong { ID_NguoiThue = "9", ID_Phong="9"},
                new QLDatPhong { ID_NguoiThue = "10", ID_Phong="10"},
                new QLDatPhong { ID_NguoiThue = "11", ID_Phong="11"},
                new QLDatPhong { ID_NguoiThue = "12", ID_Phong="12"},
                new QLDatPhong { ID_NguoiThue = "3", ID_Phong="3"}
            });
            context.LichSuSuaChuas.AddRange(new LichSuSuaChua[]
            {
                new LichSuSuaChua {ID_LichSuSuaChua= "1", IDNhanVien="4", IDPhong="1", ID_LoaiThietBi="1", NgaySuaChua = new DateTime(2022,10,10), SoTienSuaChua =50000},
                new LichSuSuaChua {ID_LichSuSuaChua= "2", IDNhanVien="4", IDPhong="1", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,12,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "3", IDNhanVien="4", IDPhong="2", ID_LoaiThietBi="3", NgaySuaChua = new DateTime(2022,09,15), SoTienSuaChua =30000},
                new LichSuSuaChua {ID_LichSuSuaChua= "4", IDNhanVien="4", IDPhong="4", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,06,15), SoTienSuaChua =60000},
                new LichSuSuaChua {ID_LichSuSuaChua= "5", IDNhanVien="4", IDPhong="5", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "6", IDNhanVien="4", IDPhong="11", ID_LoaiThietBi="3", NgaySuaChua = new DateTime(2021,08,10), SoTienSuaChua =80000},
                new LichSuSuaChua {ID_LichSuSuaChua= "7", IDNhanVien="4", IDPhong="5", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,08,12), SoTienSuaChua =40000},
                new LichSuSuaChua {ID_LichSuSuaChua= "19", IDNhanVien="4", IDPhong="1", ID_LoaiThietBi="14", NgaySuaChua = new DateTime(2022,07,10), SoTienSuaChua =50000},
                new LichSuSuaChua {ID_LichSuSuaChua= "20", IDNhanVien="4", IDPhong="1", ID_LoaiThietBi="11", NgaySuaChua = new DateTime(2022,07,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "21", IDNhanVien="4", IDPhong="2", ID_LoaiThietBi="7", NgaySuaChua = new DateTime(2022,07,15), SoTienSuaChua =30000},
                new LichSuSuaChua {ID_LichSuSuaChua= "24", IDNhanVien="4", IDPhong="4", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,05,15), SoTienSuaChua =60000},
                new LichSuSuaChua {ID_LichSuSuaChua= "25", IDNhanVien="4", IDPhong="5", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,07,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "26", IDNhanVien="4", IDPhong="10", ID_LoaiThietBi="3", NgaySuaChua = new DateTime(2021,08,10), SoTienSuaChua =80000},
                new LichSuSuaChua {ID_LichSuSuaChua= "27", IDNhanVien="4", IDPhong="5", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,09,12), SoTienSuaChua =40000},

                new LichSuSuaChua {ID_LichSuSuaChua= "8", IDNhanVien="2", IDPhong="8", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "9", IDNhanVien="2", IDPhong="9", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "10", IDNhanVien="2", IDPhong="9", ID_LoaiThietBi="3", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "11", IDNhanVien="2", IDPhong="1", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "12", IDNhanVien="2", IDPhong="9", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "13", IDNhanVien="2", IDPhong="10", ID_LoaiThietBi="2", NgaySuaChua = new DateTime(2022,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "14", IDNhanVien="2", IDPhong="10", ID_LoaiThietBi="9", NgaySuaChua = new DateTime(2022,09,15), SoTienSuaChua =150000},
                new LichSuSuaChua {ID_LichSuSuaChua= "15", IDNhanVien="2", IDPhong="11", ID_LoaiThietBi="11", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "16", IDNhanVien="2", IDPhong="11", ID_LoaiThietBi="7", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "17", IDNhanVien="2", IDPhong="9", ID_LoaiThietBi="12", NgaySuaChua = new DateTime(2021,09,15), SoTienSuaChua =70000},
                new LichSuSuaChua {ID_LichSuSuaChua= "18", IDNhanVien="2", IDPhong="8", ID_LoaiThietBi="13", NgaySuaChua = new DateTime(2022,02,03), SoTienSuaChua =40000}
            });
            context.TienThangs.AddRange(new TienThang[]
            {
                new TienThang {ID= "1", ID_Phong= "2", NgayThu= new DateTime(2022,07,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "2", ID_Phong= "4", NgayThu= new DateTime(2022,07,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "3", ID_Phong= "5", NgayThu= new DateTime(2022,07,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "4", ID_Phong= "10", NgayThu= new DateTime(2022,07,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "5", ID_Phong= "11", NgayThu= new DateTime(2022,07,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "6", ID_Phong= "12", NgayThu= new DateTime(2022,07,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},

                new TienThang {ID= "7", ID_Phong= "2", NgayThu= new DateTime(2022,08,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "8", ID_Phong= "5", NgayThu= new DateTime(2022,08,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "9", ID_Phong= "10", NgayThu= new DateTime(2022,08,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "10", ID_Phong= "11", NgayThu= new DateTime(2022,08,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "11", ID_Phong= "12", NgayThu= new DateTime(2022,08,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},

                new TienThang {ID= "12", ID_Phong= "1", NgayThu= new DateTime(2022,09,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "13", ID_Phong= "2", NgayThu= new DateTime(2022,09,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "14", ID_Phong= "5", NgayThu= new DateTime(2022,09,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "15", ID_Phong= "10", NgayThu= new DateTime(2022,09,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "16", ID_Phong= "11", NgayThu= new DateTime(2022,09,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "17", ID_Phong= "12", NgayThu= new DateTime(2022,09,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},

                new TienThang {ID= "18", ID_Phong= "1", NgayThu= new DateTime(2022,04,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "19", ID_Phong= "2", NgayThu= new DateTime(2022,04,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "20", ID_Phong= "3", NgayThu= new DateTime(2022,04,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "21", ID_Phong= "4", NgayThu= new DateTime(2022,04,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "22", ID_Phong= "5", NgayThu= new DateTime(2022,04,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "23", ID_Phong= "8", NgayThu= new DateTime(2022,04,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "24", ID_Phong= "9", NgayThu= new DateTime(2022,04,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "25", ID_Phong= "10", NgayThu= new DateTime(2022,04,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "26", ID_Phong= "11", NgayThu= new DateTime(2022,04,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "27", ID_Phong= "12", NgayThu= new DateTime(2022,04,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},

                new TienThang {ID= "28", ID_Phong= "1", NgayThu= new DateTime(2022,05,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "29", ID_Phong= "2", NgayThu= new DateTime(2022,05,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "30", ID_Phong= "3", NgayThu= new DateTime(2022,05,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "31", ID_Phong= "4", NgayThu= new DateTime(2022,05,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "32", ID_Phong= "5", NgayThu= new DateTime(2022,05,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "33", ID_Phong= "8", NgayThu= new DateTime(2022,05,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "34", ID_Phong= "9", NgayThu= new DateTime(2022,05,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "35", ID_Phong= "10", NgayThu= new DateTime(2022,05,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "36", ID_Phong= "11", NgayThu= new DateTime(2022,05,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},
                new TienThang {ID= "37", ID_Phong= "12", NgayThu= new DateTime(2022,05,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= true},

                new TienThang {ID= "38", ID_Phong= "1", NgayThu= new DateTime(2022,06,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "39", ID_Phong= "2", NgayThu= new DateTime(2022,06,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "40", ID_Phong= "3", NgayThu= new DateTime(2022,06,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "41", ID_Phong= "4", NgayThu= new DateTime(2022,06,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "42", ID_Phong= "5", NgayThu= new DateTime(2022,06,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "43", ID_Phong= "8", NgayThu= new DateTime(2022,06,01), TienPhong= 1000000, ChuDien= 150, ChuNuoc= 10, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "44", ID_Phong= "9", NgayThu= new DateTime(2022,06,01), TienPhong= 1700000, ChuDien= 170, ChuNuoc= 15, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "45", ID_Phong= "10", NgayThu= new DateTime(2022,06,01), TienPhong= 1500000, ChuDien= 160, ChuNuoc= 13, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "46", ID_Phong= "11", NgayThu= new DateTime(2022,06,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                new TienThang {ID= "47", ID_Phong= "12", NgayThu= new DateTime(2022,06,01), TienPhong= 1300000, ChuDien= 140, ChuNuoc= 20, TienMotChuDien= 3000, TienMotChuNuoc= 10000, DaNop= false},
                
                new TienThang {ID= "48", ID_Phong= "7", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "49", ID_Phong= "8", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "50", ID_Phong= "9", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "51", ID_Phong= "10", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "52", ID_Phong= "11",NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "53", ID_Phong= "12", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "54", ID_Phong= "13", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "55", ID_Phong= "14", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "56", ID_Phong= "1", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "57", ID_Phong= "2", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "58", ID_Phong= "3", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "59", ID_Phong= "4", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "60", ID_Phong= "5",NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true},
                new TienThang {ID= "61", ID_Phong= "6", NgayThu= new DateTime(2000,01,01), TienPhong= 0, ChuDien= 0, ChuNuoc=0, TienMotChuDien=0, TienMotChuNuoc=0, DaNop= true}
            });
        }
    }
}
