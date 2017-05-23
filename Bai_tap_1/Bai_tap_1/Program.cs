using System;

namespace Bai_tap_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Ten nhan vien: ");
			string hoTen = Console.ReadLine();

			Console.Write("Ngay sinh: ");
			DateTime ngaySinh = DateTime.Parse(Console.ReadLine());

			int tuoi = DateTime.Now.Year - ngaySinh.Year;
			Console.WriteLine("Ngay sinh cua nhan vien la {0}", tuoi);
			Console.ReadLine();

		}
	}
}
