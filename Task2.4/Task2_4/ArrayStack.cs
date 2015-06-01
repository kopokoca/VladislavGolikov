using System;
using StackCalculator;

namespace StackCalculator
{
    /// <summary>
    ///  В классе находятся возможности действий со стеком (реализация с помощью массива)
    /// </summary>
    public class ArrayStack<T> : InterfaceStack<T>
    {
        private int lastElementIndex;
        private T[] stack;

        public ArrayStack(int size)
        {
            lastElementIndex = 0;
            stack = new T[size];
        }

        public void Push(T value)
        {
            if (lastElementIndex == stack.Length - 1)
                Array.Resize(ref stack, stack.Length * 2);
            stack[lastElementIndex] = value;
            lastElementIndex++;
        }

        public void Pop()
        {
            if (lastElementIndex == 0)
                throw new InvalidOperationException("Stack is empty!");
            lastElementIndex--;
        }

        public bool IsEmpty()
        {
            return lastElementIndex == 0;
        }

        public T Peek()
        {
            if (lastElementIndex == 0)
                throw new InvalidOperationException("Stack is empty!");
            return stack[lastElementIndex - 1];
        }

        public void PrintStack()
        {
            for (int i = lastElementIndex; i >= 0; i--)
                Console.Write("{0} ", stack[i]);
            Console.WriteLine();
        }
    }
}