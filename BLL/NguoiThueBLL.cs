﻿using QuanLyPhongTroLinQ.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongTroLinQ.BLL
{
    public class NguoiThueBLL
    {
        QLPT db;
        private static NguoiThueBLL _Instance;
        public static NguoiThueBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguoiThueBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public NguoiThueBLL()
        {
            db = new QLPT();
        }
        public string GetTenPhongByID(string ID){

            return db.PhongTros.Find(ID).TenPhong;
        }

        public DataTable GetAllNguoiThueView(string s = "", bool HVT = false, bool SDT = false, bool QQ = false, bool CCCD = false, bool DT = false)
        {
            db = new QLPT();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID"),
                new DataColumn("Họ và tên"),
                new DataColumn("Số điện thoại"),
                new DataColumn("Quê quán"),
                new DataColumn("Căn cước công dân"),
                new DataColumn("Tình trạng")
            });
            foreach (NguoiThue x in GetAllNguoiThue(s, HVT, SDT, QQ, CCCD, DT))
                dt.Rows.Add(x.ID, x.HoTen, x.SDT, x.QueQuan, x.CCCD, x.TinhTrang ? "Đang thuê" : "Chưa thuê");
            return dt;
        }

        public DataTable GetNguoiThueViewByPhongTro(string ID)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID"),
                new DataColumn("Họ và tên"),
                new DataColumn("Số điện thoại"),
                new DataColumn("Quê quán"),
                new DataColumn("Căn cước công dân"),
                new DataColumn("Tình trạng")
            });
            foreach (NguoiThue x in GetNguoiThueByPhongTro(ID))
                dt.Rows.Add(x.ID, x.HoTen, x.SDT, x.QueQuan, x.CCCD, x.TinhTrang ? "Đang thuê" : "Chưa thuê");
            return dt;
        }
        public List<NguoiThue> GetNguoiThueByPhongTro(string ID)
        {
            List<NguoiThue> nguoiThues = new List<NguoiThue> ();
            foreach (string Id in GetIDNguoiThueByPhongTro(ID))
            {
                nguoiThues.Add(GetNguoiThueByID(Id));
            }
            return nguoiThues; 
        }

        private NguoiThue GetNguoiThueByID(string id)
        {
            return db.NguoiThues.Find(id); 
        }

        public List<string> GetIDNguoiThueByPhongTro(string ID)
        {
            return db.QLDatPhongs.Where(p => p.ID_Phong == ID).Select(p=>p.ID_NguoiThue).ToList(); 
        }

        public List<NguoiThue> GetAllNguoiThue(string s, bool HVT, bool SDT, bool QQ, bool CCCD, bool DT)
        {
            if (HVT)
                return db.NguoiThues.Where(x => x.HoTen.Contains(s)).OrderBy(x => x.ID).ToList();
            if (SDT)
                return db.NguoiThues.Where(x => x.SDT.Contains(s)).OrderBy(x => x.ID).ToList();
            if (QQ)
                return db.NguoiThues.Where(x => x.QueQuan.Contains(s)).OrderBy(x => x.ID).ToList();
            if (CCCD)
                return db.NguoiThues.Where(x => x.CCCD.Contains(s)).OrderBy(x => x.ID).ToList();
            if (DT)
                return db.NguoiThues.Where(x => (x.TinhTrang ? "Đang thuê" : "Chưa thuê").Contains(s)).OrderBy(x => x.ID).ToList();

            return db.NguoiThues.OrderBy(x => x.ID).ToList();
        }

        public void ThemNguoiThue(NguoiThue x)
        {
            db.NguoiThues.Add(x);
            db.SaveChanges();
        }

        public NguoiThue DoiTuongNguoiThue(string ID, string HVT, string SDT, string QQ, string CCCD, bool DT)
        {
            return new NguoiThue
            {
                ID = ID,
                HoTen = HVT,
                SDT = SDT,
                QueQuan = QQ,
                CCCD = CCCD,
                TinhTrang = DT
            };
        }

        public void SuaNguoiThue(NguoiThue x)
        {
            var y = db.NguoiThues.Find(x.ID);
            y.QueQuan = x.QueQuan;
            y.TinhTrang = x.TinhTrang;
            y.CCCD = x.CCCD;
            y.HoTen = x.HoTen;
            y.SDT = x.SDT;
            db.SaveChanges();
        }

        public string GetIdPhongByIdNguoi(string IdNguoi)
        {
            foreach (QLDatPhong x in db.QLDatPhongs.ToList())
                if (x.ID_NguoiThue == IdNguoi) return x.ID_Phong;
            return null;
        }

        public int GetSoNguoiDangThueByIdPhong(string IdPhong)
        {
            int cnt = 0;
            foreach (QLDatPhong x in db.QLDatPhongs.ToList())
                if (x.ID_Phong == IdPhong) cnt++;
            return cnt;
        }

        public int XoaNguoiThue(string ID, bool DT)
        {
            if (DT == true && GetSoNguoiDangThueByIdPhong(GetIdPhongByIdNguoi(ID)) <= 1)
                return 1;
            else
            {
                db.NguoiThues.Remove(db.NguoiThues.Find(ID));
                db.SaveChanges();

                IEnumerable<QLDatPhong> list = db.QLDatPhongs.Where(x => x.ID_NguoiThue == ID).ToList();
                db.QLDatPhongs.RemoveRange(list);
                db.SaveChanges();
            }
            return 0;
        }

        public string GetTenNguoiThueByID(string iD_NguoiThue)
        {
            return db.NguoiThues.Find(iD_NguoiThue).HoTen;
        }
    }
}
