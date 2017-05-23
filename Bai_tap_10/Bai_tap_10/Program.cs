using System;

namespace Bai_tap_10
{
	struct CANHAN
	{
		public string ten;
		public double thunhap;
		public int npt;
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			CANHAN C;
			double thue = C.thunhap - 4 - C.npt * 1.6;

			Console.WriteLine("Nhap vao ten ca nhan: ");
			C.ten = Console.ReadLine();

			Console.WriteLine("Nhap vao thu nhap nam: ");
			C.thunhap = int.Parse(Console.ReadLine());

			Console.WriteLine("So nguoi phu thuoc: ");
			C.npt = int.Parse(Console.ReadLine());

			if (0 <= C.thunhap && C.thunhap <= 60)
				thue = C.thunhap - 4 - C.npt * 1.6;

			else if (60 < C.thunhap && C.thunhap <= 120)
				thue = C.thunhap - 4 - C.npt * 1.6;

		}
	}
}
