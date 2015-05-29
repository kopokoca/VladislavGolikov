using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_7
{
    public class Program
    {
        static void swap(int[,] array, int num1, int num2)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int temp = array[i, num1];
                array[i, num1] = array[i, num2];
                array[i, num2] = temp;
            }
        }

      public static string selectionSort(int[,] array, int m, int n)
        {
            int min = 0;

            for (int i = 0; i < m; i++)
            {
                min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[0, j] < array[0, min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    swap(array, i, min);
                }
            }

            string result = "";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result += array[i, j] + " ";
                }
            }

            return result;
        }

       public static void Main()
        {
            Console.Write("Введите количество строк в массиве: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int width = Int32.Parse(Console.ReadLine());
            int[,] array = new int[height, width];
            Random rand = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            selectionSort(array, height, width);

            Console.WriteLine("Матрица, отсортированная по столбцам:");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
