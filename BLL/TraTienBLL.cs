using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.BLL
{
    public class TraTienBLL
    {
        QLPT db;
        private static TraTienBLL _Instance;
        public static TraTienBLL Instance
        {
            get
            {
                return new TraTienBLL();
            }
            private set { }
        }
        public TraTienBLL()
        {
            db = new QLPT();
        }

        public TienThang EpVeTienThang(string ID, string ID_Phong, DateTime NgayThu, int TienPhong, int ChuDien, int ChuNuoc, int TienMotChuDien, int TienMotChuNuoc, bool DaNop)
        {
            return new TienThang
            {
                ID = ID,
                ID_Phong = ID_Phong,
                NgayThu = NgayThu,
                TienPhong = TienPhong,
                ChuDien = ChuDien,
                ChuNuoc = ChuNuoc,
                TienMotChuDien = TienMotChuDien,
                TienMotChuNuoc = TienMotChuNuoc,
                DaNop = DaNop,
            };

        }

        public TienThang GetTienThangByID(string iD_Thang)
        {
            return db.TienThangs.Find(iD_Thang);
        }

        public void CreateDB()
        {
            List<PhongTro> list = db.PhongTros.Where(x => x.TinhTrang == true).ToList();
            foreach (PhongTro p in list)
            {
                bool have = false;
                foreach (TienThang t in db.TienThangs)
                    if (p.ID == t.ID_Phong && t.TienPhong==0)
                    {
                        have = true;
                        break;
                    }
                if (!have)
                {
                    int n = db.TienThangs.Count() + 1;
                    db.TienThangs.Add(EpVeTienThang((n).ToString(), p.ID, p.NgayThue.Value, 0, 0, 0, 0, 0, true));
                    db.SaveChanges();
                }

            }
        }

        public DateTime GetNgayThuMoiNhat(string iD_Phong)
        {
            TienThang t = db.TienThangs.Where(x=> x.ID_Phong == iD_Phong).OrderByDescending(x=>x.NgayThu).FirstOrDefault();
            return t.NgayThu;
        }

        public int GetChuDienMoiNhat(string iD_Phong)
        {
            TienThang t = db.TienThangs.Where(x => x.ID_Phong == iD_Phong).OrderByDescending(x => x.NgayThu).FirstOrDefault();
            return t.ChuDien;
        }
        public int GetChuNuocMoiNhat(string iD_Phong)
        {
            TienThang t = db.TienThangs.Where(x => x.ID_Phong == iD_Phong).OrderByDescending(x => x.NgayThu).FirstOrDefault();
            return t.ChuNuoc;
        }
        public DataTable GetDSTraTien(string s, bool cahai, bool danop)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID_Phong"),
                new DataColumn("Tên phòng"),
                new DataColumn("Số tháng nợ"),
            });
            List<PhongTro> list= db.PhongTros.Where(x => x.TinhTrang == true && x.TenPhong.Contains(s)).ToList();


            foreach (PhongTro p in list) {
                int cnt = db.TienThangs.Where(x => x.ID_Phong == p.ID && x.DaNop == false).Count();
                if (cahai)
                    dt.Rows.Add(p.ID, p.TenPhong, cnt);
                else
                if (danop) {
                    if (cnt == 0) dt.Rows.Add(p.ID, p.TenPhong, cnt);
                }
                else
                    if (!danop)
                        if (cnt > 0) dt.Rows.Add(p.ID, p.TenPhong, cnt);
            }
            return dt;
        }


        public int GetTienPhongByID_Phong(string ID_Phong)
        {
            string ID_LoaiPhong = "";
            foreach (PhongTro p in db.PhongTros.Where(x => x.ID == ID_Phong))
                ID_LoaiPhong = p.ID_LoaiPhong;

            foreach (LoaiPhong lp in db.LoaiPhongs.Where(x => x.IDLoaiPhong == ID_LoaiPhong))
                return lp.GiaThanh;
            return 0;
        }

        public void NapTien(string id)
        {
            var x = db.TienThangs.Find(id);
            x.DaNop = !x.DaNop;
            db.SaveChanges();
        }

        public int GetTienSuaChuaTB(string ID_Phong, DateTime NgayThu)
        {
            int s = 0;
            foreach (LichSuSuaChua x in db.LichSuSuaChuas.Where(x => x.IDPhong == ID_Phong && NgayThu >= x.NgaySuaChua))
                s += x.SoTienSuaChua;
            return s;
        }

        public DataTable GetDSTienThang(string s, bool ch, bool dn, string ID_Phong)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID"),
                new DataColumn("Ngày thu tiền"),
                new DataColumn("Tiền phòng"), 
                new DataColumn("Tiền một chữ điện"),
                new DataColumn("Số chữ điện"),
                new DataColumn("Tiền điện"),
                new DataColumn("Tiền một chữ nước"),
                new DataColumn("Số chữ nước"),
                new DataColumn("Tiền nước"),
                new DataColumn ("Tiền sửa chữa thiết bị"),
                new DataColumn("Tổng tiền tháng này"),
                new DataColumn("Đã nộp tiền", Type.GetType("System.Boolean")),

            });
            List<TienThang> t = db.TienThangs.Where(x => x.ID_Phong == ID_Phong).OrderBy(x => x.NgayThu).ToList();
            for (int i = 1; i < t.Count; i++)
            {
                int TienPhong = t[i].TienPhong;
                int TienDien = t[i].TienMotChuDien * (t[i].ChuDien - t[i - 1].ChuDien);
                int TienNuoc = t[i].TienMotChuNuoc * (t[i].ChuNuoc - t[i - 1].ChuNuoc);
                int TienSuaChuaTB = GetTienSuaChuaTB(ID_Phong, t[i].NgayThu) - GetTienSuaChuaTB(ID_Phong, t[i - 1].NgayThu);

                int TongTien = TienPhong + TienDien + TienNuoc + TienSuaChuaTB;

                if (t[i].NgayThu.ToString().Contains(s) && (ch ? ch : t[i].DaNop == dn))
                    dt.Rows.Add(t[i].ID, t[i].NgayThu.ToString("d"), TienPhong, t[i].TienMotChuDien, t[i].ChuDien, TienDien, t[i].TienMotChuNuoc, t[i].ChuNuoc, TienNuoc, TienSuaChuaTB, TongTien, t[i].DaNop);
            }

            return dt;
        }

        public int GetTongSoThang()
        {
            return db.TienThangs.Count();
        }
        public void ThemThangMoi(TienThang x)
        {
            db.TienThangs.Add(x);
            db.SaveChanges();
        }

        public void XoaThangMoiNhat(string ID)
        {
            db.TienThangs.Remove(db.TienThangs.Find(ID));
            db.SaveChanges();
        }

        public void SuaThangMoiNhat(string ID, TienThang y)
        {
            var x=db.TienThangs.Find(ID);
            x.ChuDien = y.ChuDien;
            x.ChuNuoc = y.ChuNuoc;
            x.NgayThu = y.NgayThu;
            x.TienMotChuDien = y.TienMotChuDien;
            x.TienMotChuNuoc = y.TienMotChuNuoc;
            x.TienPhong = y.TienPhong;
            db.SaveChanges();
        }

        public string XuatHoaDon(string ID_Phong, string TenPhong, DataGridView dgv_DSThang)
        {
            string s = "\nPHÒNG : "+TenPhong+"\n\n";
            s += "Gửi người thuê:\n\n";

            foreach (QLDatPhong qldp in PhongTroBLL.Instance.GetPhongByID(ID_Phong).QLDatPhongs)
                if (qldp.ID_Phong == ID_Phong)
                    s += "\t"+NguoiThueBLL.Instance.GetTenNguoiThueByID(qldp.ID_NguoiThue)+"\n";
            s += "\n\n\tHÓA ĐƠN CÁC THÁNG CẦN NỘP TIỀN\n\n\n";

            int total = 0;
            for (int i = 0; i <= dgv_DSThang.Rows.Count - 2; i++)
            {
                DataGridViewRow r = dgv_DSThang.Rows[i];
                if (Convert.ToBoolean(r.Cells["Đã nộp tiền"].Value.ToString()) == false)
                {
                    s += "\nNgày thu tiền :\t\t" + r.Cells["Ngày thu tiền"].Value.ToString() + "\n\n";
                    s += "\t Tiền Phòng :\t\t\t" + r.Cells["Tiền phòng"].Value.ToString() + "\n";
                    s += "\t Tiền một chữ điện :\t\t\t" + r.Cells["Tiền một chữ điện"].Value.ToString() + "\n";
                    s += "\t Số chữ điện :\t\t\t" + r.Cells["Số chữ điện"].Value.ToString() + "\n";
                    s += "\t Tiền điện :\t\t\t" + r.Cells["Tiền điện"].Value.ToString() + "\n";
                    s += "\t Tiền một mét khối nước :\t\t" + r.Cells["Tiền một chữ nước"].Value.ToString() + "\n";
                    s += "\t Số chữ nước :\t\t\t" + r.Cells["Số chữ nước"].Value.ToString() + "\n";
                    s += "\t Tiền nước :\t\t\t" + r.Cells["Tiền nước"].Value.ToString() + "\n";
                    s += "\t Tiền sửa chữa thiết bị :\t\t" + r.Cells["Tiền sửa chữa thiết bị"].Value.ToString() + "\n";
                    s += "\t Tổng tiền tháng này :\t\t" + r.Cells["Tổng tiền tháng này"].Value.ToString() + "\n";
                    total += Convert.ToInt32(r.Cells["Tổng tiền tháng này"].Value.ToString());
                }
            }
            s += "\nTỔNG TIỀN CẦN THANH TOÁN : " + total.ToString()+" VND\n";

            return s;
        }

    }
}
