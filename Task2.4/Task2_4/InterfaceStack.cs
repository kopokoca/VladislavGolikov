using System;

namespace StackCalculator
{
    /// <summary>
    /// Интерфейс стека
    /// </summary>
    public interface InterfaceStack<Type>
    {
        /// <summary>
        /// Добавление эл-та в стек
        /// </summary>
        void Push(Type value);

        /// <summary>
        /// Удаление эл-та из стека
        /// </summary>
        void Pop();

        /// <summary>
        /// Проверка на пустоту
        /// </summary>
        bool IsEmpty();

        /// <summary>
        /// Возвращает эл-т из вершины
        /// </summary>
        Type Peek();

        /// <summary>
        /// Вывод стека на экран
        /// </summary>
        void PrintStack();
    }
}
