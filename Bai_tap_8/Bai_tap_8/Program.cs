using System;

namespace Bai_tap_8
{
	struct KHACHHANG
	{
		public string ten;
		public double quangduong;
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			double price;
			KHACHHANG K;

			Console.Write("Nhap vao ten khach hang: ");
			K.ten = Console.ReadLine();

			Console.Write("Nhap vao quang duong di: ");
			K.quangduong = Convert.ToInt32(Console.ReadLine());

			if (K.quangduong <= 1)
				price = K.quangduong * 11000;
			else
				price = 11000 + (K.quangduong - 1) * 9000;

			Console.WriteLine("Quang duong di duoc la {0}", price);
			Console.ReadLine();
		}
	}
}
