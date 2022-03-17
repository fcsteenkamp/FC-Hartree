using Hartree.Interfaces;
using Hartree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Services
{
    public class HoldingsService : IHoldings
    {
        public List<PerfData> CalculateHoldingTrend(double openValue, double closeValue, List<PerfData> perfData)
        {
            List<PerfData> result = new List<PerfData>();
            var orderedData = perfData.OrderBy(o => o.Date).ToList();

            for (int i = 0; i < orderedData.Count(); i++)
            {
                PerfData dataPoint = new PerfData()
                {
                    Date = orderedData[i].Date,
                    Value = i > 0 ? (orderedData.Where(o=>o.Date <= orderedData[i].Date).Sum(o=>o.Value) + openValue) : openValue,
                    ClassId = (int)Enums.Enums.ClassType.HoldingsTrendData
                };

                result.Add(dataPoint);
            }

            return result;
        }

        public  Holding GetHolding(int Id)
        {
            //Retrieve holdings and performance data by id
            var holdings = Data.SampleData.GetData().Where(o => o.Id == Id).FirstOrDefault();

            //Calculate holdings trend
            //Assuming Class Id 1 = Instrument Performance Data
            //Returning Class Id 2 = Holding Trend Data
            var holdingTrend = CalculateHoldingTrend(holdings.OpeningValue, holdings.ClosingValue, holdings.PerfData.Where(o => o.ClassId == (int)Enums.Enums.ClassType.InstrumentsPerfData).ToList());

            holdings.PerfData.AddRange(holdingTrend);

            return holdings;
        }
    }
}
