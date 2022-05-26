using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class NguoiDung
    {
        public NguoiDung()
        {
            this.LichSuSuaChuas = new HashSet<LichSuSuaChua>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string ID { get; set; }
        public string ID_TK { get; set; }
        public string Ten { get; set; }
        public string QueQuan { get; set; }
        [StringLength(15)]
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string TrangThai { get; set; }
        public string TuCach { get; set; }
        [ForeignKey("ID_TK")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<LichSuSuaChua> LichSuSuaChuas { get; set; }
    }
}
