using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTroLinQ.DTO
{
    public class CBBItem
    {
        public string ID { get; set; }
        public string Ten { get; set; }
        public override string ToString()
        {
            return Ten;
        }
    }
}
