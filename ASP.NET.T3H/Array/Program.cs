using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen nguyen = new MangSoNguyen();
            ConsoleKey key;
            do
            {
                menu();
                Choose(nguyen, out key);
            } while (key != ConsoleKey.X);
            
        }
        #region nhap thong tin
        private static void nhap(MangSoNguyen a)
        {
            Console.WriteLine("nhap so phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            a.MangNGuyen = new int[n];
            Console.WriteLine("mang co gia tri ngau nhien tu 10-100 da duoc tao");
            Random rand = new Random();
            for(int i=0;i<n;i++)
            {
               
                a.MangNGuyen[i] = rand.Next(10, 100);
            }

        }
        #endregion

        #region xuat mang
        private static void xuat(MangSoNguyen a)
        {

            for (int i = 0; i < a.MangNGuyen.Length; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a.MangNGuyen[i]);
            }
        }
        #endregion

        #region menu
        private static void menu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Thao tac tren mang - so nguyen");
            Console.WriteLine("***************************************\n\n");
            Console.WriteLine("1.Phat sinh mang");
            Console.WriteLine("2.Xuat mang");
            Console.WriteLine("3.Tong cac gia tri cac phan tu trong mang");
            Console.WriteLine("4.Tong cac phan tu co gia tri la so le");
            Console.WriteLine("5.sap xep gia tri cac phan tu trong mang tang dan");
            Console.WriteLine("6.sap xep gia tri cac phan tu trong mang giam dan");
            Console.WriteLine("7.Gia tri lon nhat trong mang");
            Console.WriteLine("x.Thoat");
            Console.Write("Chon thao tac :");
        }

        
        #endregion

        #region lua chon trong menu
        private static void Choose(MangSoNguyen a, out ConsoleKey key)
        {
            key = Console.ReadKey(false).Key;
            Console.WriteLine();
            switch (key)
            {
                case ConsoleKey.D1:
                    nhap(a);    
                    break;
                case ConsoleKey.D2:
                    xuat(a);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Tong cac gia tri cac phan tu trong mang la: {0}",a.tongMang(a));
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Tong cac phan tu co gia tri la so le la: {0}",a.tongLe(a));
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("gia tri cac phan tu trong mang da duoc sap xep tang dan");
                    a.tangDan(a);
                    break;
                case ConsoleKey.D6:
                     Console.WriteLine("gia tri cac phan tu trong mang da duoc sap xep giam dan");
                   a.giamDan(a);
                    break;
                case ConsoleKey.D7:
                      Console.WriteLine("Gia tri lon nhat trong mang la: {0}",a.max(a));
                    break;
                case ConsoleKey.X:
                    Console.WriteLine("CAM ON DA THOAT!!");
                    break;
                default:
                    Console.WriteLine("chi duoc nhap tu 1-7 va x de thoat");
                    break;

            }
            Console.ReadKey(); //stop man hinh de xem ket qua
            Console.Clear();  //xoa man hinh
        }

        #endregion

    }
}
