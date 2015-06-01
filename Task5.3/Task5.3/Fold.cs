using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    /// <summary>
    /// Класс с реализацией функции Fold
    /// </summary>
    public class FoldClass<T>
    {
        /// <summary>
        /// Функция берет список, текущие элемент и функцию
        /// </summary>
        /// <returns>Возвращает новое накопленное значение</returns>
        public T Fold(List<T> list, T value, Func<T, T, T> function)
        {
            List<int> foldList = new List<int>();

            foreach (var temp in list)
            {
                value = function(value, temp);
            }

            return value;
        }
    }
}
