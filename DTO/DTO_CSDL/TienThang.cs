using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO.DTO_CSDL
{
    public class TienThang
    {
        [Key]
        [Required]
        public string ID { get; set; }

        public string ID_Phong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThu { get; set; }

        public int TienPhong { get; set; }
        public int ChuDien { get; set; }

        public int ChuNuoc { get; set; }

        public int TienMotChuDien { get; set; }

        public int TienMotChuNuoc { get; set; }

        public bool DaNop { get; set; }

        [ForeignKey("ID_Phong")]
        public virtual PhongTro PhongTro { get; set; }
    }
}
