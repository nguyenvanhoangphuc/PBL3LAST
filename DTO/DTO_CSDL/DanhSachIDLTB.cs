using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class DanhSachIDLTB
    {
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 1)]
        public string IDLoaiPhong { get; set; }
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 2)]
        public string IDLoaiThietBi { get; set; }
        public int SoLuong { get; set; }
        [ForeignKey("IDLoaiPhong")]
        public virtual LoaiPhong LoaiPhong { get; set; }
        [ForeignKey("IDLoaiThietBi")]
        public virtual LoaiThietBi LoaiThietBi { get; set; }
    }
}
