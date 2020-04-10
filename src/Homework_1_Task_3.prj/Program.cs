using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Task_3.prj
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину массива:");
			int length = int.Parse(Console.ReadLine());
			int[] array = new int[length];
			Random rand = new Random();
			int count = 0; // количество нечетных элементов массива
			for(int i = 0; i < array.Length; i++) //заполнение массива случайными числами в диапазоне от 0 до 100
			{
				array[i] = rand.Next(0, 100);
			}
			Console.Write("Массив: ");
			for(int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			for(int i = 0; i < array.Length; i++)
			{
				if ((array[i] % 2)!=0)
				{
					count++;
				}
			}
			int countEven = length - count; //Вычисление количества четных элементов
			Console.WriteLine();
			Console.WriteLine("Количество четных чисел: " + countEven);
			Console.WriteLine("Количество нечетных чисел: " + count);
		}
	}
}
