using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    public class UniqueList : List
    {
        /// <summary>
        /// Добавление элемента
        /// </summary>
        public void AddListElement(int value)
        {
            if (IsContains(value))
            {
                throw new AddExistentElementException("Такой элемент уже существует");
            }

            AddToListElement(value);
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        public override bool RemoveListElement(int value)
        {
            if (!IsContains(value))
            {
                throw new RemoveNonexistentElementException("Такого элемента не существует");
            }

            return base.RemoveListElement(value);
        }
    }
}
