using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    [Serializable]
    public class AddExistentElementException : Exception
    {
        public AddExistentElementException() { }
        public AddExistentElementException(string message) : base(message) { }
        public AddExistentElementException(string message, Exception inner) : base(message, inner) { }
        protected AddExistentElementException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
