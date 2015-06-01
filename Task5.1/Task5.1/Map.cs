using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    /// <summary>
    /// Класс с методом Map
    /// </summary>
    public class MapClass<T>
    {
        /// <summary>
        /// Функция, которая принимает список и функцию, которая преобразует элемент списка
        /// </summary>
        public List<T> Map(List<T> list, Func<T, T> function)
        {
            List<T> mapList = new List<T>();

            foreach (var temp in list)
            {
                mapList.Add(function(temp));
            }

            return mapList;
        }
    }
}
