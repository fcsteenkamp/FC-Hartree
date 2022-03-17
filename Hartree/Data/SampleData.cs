using Hartree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hartree.Data
{
    public class SampleData
    {
        public static List<Holding> GetData()
        {
            List<Holding> data = new List<Holding>();

            List<PerfData> perfdata = new List<PerfData>();

            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 1), Value = 100, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });
            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 2), Value = 80, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });
            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 3), Value = 90, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });
            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 4), Value = 20, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });
            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 5), Value = 130, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });
            perfdata.Add(new PerfData() { Date = new DateTime(2022, 3, 6), Value = 105, ClassId = (int)Enums.Enums.ClassType.InstrumentsPerfData });

            data.Add(new Holding() { Id = 1, AsAtDate = DateTime.Today, OpeningValue = 200, ClosingValue = 725, PerfData = perfdata });

            return data;
        }
    }
}
