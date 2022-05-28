using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyPhongTroLinQ.DTO
{
    public class QLDatPhong
    {
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 1)]
        public string ID_NguoiThue { get; set; }
        [Key]
        [StringLength(9)]
        [Required]
        [Column(Order = 2)]
        public string ID_Phong { get; set; }
        [ForeignKey("ID_NguoiThue")]
        public virtual NguoiThue NguoiThue { get; set; }
        [ForeignKey("ID_Phong")]
        public virtual PhongTro PhongTro { get; set; }

    }
}
