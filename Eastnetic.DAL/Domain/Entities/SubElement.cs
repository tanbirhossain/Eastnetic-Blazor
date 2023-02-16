using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Domain.Entities
{
    public class SubElement
    {
        public long Id { get; set; }
        public long WindowId { get; set; }
        public int Element { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual Window Window  { get; set; }
    }
}
