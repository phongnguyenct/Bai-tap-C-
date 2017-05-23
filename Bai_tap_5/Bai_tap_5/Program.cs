using System;

namespace Bai_tap_5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Nhap vao so n: ");
			int n = int.Parse(Console.ReadLine());
			if (n <= 999 && n >= 100)
			{
				Console.WriteLine("Nhap dung!");

				int a = n % 10;
				Console.WriteLine("Chu so hang don vi la {0}", a);

				int b = n / 100;
				Console.WriteLine("Chu so hang tram la {0}", b);
			}
			else {
				Console.WriteLine("Nhap sai! Nhap lai!");
			}

			Console.ReadLine();
			Console.ReadKey();

		}
	}
}
