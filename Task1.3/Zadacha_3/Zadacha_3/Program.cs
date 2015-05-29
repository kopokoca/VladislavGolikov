using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
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

    /// <summary>
    /// Этот метод сортирует массив методом пузырька
    /// </summary>
    /// <returns>Строка с отсортированными элементами</returns>
    public class Sort
    {
        public static string bubbleSort(int[] array, int numb)
        {
            for (int i = 0; i < numb; ++i)
                for (int j = 0; j < numb; ++j)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            Console.WriteLine("Результат: ");

            string result = "";
  
            for (int i = 0; i < numb; ++i)
            {
                result += array[i] + " ";
            }

            return result;
        }

        public static void Main()
        {
            Console.WriteLine("Введите кол-во чисел в массиве: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1)
            {
                throw new NegativeNumberException();
            }

            int[] array = new int[number];
            Console.WriteLine("Введите массив: ");

            for (int i = 0; i < number; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            string result = "";
            result = bubbleSort(array, number);

        }
    }
}
