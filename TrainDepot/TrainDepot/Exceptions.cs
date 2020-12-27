
//
// Custom exception classes for 
// exception handling
//

using System;

namespace TrainDepot
{

    // Exception to throw then negative value passing detected 
    [Serializable]
    public class NegativeValuePassedException : Exception
    {
        public NegativeValuePassedException() { }

        public NegativeValuePassedException(string message)
            : base(message) { }
    }


    // Exception to throw then incorrect time format detected 
    public class IncorrectTimeException : Exception
    {
        public IncorrectTimeException() { }

        public IncorrectTimeException(string message)
            : base(message) { }
    }
     
}
