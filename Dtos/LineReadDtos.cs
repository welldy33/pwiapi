using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace pwiapi.Dtos
{
    public class LineReadDtos
    {
        [Key]
        public string LINE_NO { get; set; }
        public string LINE_NM { get; set; }
        public string AREA_NO { get; set; }
        public string STOP_MK { get; set; }
        public string ADD_USER { get; set; }
        public string ADD_TIME { get; set; }
    }
}
