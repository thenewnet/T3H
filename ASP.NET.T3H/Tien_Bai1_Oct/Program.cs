using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_Bai1_Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1];
            PhatSinhMang(ref a);
            XuatMang(a);
            Console.ReadKey();
        }

        //Phat sinh day so ngau nhien
        public static void PhatSinhMang(ref int[] a)
        {
            NhapPhanTu:
                Console.Write("Nhap so phan tu trong mang: ");

            int n;

            bool check = int.TryParse(Console.ReadLine(), out n);
            if (check)
            {
                a = new int[n];
            }
            else
            {
                Console.WriteLine("Nhap sai => Nhap lai!");
                goto NhapPhanTu;
            }

            int soPhanTu = a.Length;
            Random r = new Random();
            for (int i = 0; i < soPhanTu; i++)
            {
                a[i] = r.Next(10, 100);
            }
        }

        //Xuat day so
        public static void XuatMang(int[] a)
        {
            Console.Write("Mang so nguyen: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "; ");
            }
            Console.WriteLine();
        }
    }
}
