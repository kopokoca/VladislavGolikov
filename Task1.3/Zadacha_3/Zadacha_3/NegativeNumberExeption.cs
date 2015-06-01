using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    /// <summary>
    /// Исключение появляется при попытке ввода отрицательного числа
    /// </summary>
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
