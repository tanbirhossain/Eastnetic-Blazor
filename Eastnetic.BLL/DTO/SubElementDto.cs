using System.ComponentModel.DataAnnotations;

namespace Eastnetic.BLL.DTO
{
    public class SubElementDto
    {
        public long Id { get; set; }
        [Required]
        public long WindowId { get; set; }
        public string WindowName { get; set; }
        [Required]
        public int Element { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }
    }
}
