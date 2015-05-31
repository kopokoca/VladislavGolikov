using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable();
            hash.AddElementHashTable("s");
            hash.AddElementHashTable("o");
            hash.AddElementHashTable("m");
            hash.RemoveElement("o");
            hash.PrintHashTable();
        }
    }
}
