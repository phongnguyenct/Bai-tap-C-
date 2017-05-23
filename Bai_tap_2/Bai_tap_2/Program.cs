using System;

namespace Bai_tap_2
{
	class MainClass
	{
		struct DIEM
		{
			public double x, y;
		}
		public static void Main(string[] args)
		{
			double a, b, c;
			double h;
			DIEM M;

			Console.WriteLine("Nhap vao diem M");
			Console.WriteLine("Toa do x cua M la: ");
			M.x = int.Parse(Console.ReadLine());
			Console.WriteLine("Toa do y cua M la: ");
			M.y = int.Parse(Console.ReadLine());

			Console.WriteLine("Nhap he so cua duong thang: ");
			Console.WriteLine("He so a: ");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("He so b: ");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("He so c: ");
			c = int.Parse(Console.ReadLine());

			h = Math.Abs(a * M.x + b * M.y + c) / Math.Sqrt(a * a + b * b);
			Console.WriteLine("Khoang cach tu diem M den duong thang cho truoc la {0}", Math.Round(h, 1));
			Console.ReadLine();
		}
	}
}
