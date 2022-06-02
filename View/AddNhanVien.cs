using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;

namespace QuanLyPhongTroLinQ.View
{
    public partial class AddNhanVien : Form
    {
        public delegate void myDel();
        public myDel dShow;

        public string ID { get; set; }
        public AddNhanVien(string id)
        {
            InitializeComponent();
            this.ID = id;
            txtTT.Text = "ChapNhan";
            txtTT.Enabled = false;
            GUI(id);
        }
        private void GUI(string id)
        {
            if (id != "")
            {
                //update
                txtID.Text = id;
                txtID.Enabled = false;
                txtTen.Text = NhanVienBLL.Instance.GetNhanVienByID(id).Ten;
                txtQueQuan.Text = NhanVienBLL.Instance.GetNhanVienByID(id).QueQuan;
                txtSDT.Text = NhanVienBLL.Instance.GetNhanVienByID(id).SDT;
                txtCCCD.Text = NhanVienBLL.Instance.GetNhanVienByID(id).CCCD;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NguoiDung nhanvien = new NguoiDung();
            nhanvien.ID = txtID.Text;
            nhanvien.Ten = txtTen.Text;
            nhanvien.QueQuan = txtQueQuan.Text;
            nhanvien.SDT = txtSDT.Text;
            nhanvien.CCCD = txtCCCD.Text;
            nhanvien.TrangThai = "ChapNhan";
            nhanvien.TuCach = "NhanVien";

            string value = NhanVienBLL.Instance.AddNhanVien(nhanvien, ID);
            switch (value)
            {
                case "requied_ID":
                    MessageBox.Show("ID không được để trống!");
                    return;
                case "requied_Ten":
                    MessageBox.Show("Tên nhân viên không được để trống!");
                    return;
                case "requied_QueQuan":
                    MessageBox.Show("Quê quán nhân viên không được để trống!");
                    return;
                case "requied_SDT":
                    MessageBox.Show("SDT nhân viên không được để trống!");
                    return;
                case "requied_CCCD":
                    MessageBox.Show("CCCD nhân viên không được để trống!");
                    return;
                case "added":
                    MessageBox.Show("Đã thêm thành công nhân viên mới!");
                    //show lai DGVPhongTro
                    dShow();
                    this.Close();
                    return;
                case "updated":
                    MessageBox.Show("Đã chỉnh sửa thành công nhân viên này!");
                    dShow();
                    this.Close();
                    return;
                case "show message trung ID":
                    MessageBox.Show("ID không hợp lệ! Đã tồn tại ID nhân viên này.");
                    return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (ID == "") txtID.Text = "";
            txtTen.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
        }
    }
}
