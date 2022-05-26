using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class LoaiPhong
    {
        public LoaiPhong()
        {
            this.PhongTros = new HashSet<PhongTro>();
            this.DanhSachIDLTB = new HashSet<DanhSachIDLTB>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string IDLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public int GiaThanh { get; set; }
        public virtual ICollection<PhongTro> PhongTros { get; set; }
        public virtual ICollection<DanhSachIDLTB> DanhSachIDLTB { get; set; }
    }
}
