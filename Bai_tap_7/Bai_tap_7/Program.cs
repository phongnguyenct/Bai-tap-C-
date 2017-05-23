using System;

namespace Bai_tap_7
{
	class MainClass
	{
		struct HOC_SINH
		{
			public string name;
			public double mark;
		}
		public static void Main(string[] args)
		{
				HOC_SINH hs;

				Console.Write("Nhap vao ho ten hoc sinh: ");
				hs.name = Console.ReadLine();

				Console.Write("Nhap vao diem trung binh: ");
				hs.mark = double.Parse(Console.ReadLine());

				if (hs.mark > 8.5)
					Console.WriteLine("Hoc luc gioi!");

				else if (hs.mark >= 6.5 && hs.mark < 8.5)
					Console.WriteLine("Hoc luc kha!");

				else if (hs.mark >= 5 && hs.mark < 6.5)
					Console.WriteLine("Hoc luc trung binh!");

				else if (hs.mark < 5)
					Console.WriteLine("Hoc luc yeu!");

				Console.ReadLine();
		}
	}
}
