using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = ReadingFile.ReadFromFile("Solution1.txt");
            Console.WriteLine("Дерево разбора:{0}", tree.PrintParseTree());
             Console.WriteLine("Результат: {0}", tree.CalculateTree());
        }
    }
}
