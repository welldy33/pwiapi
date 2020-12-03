using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pwiapi.Dtos
{
    public class LineUpdateDtos
    {
        
        [Required]
        public string LINE_NM { get; set; }
        
        [Required]
        public string AREA_NO { get; set; }
        
        [Required]
        public string STOP_MK { get; set; }
        
        [Required]
        public string ADD_USER { get; set; }
        
        [Required]
        public string ADD_TIME { get; set; }
    } 

}
