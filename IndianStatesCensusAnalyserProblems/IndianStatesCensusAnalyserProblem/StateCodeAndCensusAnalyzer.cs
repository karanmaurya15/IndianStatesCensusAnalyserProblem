using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class StateCodeAndCensusAnalyzer
    {
        public int ReadStateCodeData(string filepath)
        {
            // T.C-1.2
            if (!File.Exists(filepath))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.FILE_INCORRECT, "Incorrect FilePath");
            }
            // T.C-1.3
            if (! filepath.EndsWith(".csv"))
            {
                 throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.TYPE_INCORRET, "Incorrect FileType");
            }
            // T.C-1.4
            var read = File.ReadAllLines(filepath);
            string header = read[0];
            if (header.Contains("-"))
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.DELIMETER_INCORRET, "Delimeter Incorrect");
            // T.C-1.1
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    // Console.WriteLine(data.State + " " + data.Population + " " + data.DensityPerSqKm + " " + data.AreaInSqKm);
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
        // T.C-1.5
        public bool ReadStateCodeData(string filepath, string header)
        {
            var read = File.ReadAllLines(filepath);
            string headers = read[0];
            if(headers.Equals(header))
                return true;
            else
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.HEADER_INCORRECT, "Header is Incorrect");
        }
    }
}
