using IndianStatesCensusAnalyserProblem;

namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCensusCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        public static string stateCensusIncorrectCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensus.csv";
        public static string stateCensusIncorrectCSVFileType = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCensus.txt";
        
        [Test]  // T.C-1.1
        public void GivenStateCensusData_WhenAnalysed_ShouldReturnNoOfRecordMatches()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCodeAndCensusAnalyzer.ReadStateCensusData(stateCensusCSVFilePath), cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath));
        }
        [Test]  // T.C-1.2
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCensusData(stateCensusIncorrectCSVFilePath);
            }
            catch(StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
        [Test]  // T.C-1.3
        public void GivenStateCensusDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCensusData(stateCensusIncorrectCSVFileType);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FileType");
            }
        }
        [Test]  // T.C-1.4
        public void GivenStateCensusDataDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCensusData(stateCensusCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
        [Test]  // T.C-1.5
        public void GivenStateCensusDataFileIncorrectHeader_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                bool records = stateCodeAnalyzer.ReadStateCensusData(stateCensusCSVFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCensusAndCodeException ex)
            {    
                Assert.AreEqual(ex.Message, "Header is Incorrect");
            }
        }
    }   
}