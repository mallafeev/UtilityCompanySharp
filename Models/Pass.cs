using CourseWorkPIPS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Models
{
    public class Pass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public PassType Type { get; set; }
        public PassKind Kind { get; set; }
        public PassStatus Status { get; set; }
        public string Code { get; set; }
        public int? AddressId { get; set; } // Внешний ключ
        public Address? Address { get; set; }
       
    }
}
