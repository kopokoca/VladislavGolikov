using System;

namespace Task2_3
{
    /// <summary>
    ///  В классе находятся возможности действий с хеш-таблицей
    /// </summary>
    public class HashTable
    {
        private List<string>[] hashSet;
        private int tableSize;

        public HashTable(int tableSize)
        {
            this.tableSize = tableSize;
            hashSet = new List<string>[tableSize];
            for (int i = 0; i < tableSize; ++i)
            {
                hashSet[i] = new List<string>();
            }
        }

        /// <summary>
        /// Хеш-функция
        /// </summary>
        private int HashFunction(string str)
        {
            const int basis = 31;
            int result = str[0];
            int length = str.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                result = (result * basis + str[i]) % tableSize;
            }
            return result;
        }

        /// <summary>
        /// Добавление элемента в таблицу
        /// </summary>
        public void AddToHashTable(string element)
        {
            if (!IsContains(element))
            {
                int key = HashFunction(element);
                hashSet[key].InsertAsHead(element);
            }
        }

        /// <summary>
        /// Проверка на существование элемента в таблице
        /// </summary>
        public bool IsContains(string element)
        {
            int key = HashFunction(element);
            return (hashSet[HashFunction(element)].IsContains(element));
        }

        /// <summary>
        /// Удаление заданного элемента из таблицы 
        /// </summary>
        public void DeleteFromHashTable(string element)
        {
            int key = HashFunction(element);
            if (IsContains(element))
            {
                hashSet[key].DeleteByValue(element);
            }
        }

        /// <summary>
        /// Вывод хеш-таблицы
        /// </summary>
        public void PrintHashTable()
        {
            for (int i = 0; i < tableSize; ++i)
            {
                hashSet[i].PrintList();
            }
        }
    }
}
