using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class sort
    {
        public static int[] bubbleSort(int[] array, int numb)
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
  
            for (int i = 0; i < numb; ++i)
            {
                Console.WriteLine(array[i] + " ");
            }

            return array;
        }

        public static void Main()
        {
            Console.WriteLine("Введите кол-во чисел в массиве: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            Console.WriteLine("Введите массив: ");

            for (int i = 0; i < number; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            array = bubbleSort(array, number);

        }
    }
}
