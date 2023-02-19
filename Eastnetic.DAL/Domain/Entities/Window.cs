using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Domain.Entities
{
    public class Window
    {
        public  Window()
        {
            this.SubElements = new HashSet<SubElement>();
        }
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<SubElement> SubElements { get; set; }
    }
}
