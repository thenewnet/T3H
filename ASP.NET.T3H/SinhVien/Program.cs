using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class Program
    {

        public struct SinhVien
        {
            public string name { get; set; }
            public string address { get; set; }
            public string codeNumber { get; set; }
            public double diemMon1 { get; set; }
            public double diemMon2 { get; set; }
        }

        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            Console.Write("Nhap ten: ");
            sv.name = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            sv.address = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            sv.codeNumber = Console.ReadLine();
            Console.Write("Nhap diem mon 1: ");
            sv.diemMon1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon 2: ");
            sv.diemMon2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===Thong tin sinh vien===");
            Console.WriteLine("Ho va ten: {0}", sv.name);
            Console.WriteLine("Dia chi: {0}", sv.address);
            Console.WriteLine("Ma sinh vien: {0}", sv.codeNumber);
            Console.WriteLine("Diem mon 1: {0}", sv.diemMon1);
            Console.WriteLine("Diem mon 2: {0}", sv.diemMon2);
            Console.ReadKey();
        }
    }
}
