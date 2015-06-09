using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    /// <summary>
    /// Исключение появляется при попытке открыть несуществующий файл
    /// </summary>
    [Serializable]
    public class FileNotFound : Exception
    {
        public FileNotFound() { }
        public FileNotFound(string message) : base(message) { }
        public FileNotFound(string message, Exception inner) : base(message, inner) { }
        protected FileNotFound(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
