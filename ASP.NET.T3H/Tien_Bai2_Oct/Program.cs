using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_Bai2_Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chay ham Run chuong trinh
            RunProgram();
        }

        //Chay chuong trinh
        public static void RunProgram()
        {
            //Phim chuc nang
            char key = new char();

            //Khai bao mang
            int[] a = new int[1];

            //Cac loai tong
            int tong, tongLe, tongChan;

            while (true)
            {
                //Hien thi menu ra cho nguoi dung chon
                HienThiMenu();

                //Nguoi dung nhap phim chuc nang
                NhapPhimChucNang(out key);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                //Kiem tra va thuc hien chuc nang
                if (key == '1')
                {
                    PhatSinhMang(ref a);
                    XuatMang(a);
                }
                else if (key == '2')
                {
                    XuatMang(a);
                }
                else if (key == '3')
                {
                    XuatMang(a);
                    Console.WriteLine("Tong cac so trong mang la {0}", TongMang(a, out tong));
                }

                else if (key == '4')
                {
                    XuatMang(a);
                    Console.WriteLine("Tong cac so le trong mang la {0}", TongSoLe(a, out tongLe));
                }

                else if (key == '5')
                {
                    SapXepMangTangDan(ref a);
                    XuatMang(a);
                }

                else if (key == '6')
                {
                    SapXepMangGiamDan(ref a);
                    XuatMang(a);
                }
                else if (key == '7')
                {
                    InLonNhat(a);
                }
                else if (key == 'x')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nNhap sai => Nhap lai ! ");
                }

                Console.WriteLine("\nBam phim bat ki de tiep tuc");
                Console.ReadKey(false);
                //Xoa man hinh
                Console.Clear();
            }
        }


        //Ham tinh tong cac so trong day so
        public static int TongMang(int[] a, out int tong)
        {
            tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        //Ham tinh tong cac so le trong day so
        public static int TongSoLe(int[] a, out int tong)
        {
            tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                    tong += a[i];
            }
            return tong;
        }

        //Ham tinh tong cac so chan trong day so
        public static int TongSoChan(int[] a, out int tong)
        {
            tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    tong += a[i];
            }
            return tong;
        }

        //Sap xep mang tang dan
        public static void SapXepMangTangDan(ref int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        //Sap xep mang giam dan
        public static void SapXepMangGiamDan(ref int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public static void InLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }
            Console.WriteLine("Gia tri lon nhat cua mang la: {0}", max);
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

        //Ham hien thi menu cho nguoi dung chon
        public static void HienThiMenu()
        {
            //Dat mau cho chu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||==Phep tinh tren day so nguyen==||");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||********************************||");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("||1. Phat sinh mang               ||");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||2. Xuat mang                    ||");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("||3. Tong cac so trong mang       ||");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("||4. Tong cac so le trong mang    ||");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("||5. Sap xep tang dan             ||");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("||6. Sap xep giam dan             ||");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("||7. Gia tri lon nhat trong mang  ||");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("||x. Thoat chuong trinh           ||");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("=> Moi ban lua chon: ");
        }

        //Ham nhap phim chuc nang (1,2,3,x,...)
        public static void NhapPhimChucNang(out char key)
        {
            key = Console.ReadKey(false).KeyChar;
        }
    }
}
