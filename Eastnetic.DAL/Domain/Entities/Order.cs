using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            this.Windows = new HashSet<Window>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public virtual ICollection<Window> Windows { get; set; }
    }
}
