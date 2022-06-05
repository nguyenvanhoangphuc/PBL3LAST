using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;
using QuanLyPhongTroLinQ.BLL;
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
                    ;


                }
                dgvDaChon.DataSource = null;
                dgvDaChon.DataSource = ds;
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
            ds.Add(nguoith);
            BLL_DatTraPhong.Instance.DatPhong(ds, dgvPhong.SelectedRows[0].Cells["IDPhong"].Value.ToString());
            foreach (CBBItemLoaiPhong i in BLL_DatTraPhong.Instance.GetCBBItemLoaiPhong())
            {
                if (i.TenLoaiPhong == cboLoaiPhong.SelectedItem.ToString())
                {
                    dgvPhong.DataSource = BLL_DatTraPhong.Instance.GetPhongTroViewByLoaiPhong(i.ID);
                }

            }
        }
    }
}
