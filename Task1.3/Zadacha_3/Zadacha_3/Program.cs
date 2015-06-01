using System;

namespace Zadacha_3
{
    /// <summary>
    /// Этот класс сортирует массив
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Этот метод сортирует массив методом пузырька
        /// </summary>
        /// <returns>Строка с отсортированными элементами</returns>
        public static string BubbleSort(int[] array, int numb)
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
            result = BubbleSort(array, number);

        }
    }
}
