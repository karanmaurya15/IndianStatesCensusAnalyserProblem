using IndianStatesCensusAnalyserProblem;

namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCodeFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCode.csv";
        public static string stateCodeIncorrectCSVFilePath = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\State.csv";
        public static string stateCodeIncorrectCSVFileType = @"C:\BridgeLabz\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblems\IndianStatesCensusAnalyserProblem\File\StateCode.txt";

        [Test]  // T.C-1.1
        public void GivenStateCodeData_WhenAnalysed_ShouldReturnNoOfRecordMatches()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            IndianStateCode indianStateCode = new IndianStateCode();
            Assert.AreEqual(stateCodeAndCensusAnalyzer.ReadStateCodeData(stateCodeFilePath), indianStateCode.ReadStateCodeData(stateCodeFilePath));
        }
        [Test]  // T.C-1.2
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCodeData(stateCodeIncorrectCSVFilePath);
            }
            catch(StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
        [Test]  // T.C-1.3
        public void GivenStateCodeDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCodeData(stateCodeIncorrectCSVFileType);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FileType");
            }
        }
        [Test]  // T.C-1.4
        public void GivenStateCodeDataDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAndCensusAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                int record = stateCodeAndCensusAnalyzer.ReadStateCodeData(stateCodeFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
        [Test]  // T.C-1.5
        public void GivenStateCodeDataFileIncorrectHeader_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAndCensusAnalyzer stateCodeAnalyzer = new StateCodeAndCensusAnalyzer();
            try
            {
                bool records = stateCodeAnalyzer.ReadStateCodeData(stateCodeFilePath, "SrNo,StateName,Tin,StateCodes");
                Assert.IsTrue(records);
            }
            catch (StateCensusAndCodeException ex)
            {    
                Assert.AreEqual(ex.Message, "Header is Incorrect");
            }
        }
    }   
}