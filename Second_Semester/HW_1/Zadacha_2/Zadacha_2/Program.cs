using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    public class Fib
    {
// Метод вычисляет числа Фибонначи вплоть до заданного кол-ва, возвращает строку с ответом
        public static string fib(int number)
        {
            if (number <= 0)
            {
                return "Ошибка!";
            }
            else
            {
                Console.WriteLine("Результат: ");

                string result = "1 ";
                int num1 = 0;
                int num2 = 1;
                for (int i = 1; i <= number - 1; ++i)
                {
                    num2 = num1 + num2;
                    num1 = num2 - num1;
                    result = result + num2 + " ";
                }
                return result;
            }

        }

        public static void Main()
        {
            Console.WriteLine("Введите кол-во чисел Фибонначи: ");
            int number = int.Parse(Console.ReadLine());
            string result = fib(number);
            Console.WriteLine(result);
        }

        public static object fib()
        {
            throw new NotImplementedException();
        }
    }
}
