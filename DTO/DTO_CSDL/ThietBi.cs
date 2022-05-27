using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyPhongTroLinQ.DTO
{
    public class ThietBi
    {
        public ThietBi()
        {
            this.LichSuSuaChuas = new HashSet<LichSuSuaChua>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 1)]
        public string IDPhong { get; set; }
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 2)]
        public string IDLoaiThietBi { get; set; }
        public bool TinhTrang { get; set; }
        [ForeignKey("IDPhong")]
        public virtual PhongTro PhongTro { get; set; }
        [ForeignKey("IDLoaiThietBi")]
        public virtual LoaiThietBi LoaiThietBi { set; get; }
        public virtual ICollection<LichSuSuaChua> LichSuSuaChuas { get; set; }
    }
}
