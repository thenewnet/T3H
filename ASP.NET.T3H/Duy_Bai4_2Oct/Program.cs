using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy_Bai4_2Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Thao tac tren mang - So nguyen");
            Console.WriteLine("******************************************");
            Console.WriteLine("1. Phat sinh mang.\n2. Xuatmang\n3. Tinh tong gia tri cac phan tu trong mang\n4. Tong cac phan tu co gia tri la so le.\n5. Sap xep gia tri cac phan tu trong mang tang dan\n6. Sap xep gia tri cac phan tu trong mang giam dan\n7. Gia tri lon nhat trong mang\n x. Thoat");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    PhatSinhMang();
                    break;
                case "2":
                    XuatMang();
                    break;
                case "3":
                    Sum();
                    break;
                case "4":
                    SumOdd();
                    break;
                case "5":
                    SapXepTang();
                    break;
                case "6":
                    SapXepGiam();
                    break;
                case "7":
                    Max();
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public static void PhatSinhMang()
        {

        }
    }
}
