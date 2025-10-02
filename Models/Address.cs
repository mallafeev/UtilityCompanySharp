using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int CountUses { get; set; }
        public ICollection<Pass>? Passes { get; set; }
    }
}
