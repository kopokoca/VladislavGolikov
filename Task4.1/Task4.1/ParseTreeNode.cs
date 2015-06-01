using System;

namespace Task4_1
{
    /// <summary>
    /// Класс для узлов дерева
    /// </summary>
    abstract class ParseTreeNode
    {
        /// <summary>
        /// Печатает дерево
        /// </summary>
        public abstract string PrintTree();

        /// <summary>
        /// Считает выражение
        /// </summary>
        public abstract int Calculate();

        /// <summary>
        /// Добавление элементов в дерево
        /// </summary>
        public abstract bool AddElement(ParseTreeNode treeElement);
    }
}
