using Hartree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Interfaces
{
    public interface IHoldings
    {
        Holding GetHolding(int Id);
        List<PerfData> CalculateHoldingTrend(double openValue, double closeValue, List<PerfData> perfData);
    }
}
