using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class StateCodeAnalyzer
    {
        public int ReadStateCensusData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCensusData>().ToList();
                foreach (var data in records)
                {
                    // Console.WriteLine(data.State + " " + data.Population + " " + data.DensityPerSqKm + " " + data.AreaInSqKm);
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
    }
}
