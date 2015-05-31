using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    public class HashTable
    {
        private const int hashTableSize = 100;

        private List<int>[] hashTableList;

        public delegate int Hashing(string value);
        private Hashing hashFunction;

        public HashTable()
        {
            hashTableList = new List<int>[hashTableSize];

            for (int i = 0; i < hashTableList.Length; i++)
            {
                this.hashTableList[i] = new List<int>();
            }

            this.hashFunction = HashFunction;
        }

        public HashTable(Hashing hashFunc)
            : this()
        {
            this.hashFunction = hashFunc;
        }

        /// <summary>
        ///  Возвращает размер хеш-таблицы
        /// </summary>
        public int Length()
        {
            return hashTableList.Length;
        }

        /// <summary>
        /// Возвращает хеш-код указанного ключа
        /// </summary>
        private int GetHash(string value)
        {
            return hashFunction(value);
        }

        /// <summary>
        ///  Добавление элемента
        /// </summary>
        public void AddElementHashTable(string value)
        {
            int index = GetHash(value);
            this.hashTableList[index].InsertAsHead(value);
        }

        /// <summary>
        ///  Хеш-функция
        /// </summary>
        private int HashFunction(string value)
        {
            int result = 0;
            int factor = 89;

            for (int i = 0; i < value.Length; i++)
            {
                result = (result * factor + value[i]) % hashTableSize;
            }

            return result;
        }

        /// <summary>
        /// Проверка на пустоту
        /// </summary>
        public bool IsContains(string value)
        {
            int index = GetHash(value);
            return hashTableList[index].IsContains(value);
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        public void RemoveElement(string value)
        {
            int index = GetHash(value);
            hashTableList[index].DeleteByValue(value);
        }

        /// <summary>
        /// Вывод таблицы на экран
        /// </summary>
        public void PrintHashTable()
        {
            for (int i = 0; i < hashTableSize; ++i)
            {
                hashTableList[i].PrintList();
            }
        }
    }
}
