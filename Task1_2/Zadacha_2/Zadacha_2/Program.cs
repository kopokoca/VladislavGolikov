using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
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

    public class Fib
    {
// Метод вычисляет числа Фибонначи вплоть до заданного кол-ва, возвращает строку с ответом
        public static string fib(int number)
        {
            if (number <= 0)
            {
                throw new NegativeNumberException();
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
