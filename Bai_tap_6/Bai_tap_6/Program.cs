using System;

namespace Bai_tap_6
{
	class MainClass
	{
		struct MAT_HANG
		{
			public string Ten;
			public double soLuong;
			public double Gia;
		}
		public static void Main(string[] args)
		{
			MAT_HANG mH;
			double tongTien;

			Console.Write("Nhap vao ten mat hang: ");
			mH.Ten = Console.ReadLine();

			Console.Write("Nhap vao so luong hang: ");
			mH.soLuong = double.Parse(Console.ReadLine());

			Console.Write("Nhap vao gia ca moi don hang: ");
			mH.Gia = double.Parse(Console.ReadLine());

			if (mH.soLuong < 50)
				tongTien = mH.soLuong * mH.Gia;

			else if (mH.soLuong >= 50 && mH.soLuong <= 100)
				tongTien = mH.soLuong * mH.Gia * 0.92;

			else
				tongTien = mH.soLuong * mH.Gia * 0.88;

			Console.WriteLine("Gia tien la {0}", tongTien);
			Console.ReadLine();

		}
	}
}