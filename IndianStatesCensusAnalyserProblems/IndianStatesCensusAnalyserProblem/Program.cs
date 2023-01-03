namespace IndianStatesCensusAnalyserProblem
{
    internal class Program
    {
        public static string stateCensusCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
            
        }
    }
}