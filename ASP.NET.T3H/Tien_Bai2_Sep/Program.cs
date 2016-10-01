using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_Bai2_Sep
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        //Chay chuong trinh
        public static void RunProgram() 
        {
            string daySo;
            char key = new char();
            int tong, tongLe, tongChan;
            NhapDaySo(out daySo);

            while (true)
            {
                HienThiMenu(daySo);
                NhapPhimChucNang(out key);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                if (key == '1')
                {
                    Console.WriteLine("\nTong cac so trong day so {0} là {1}",
                        daySo, TongDaySo(daySo, out tong));
                }
                else if (key == '2')
                {
                    Console.WriteLine("\nTong cac so le cua day so {0} là {1}",
                        daySo, TongSoLe(daySo, out tongLe));
                }
                else if (key == '3')
                {
                    Console.WriteLine("\nTong cac so chan cua day so {0} là {1}",
                        daySo, TongSoChan(daySo, out tongChan));
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
                Console.Clear();
            }
        }

        //Ham tach lay cac so trong day so, tra ve 1 list so
        public static List<int> TachChuoi(string daySo)
        {
            List<int> resultList = new List<int>();
            string[] str_tok = daySo.Split(';');
            for (int i = 0; i < str_tok.Length; i++)
            {
                int numIndex;
                bool checkNumber = int.TryParse(str_tok[i], out numIndex);
                if (checkNumber)
                {
                    resultList.Add(numIndex);
                }
                else {
                    resultList.Add(0);
                }
            }
            return resultList;
        }

        //Ham tinh tong cac so trong day so
        public static int TongDaySo(string daySo, out int tong)
        {
            tong = 0;
            List<int> listNumber = TachChuoi(daySo);
            tong = listNumber.Sum();
            return tong;
        }

        //Ham tinh tong cac so le trong day so
        public static int TongSoLe(string daySo, out int tong)
        {
            tong = 0;
            List<int> listNumber = TachChuoi(daySo);
            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i] % 2 == 1)
                    tong += listNumber[i];
            }
            return tong;
        }

        //Ham tinh tong cac so chan trong day so
        public static int TongSoChan(string daySo, out int tong)
        {
            tong = 0;
            List<int> listNumber = TachChuoi(daySo);
            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i] % 2 == 0)
                    tong += listNumber[i];
            }
            return tong;
        }

        //Ham nhap vao day so, cac so cach nhau boi dau ";"
        public static void NhapDaySo(out string daySo)
        {
            Console.Write("Nhap vao day so nguyen (moi so cach nhau boi \";\"): ");
            daySo = Console.ReadLine();
        }

        //Ham hien thi menu cho nguoi dung chon
        public static void HienThiMenu(string daySo) 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Day so nguyen: {0}", daySo);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||==Phep tinh tren day so nguyen==||");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||********************************||");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||1. Tong day so                  ||");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("||2. Tong cac so le trong day so  ||");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("||3. Tong cac so chan trong day so||");
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
