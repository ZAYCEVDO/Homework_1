using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину стороны треугольника:");
			int katet = int.Parse(Console.ReadLine());
			int countStars = 1; //количество * в строке
			int countSpaces = katet;
			string str = "";
			for(int i = 0; i < katet; i++)
			{
				str = new string(' ', countSpaces - 1) + new string ('*', countStars);
				countSpaces--;
				countStars += 2;
				Console.WriteLine(str);
			}
		}
	}
}
