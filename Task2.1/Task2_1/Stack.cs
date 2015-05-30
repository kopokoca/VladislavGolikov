using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Stack<Type>
    {
        private StackElement head;

        private class StackElement
        {
            public Type value { get; set; }
            public StackElement next { get; set; }
        }

        /// <summary>
        /// Добавление элемента в стек
        /// </summary>
        public void Push(Type value)
        {
            StackElement newElement = new StackElement();
            newElement.next = head;
            newElement.value = value;
            head = newElement;
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Стек пуст");
            }

            head = head.next;
        }

        /// <summary>
        /// Проверка на пустоту
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Возвращает элемент вершины
        /// </summary>
        public Type Top()
        {
            return head.value;
        }

        /// <summary>
        /// Вывод стека на экран
        /// </summary>
        public void PrintStack()
        {
            StackElement temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
