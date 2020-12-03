using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace pwiapi.Dtos
{
    public class LineCreateDtos
    {
        [Required]
        public string LINE_NO { get; set; }
        
        [Required]
        public string LINE_NM { get; set; }

        [Required]
        public string AREA_NO { get; set; }

        [Required]
        public string STOP_MK { get; set; }
        public string ADD_USER { get; set; }
        public string ADD_TIME { get; set; }
    }
}
