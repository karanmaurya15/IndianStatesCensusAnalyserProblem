namespace IndianStatesCensusAnalyserProblem
{
    internal class Program
    {
        public static string stateCensusCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        public static string stateCodeFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCode.csv";
        static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
            IndianStateCode indianStateCode = new IndianStateCode();
            indianStateCode.ReadStateCodeData(stateCodeFilePath);
        }
    }
}