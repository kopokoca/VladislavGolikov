using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    /// <summary>
    /// Исключение создается, когда в выражении есть деление на ноль
    /// </summary>
    [Serializable]
    public class DivideByZero : Exception
    {
        public DivideByZero() { }
        public DivideByZero(string message) : base(message) { }
        public DivideByZero(string message, Exception inner) : base(message, inner) { }
        protected DivideByZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
