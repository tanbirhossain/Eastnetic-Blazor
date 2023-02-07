using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Domain.Entities
{
    public class Order
    {
            public long Id { get; set; }
            public string Name { get; set; }
            public string State { get; set; }
    }
}
