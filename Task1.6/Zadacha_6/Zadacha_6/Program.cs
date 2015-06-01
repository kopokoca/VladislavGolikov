using System;

namespace Zadacha_6
{
    /// <summary>
    /// Этот класс выводит эл-ты матрицы по спирали
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Этот метод выводит эл-ты матрицы по спирали
        /// </summary>
        /// <returns>Строка с эл-тами</returns>
        public static string SpiralMethod(int[,] array, int size)
        {
            --size;
            int x = size / 2;
            int y = x;
            string result = Convert.ToString(array[x,y]) + " ";

            if (size == 0)
            {
                return result;
            }

            int lengthOfWay = 2;
            int direction = 1;

            while (x != size - 1 || y != 0)
            {
                for (int i = 0; i != lengthOfWay / 2; ++i)
                {
                    if (x == size - 1 && y == 0)
                    {
                        result += Convert.ToString(array[size, 0]);
                        return result;
                    }

                    switch( direction % 4)
                    {
                        case 1: ++x; break;
                        case 2: ++y; break;
                        case 3: --x; break;
                        case 0: --y; break;
                    }

                    result += Convert.ToString(array[x, y]) + " ";
                }

                ++direction;
                ++lengthOfWay;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите нечетный размер квадратного массива: ");
            int size = int.Parse(Console.ReadLine());

            if (size < 0 || size % 2 == 0)
            {
                Console.Write("Ошибка! Массив должен быть нечетного размера!\n");
                return;
            }

            int[,] array = new int[size, size];

            Console.Write("Введите массив:\n");
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            string result = SpiralMethod(array, size);
            Console.Write("Вывод по спирали:\n" + result);
            Console.Write("\n");
            return;
        }
    }
}
