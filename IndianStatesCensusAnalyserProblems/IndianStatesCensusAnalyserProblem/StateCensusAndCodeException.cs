using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class StateCensusAndCodeException:Exception
    {
        public enum ExceptionType
        {
            FILE_INCORRECT,
            TYPE_INCORRET,
            DELIMETER_INCORRET,
            HEADER_INCORRECT
        }
        public ExceptionType Type;
        public StateCensusAndCodeException(ExceptionType exceptionType, string message) : base(message)
        {
           Type = exceptionType;
        }
    } 
}
