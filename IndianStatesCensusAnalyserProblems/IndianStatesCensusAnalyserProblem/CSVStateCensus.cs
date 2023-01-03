using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    internal class CSVStateCensus
    {
        public void ReadStateCensusData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCensusData>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.State + " " + data.Population + " " + data.DensityPerSqKm + " " + data.AreaInSqKm);
                }
            }
        }
    }
}
