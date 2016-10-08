using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh_Bai02_Array_Oct
{
    class Thinh_Bai02_Array_Oct
    {
        public static void PrintMenu(ArrayList arrInt)
        {
            while (true)
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Thao tac tren mang -So nguyen");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1. Phat sinh mang.\n2. Xuatmang\n3.Tinh tong gia tri cac phan tu trong mang\n" +
                "4. Tong cac phan tu co gia tri la so le.\n5. Sap xep gia tri cac phan tu trong mang tang dan\n6. Sap xep gia tri cac phan tu trong mang giam dan\n.7 Gia tri lon nhat trong mang\n x.Thoat");
                string ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        PhatSinhMang(arrInt);
                        break;
                    case "2":
                        Console.WriteLine("Mang hien tai:");
                        XuatMang(arrInt);
                        break;
                    case "3":
                        TinhTongDay(arrInt);
                        break;
                    case "4":
                        TinhTongLe(arrInt);
                        break;
                    case "5":
                        SapXepTang(arrInt);
                        break;
                    case "6":
                        SapXepGiam(arrInt);
                        break;
                    case "7":
                        TimMax(arrInt);
                        break;
                    default:
                        break;
                }

                if (ch != "1" || ch != "2" || ch != "3" || ch != "4" || ch != "5" || ch != "6" || ch != "7") break;
            }

        }

        private static void SapXepGiam(ArrayList arrInt)
        {
            Console.Clear();
            // Console.WriteLine("Mang hien tai:");
            // XuatMang(arrInt);
            arrInt.Sort();
            arrInt.Reverse();
            Console.WriteLine("Mang da sap xep giam dan:");
            XuatMang(arrInt);
            PrintMenu(arrInt);
        }

        private static void TimMax(ArrayList arrInt)
        {
            Console.Clear();
            XuatMang(arrInt);
            int max=(int)arrInt[0];
            foreach(int i in arrInt){
                if(max<i) max=i; 
            }
            Console.WriteLine("So lon nhat trong mang la: {0}",max);
            PrintMenu(arrInt);
        }

        private static void SapXepTang(ArrayList arrInt)
        {
            Console.Clear();
            //C1: arrInt.Sort();
            //C2:
            for (int i = arrInt.Count-1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((int)arrInt[j] > (int)arrInt[j + 1])
                    {
                        int tmp =(int) arrInt[j];
                        arrInt[j]=arrInt[j+1];
                        arrInt[j+1]=tmp;
                    }
                }
            }
                Console.WriteLine("Mang da sap xep tang dan:");
            XuatMang(arrInt);
            PrintMenu(arrInt);
        }

        private static void TinhTongLe(ArrayList arrInt)
        {
            Console.Clear();
            int tongLe = 0;
            foreach (int i in arrInt)
            {
                if (i % 2 != 0)
                {
                    tongLe += i;
                }
            }
            Console.WriteLine("Tong cac so le: {0}", tongLe);
            PrintMenu(arrInt);
        }

        private static void TinhTongDay(ArrayList arrInt)
        {
            Console.Clear();
            int tongDay = 0;
            foreach (int i in arrInt)
            {
                tongDay += i;
            }
            Console.WriteLine("Tong day hien tai: {0}", tongDay);
            PrintMenu(arrInt);
        }

        private static void XuatMang(ArrayList arrInt)
        {
           
            //Console.WriteLine("Mang hien tai:");
            for (int i = 0; i < arrInt.Count; i++)
            {
                Console.Write(" {0}", arrInt[i]);
            }
            PrintMenu(arrInt);

        }

        public static void PhatSinhMang(ArrayList arrInt)
        {
            Console.WriteLine("1. Chuc nang phat sinh mang\n Nhap so luong phan tu cua mang can phat sinh:");
            int n=int.MinValue;
            Thinh_TinhToanDaySo_28Sep.Thinh_TinhToanDaySo_28Sep.CheckNumber(ref n, "So luong phan tu phai lon hon 0: ", limitMin: 0, limitMax: int.MaxValue);
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arrInt.Add(rd.Next(10, 100));
            }
            Console.Clear();
            Console.WriteLine("Sinh mang thanh cong!");
            PrintMenu(arrInt);
           
            
        }
        static void Main(string[] args)
        {
            ArrayList arrInt = new ArrayList();
            PrintMenu(arrInt);
            Console.ReadLine();
        }
    }
}
