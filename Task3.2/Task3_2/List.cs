using System;

namespace Task3_2
{
   public class List <T>
    {
        public ListElement head;

        public class ListElement
        {
            public string value { get; set; }
            public ListElement next { get; set; }
        }

        /// <summary>
        /// Добавление элемента в список
        /// </summary>
        public void InsertAsHead(string value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;
            newElement.next = head;
            head = newElement;
        }

        /// <summary>
        /// Удаление заданного элемента
        /// </summary>
        public void DeleteByValue(string value)
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
        /// Проверка на существование элемента в списке
        /// </summary>
        public bool IsContains(string value)
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
        /// Функция возвращает размер списка
        /// </summary>
        public int ListSize()
        {
            ListElement temp = head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
