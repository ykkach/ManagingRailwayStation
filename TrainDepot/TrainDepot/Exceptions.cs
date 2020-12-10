using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDepot
{
    [Serializable]
    public class NegativeValuePassedException : Exception
    {
        public NegativeValuePassedException() { }

        public NegativeValuePassedException(string message)
            : base(message) { }
    }

    public class IncorrectTimeException : Exception
    {
        public IncorrectTimeException() { }

        public IncorrectTimeException(string message)
            : base(message) { }
    }

}
