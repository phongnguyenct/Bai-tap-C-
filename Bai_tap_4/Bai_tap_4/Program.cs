using System;

namespace Bai_tap_4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Ho ten nhan vien: ");
			string hoTen = Console.ReadLine();

			Console.Write("Ngay thang nam sinh cua nhan vien: ");
			DateTime sinhNhat = DateTime.Parse(Console.ReadLine());

			int tuoi = DateTime.Now.Year - sinhNhat.Year;
			Console.WriteLine("Tuoi hien tai cua nguoi do: {0}", tuoi);
			if (tuoi >= 60)
				Console.WriteLine("Den tuoi nghi huu");
			else
				Console.WriteLine("Chua den tuoi nghi huu");

			DateTime ngayHuu = new DateTime(sinhNhat.Year + 60, sinhNhat.Month, sinhNhat.Day);
			Console.WriteLine("Ngay ve huu la {0} / {1} / {2}", ngayHuu.Day, ngayHuu.Month, ngayHuu.Year); 


			Console.ReadLine();

		}
	}
}
