using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class IndianStateCode
    {
        public int ReadStateCodeData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    // Console.WriteLine(data.SrNo + " " + data.StateName + " " + data.Tin + " " + data.StateCodes);
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
    }
}
