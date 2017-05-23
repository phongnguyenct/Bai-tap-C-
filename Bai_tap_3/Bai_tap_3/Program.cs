using System;

namespace Bai_tap_3
{
	class MainClass
	{
		struct PHAN_SO
		{
			public int tuSo, mauSo;
		}
		public static void Main(string[] args)
		{
			PHAN_SO x, y;

			Console.WriteLine("Nhap vao tu so cua phan so thu nhat: ");
			x.tuSo = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao mau so cua phan so thu nhat: ");
			x.mauSo = int.Parse(Console.ReadLine());


			Console.WriteLine("Nhap vao tu so cua phan so thu hai: ");
			y.tuSo = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhap vao mau so cua phan so thu hai: ");
			y.mauSo = int.Parse(Console.ReadLine());

			int tu = x.tuSo * y.tuSo;
			int mau = x.mauSo * y.mauSo;

			Console.WriteLine("Ket qua la {0} / {1}", tu, mau);
			Console.ReadLine();
		}
	}
}
