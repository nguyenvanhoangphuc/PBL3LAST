using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class LichSuSuaChua
    {
        [Key]
        [StringLength(9)]
        [Required]
        public string ID_LichSuSuaChua { get; set; }
        public string IDNhanVien { get; set; }
        [ForeignKey("ThietBi"), Column(Order = 0)]
        public string IDPhong { get; set; }
        [ForeignKey("ThietBi"), Column(Order = 1)]
        public string ID_LoaiThietBi { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySuaChua { get; set; }
        public int SoTienSuaChua { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NguoiDung NhanVien { get; set; }
        [ForeignKey("ThietBi")]
        public virtual ThietBi ThietBi { get; set; }
    }
}
