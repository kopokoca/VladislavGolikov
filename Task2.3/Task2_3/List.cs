using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class List<T>
    {
        private ListElement head;

        private class ListElement
        {
            public T value { get; set; }
            public ListElement next { get; set; }
        }

        /// <summary>
        /// Добавление элемента на вершину списка
        /// </summary>
        public void InsertAsHead(T value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;
            newElement.next = head;
            head = newElement;
        }

        /// <summary>
        /// Удаление заданного элемента
        /// </summary>
        public void DeleteByValue(T value)
        {
            if (Equals(head.value, value))
            {
                head = head.next;
                return;
            }
            ListElement temp = new ListElement();
            temp = head;
            while (temp != null)
            {
                if (Equals(temp.value, value))
                {
                    temp = temp.next;
                    return;
                }
                temp = temp.next;
            }
        }

        /// <summary>
        /// Проверка на пустоту
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Проверка на пустоту
        /// </summary>
        public bool IsContains(T value)
        {
            ListElement temp = head;
            while (temp != null)
            {
                if (Equals(temp.value, value))
                    return true;
                temp = temp.next;
            }
            return false;
        }

        /// <summary>
        /// Вывод списка на экран
        /// </summary>
        public void PrintList()
        {
            ListElement temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Возвращает размер списка
        /// </summary>
        public int ListSize()
        {
            ListElement tmp = head;
            int size = 0;
            while (tmp != null)
            {
                size++;
                tmp = tmp.next;
            }
            return size;
        }
    }
}
