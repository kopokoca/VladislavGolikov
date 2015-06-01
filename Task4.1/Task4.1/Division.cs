﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    /// <summary>
    /// Класс для деления
    /// </summary>
    class Division : Operator
    {
        public override int Calculate()
        {
            if (RightChild.Calculate() == 0)
            {
                throw new DivideByZero("Деление на ноль");
            }

            return LeftChild.Calculate() / RightChild.Calculate();
        }

        public override string Print()
        {
            return " /";
        }
    }
}
