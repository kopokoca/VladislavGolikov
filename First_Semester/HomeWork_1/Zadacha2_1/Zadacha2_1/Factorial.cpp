using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Console.ReadKey();
		}
	}
}
/*
#include <iostream>
#include <locale.h>
#include <cstdlib>

using namespace std;

namespace FirstTask
{
	class Factorial
	{
		public static int factorial(int number)
		{
			int result = 1;
			for (int i = number; i > 1; --i)
			{
				result = result * i;
			}
		}

		public static void Main()
		{
			Console.WriteLine("Введите число: ");
			int number = int.Parse(Console.ReadLine());;
			int result = factorial(number);
			Console.WriteLine("Факториал числа: " + result);
		}
	}
}
*/