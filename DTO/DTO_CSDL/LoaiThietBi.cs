using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTroLinQ.DTO
{
    public class LoaiThietBi
    {
        public LoaiThietBi()
        {
            this.DanhSachIDLTB = new HashSet<DanhSachIDLTB>();
            this.ThietBis = new HashSet<ThietBi>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string IDLoaiThietBi { get; set; }
        public string TenLoaiThietBi { get; set; }
        public virtual ICollection<DanhSachIDLTB> DanhSachIDLTB { get; set; }
        public virtual ICollection<ThietBi> ThietBis { get; set; }
    }
}
