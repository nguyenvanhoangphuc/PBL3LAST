using QuanLyPhongTroLinQ.BLL;
using QuanLyPhongTroLinQ.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace QuanLyPhongTroLinQ.View
{
    public partial class FormDatPhong : Form
    {
        public delegate void Mydel();
        public Mydel t;
        public List<NguoiThue> ds;
        public NguoiThue nguoith;
        public FormDatPhong(NguoiThue t)
        {
            InitializeComponent();
            nguoith = t;
            ds = new List<NguoiThue>();
            GUI();
        }
        public void GUI()
        {
            cboLoaiPhong.Items.AddRange(BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong().ToArray());

        }
        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CBBItemLoaiPhong i in BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong())
            {
                if (i.TenLoaiPhong == cboLoaiPhong.SelectedItem.ToString())
                {
                    dgvPhong.DataSource = BLL_DatTraPhong.Instance.GetPhongTroViewByLoaiPhong(i.ID);
                    dgvPhong.Columns["IDPhong"].Visible = false;
                    dgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
                    dgvPhong.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";
                    dgvPhong.Columns["NgayThue"].HeaderText = "Ngày thuê";
                    dgvPhong.Columns["TinhTrang"].HeaderText = "Tình trạng";
                    break;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            t();
            this.Close();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            dgvCoTheChon.DataSource = BLL_DatTraPhong.Instance.GetNguoiChuaThueVaLoaiTru(txtSDT.Text, nguoith.SDT);

            dgvCoTheChon.Columns["ID"].Visible = false;
            dgvCoTheChon.Columns["HoTen"].HeaderText = "Họ tên";
            dgvCoTheChon.Columns["SDT"].HeaderText = "SDT";
            dgvCoTheChon.Columns["QueQuan"].HeaderText = "Quê quán";
            dgvCoTheChon.Columns["CCCD"].HeaderText = "CCCD";
            dgvCoTheChon.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgvCoTheChon.Columns["QLDatPhongs"].Visible = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool temp = true;
            if (dgvCoTheChon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvCoTheChon.SelectedRows)
                {
                    foreach (NguoiThue j in ds)
                    {
                        if (j.SDT == i.Cells["SDT"].Value.ToString())
                        {
                            temp = false;
                            break;
                        }
                    }
                    if (temp == true) ds.Add(new NguoiThue()
                    {
                        ID = i.Cells["ID"].Value.ToString(),
                        HoTen = i.Cells["HoTen"].Value.ToString(),
                        QueQuan = i.Cells["QueQuan"].Value.ToString(),
                        CCCD = i.Cells["CCCD"].Value.ToString(),
                        SDT = i.Cells["SDT"].Value.ToString(),
                        TinhTrang = Convert.ToBoolean(i.Cells["TinhTrang"].Value.ToString())
                    });

                }
                dgvDaChon.DataSource = null;
                dgvDaChon.DataSource = ds;
                dgvDaChon.Columns["ID"].Visible = false;
                dgvDaChon.Columns["HoTen"].HeaderText = "Họ tên";
                dgvDaChon.Columns["SDT"].HeaderText = "SDT";
                dgvDaChon.Columns["QueQuan"].HeaderText = "Quê quán";
                dgvDaChon.Columns["CCCD"].HeaderText = "CCCD";
                dgvDaChon.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dgvDaChon.Columns["QLDatPhongs"].Visible = false;
            }
        }

        private void btnBoChon_Click_1(object sender, EventArgs e)
        {
            if (dgvDaChon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvDaChon.SelectedRows)
                {
                    foreach (NguoiThue j in ds)
                    {
                        if (j.SDT == i.Cells["SDT"].Value.ToString())
                        {
                            ds.Remove(j);
                            break;
                        }
                    }
                }
            }
            dgvDaChon.DataSource = null;
            dgvDaChon.DataSource = ds;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng! Vui lòng chọn phòng trống.");
                return;
            }
            ds.Add(nguoith);
            BLL_DatTraPhong.Instance.DatPhong(ds, dgvPhong.SelectedRows[0].Cells["IDPhong"].Value.ToString());
            foreach (CBBItemLoaiPhong i in BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong())
            {
                if (i.TenLoaiPhong == cboLoaiPhong.SelectedItem.ToString())
                {
                    dgvPhong.DataSource = BLL_DatTraPhong.Instance.GetPhongTroViewByLoaiPhong(i.ID);
                }

            }
            MessageBox.Show("Bạn đã đặt phòng thành công.");
            t();
            this.Close(); 
        }
    }
}
