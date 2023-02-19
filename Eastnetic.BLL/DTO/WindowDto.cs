using System.ComponentModel.DataAnnotations;

namespace Eastnetic.BLL.DTO
{
    public class WindowDto
    {
       
        public long Id { get; set; }
        [Required]
        public long OrderId { get; set; }
        public string OrderName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
    }
}
