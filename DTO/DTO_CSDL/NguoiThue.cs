using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTroLinQ.DTO
{
    public class NguoiThue
    {
        public NguoiThue()
        {
            this.QLDatPhongs = new HashSet<QLDatPhong>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string ID { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string QueQuan { get; set; }
        public string CCCD { get; set; }
        public bool TinhTrang { get; set; }
        public virtual ICollection<QLDatPhong> QLDatPhongs { get; set; }
    }
}
