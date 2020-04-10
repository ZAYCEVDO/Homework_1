using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите ваш возраст:");
			int age = int.Parse(Console.ReadLine());
			if(((age % 10 == 0) || (age % 10 >= 5) || ((age % 100 > 10) && (age % 100 < 15))) && (age < 100))
			{
				Console.WriteLine("Мне " + age + " лет");
			}
			else if(((age % 100 != 11) && (age % 10 == 1)) && (age < 100))
			{
				Console.WriteLine("Мне " + age + " год");
			}
			else if((((age % 10 < 5) && (age % 10 > 1)) && ((age % 100 < 10) || (age % 100 > 20))) && (age < 100))
			{
				Console.WriteLine("Мне " + age + " года");
			}
			else if(age < 0)
			{
				Console.WriteLine("Ошибка!!! Я еще не родился!");
			}
			else if(age > 99)
			{
				Console.WriteLine("Ошибка!!! Я уже слишком стар для этой программы!");
			}
		}
	}
}
