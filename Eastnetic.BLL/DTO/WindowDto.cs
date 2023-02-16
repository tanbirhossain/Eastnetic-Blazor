namespace Eastnetic.BLL.DTO
{
    public class WindowDto
    {
       
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements { get; set; }
    }
}
