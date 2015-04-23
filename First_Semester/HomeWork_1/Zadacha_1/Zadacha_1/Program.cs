using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Factorial
    {
        public static int factorial(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                int result = 1;
                for (int i = number; i > 1; --i)
                {
                    result = result * i;
                }
                return result;
            }
           
        }

        public static void Main()
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int result = factorial(number);
            if (result != 0)
            {
                Console.WriteLine("Факториал числа: " + result);
            }
            else
            {
                Console.WriteLine("Число должно быть неотрицательным!");
            }
           
        }
    }
}