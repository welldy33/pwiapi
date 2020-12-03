using System.ComponentModel.DataAnnotations;

namespace pwiapi.Dtos
{
    public class LineParam
    {
        [Required]
        public string LINE_NO { get; set; }
        [Required]
        public string LINE_NM { get; set; }
    }
}
