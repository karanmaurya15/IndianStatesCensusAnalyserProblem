using IndianStatesCensusAnalyserProblem;

namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCensusCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        [Test]
        public void GivenStateCensusData_WhenAnalysed_ShouldReturnNoOfRecordMatches()
        {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCodeAnalyzer.ReadStateCensusData(stateCensusCSVFilePath), cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath));
        }
    }
}