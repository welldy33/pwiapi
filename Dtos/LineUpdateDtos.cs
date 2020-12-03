
using System.ComponentModel.DataAnnotations;

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
        public string ADD_USER { get; set; }
        public string ADD_TIME { get; set; }
    } 

}
