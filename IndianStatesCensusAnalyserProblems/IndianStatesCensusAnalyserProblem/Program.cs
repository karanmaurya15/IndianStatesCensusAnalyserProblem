namespace IndianStatesCensusAnalyserProblem
{
    internal class Program
    {
        public static string stateCensusCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        public static string stateCodeFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCode.csv";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter the option : 1. For State Census Data \n 2. For Indian State Code : \n");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CSVStateCensus cSVStateCensus = new CSVStateCensus();
                        cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
                        break;
                    case 2:
                        IndianStateCode indianStateCode = new IndianStateCode();
                        indianStateCode.ReadStateCodeData(stateCodeFilePath);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}