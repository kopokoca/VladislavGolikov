using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    [Serializable]
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() { }
        public NegativeNumberException(string message) : base(message) { }
        public NegativeNumberException(string message, Exception inner) : base(message, inner) { }
        protected NegativeNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
