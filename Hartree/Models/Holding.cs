using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Models
{
    public class Holding: BaseModel
    {
        public int Id { get; set; }
        public DateTime AsAtDate { get; set; }
        public double OpeningValue { get; set; }
        public double ClosingValue { get; set; }
        public List<PerfData> PerfData { get; set; }
    }
}
