using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    internal class IndianStateCode
    {
        public void ReadStateCodeData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.SrNo + " " + data.StateName + " " + data.Tin + " " + data.StateCodes);
                }
            }
        }
    }
}
