using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueList list = new UniqueList();
            list.AddListElement(5);
            list.AddListElement(2);
            list.RemoveListElement(2);
        }
    }
}
