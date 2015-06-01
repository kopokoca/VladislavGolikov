using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    /// <summary>
    /// Этот класс считает факториал числа.
    /// </summary>
    public class MySpace
    {
        /// <summary>
        /// Этот метод считает факториал числа.
        /// </summary>
        /// <returns>Подсчитанный факториал</returns>
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
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
            int result = Factorial(number);
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