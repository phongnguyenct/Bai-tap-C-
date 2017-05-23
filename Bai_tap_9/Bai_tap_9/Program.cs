using System;

namespace Bai_tap_9
{

	class MainClass
	{
		public static void Main(string[] args)
		{
			string name;
			double electric;
			double gia = 0.0;

			Console.Write("Nhap vao ten nguoi dung: ");
			name = Console.ReadLine();

			Console.Write("Nhap vao so kw dien su dung: ");
			electric = double.Parse(Console.ReadLine());

			if (electric <= 50)
				gia = electric * 500;

			else if (50 < electric && electric <= 100)
				gia = 25000 + (electric - 50) * 650;

			else if (100 < electric && electric <= 200)
				gia = 57500 + (electric - 100) * 850;

			else if (200 < electric && electric <= 350)
				gia = 142500 + (electric - 200) * 1100;

			else if (electric > 350)
				gia = 307599 + (electric - 350) * 1300;
			
			Console.WriteLine("Gia tien la {0}", gia);
			Console.ReadLine();
		}
	}
}
