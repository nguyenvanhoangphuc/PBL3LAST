using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
