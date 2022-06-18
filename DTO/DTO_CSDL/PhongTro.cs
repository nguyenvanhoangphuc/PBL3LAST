using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyPhongTroLinQ.DTO
{
    public class PhongTro
    {
        public PhongTro()
        {
            this.ThietBis = new HashSet<ThietBi>();
            this.QLDatPhongs = new HashSet<QLDatPhong>();
            this.TienThangs = new HashSet<TienThang>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string ID { get; set; }
        public string TenPhong { get; set; }
        public string ID_LoaiPhong { get; set; }
        public bool TinhTrang { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThue { get; set; }
        public int SoChuDien { get; set; }
        public int TienHienTai { get; set; }
        [ForeignKey("ID_LoaiPhong")]
        public virtual LoaiPhong LoaiPhong { get; set; }
        public virtual ICollection<ThietBi> ThietBis { get; set; }
        public virtual ICollection<QLDatPhong> QLDatPhongs { get; set; }
        public virtual ICollection<TienThang> TienThangs { get; set; }
    }
}
