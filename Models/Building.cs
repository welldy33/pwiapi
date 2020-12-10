using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pwiapi.Models
{
    public class Building
    {
        public int ID { get; set; }
        public string LIB_NO { get; set; }
        public string LIB_NM { get; set; }
        public string KIND { get; set; }

        public int UP_ID { get; set; }
        public string STOP_MK { get; set; }
    }
}
