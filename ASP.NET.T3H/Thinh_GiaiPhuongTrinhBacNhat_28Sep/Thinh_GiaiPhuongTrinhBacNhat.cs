using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh_GiaiPhuongTrinhBacNhat_28Sep
{
    class Thinh_GiaiPhuongTrinhBacNhat
    {
           
        #region Main

        static void Main(string[] args)
        {
            Console.WriteLine("--------------INPUT--------------");
            while (true)
            {
                Console.WriteLine("Nhap he so a:");
                float a = float.MinValue;
                CheckNumber(ref a, "Nhap lai so a:", float.MaxValue, float.MinValue);

                Console.WriteLine("Nhap he so b:");
                float b = float.MinValue;
                CheckNumber(ref b, "Nhap lai so b:", float.MaxValue, float.MinValue);
                Console.WriteLine("-------------KET QUA-------------");
                //Giai phuong trinh
                GiaiPhuongTrinh(a, b);

                //Hoi y kien nguoi dung
                Console.WriteLine("-Nhan C de tiep tuc.\n-Phim bat ky de thoat khoi chuong trinh");
                string answer = Console.ReadLine();
                if (answer.ToUpper() != "C") break;
                Console.Clear();
               
            }
            Console.ReadLine();
            //Nhap so a,b
            
        }

        #endregion

        #region Methods static
        //Ham giai phuong trinh 
        private static void GiaiPhuongTrinh(float a, float b)
        {
            if (a == 0) { Console.WriteLine("Phuong trinh ({0})*x + ({1}) = 0 vo nghiem"); return; }

            Console.WriteLine("Phuong trinh ({0})*x + ({1}) = 0 co nghiem la: {2}", a, b, -(b / a));

        }

        //Phuong thuc kiem tra so nhap vao 
        //-Phai la kieu float
        //-Co gia tri tu limitMin den limitMax
        //-Tra ve gia tri thoa man trong tmp.
        public static void CheckNumber(ref float tmp, string message, float max = 100, float min = float.MinValue)
        {
            bool checkI = false;
            do
            {
                //Neu nhap lan dau thi doc tu man hinh => kiem tra dk so float
                if (tmp == min)
                {
                    checkI = float.TryParse(Console.ReadLine(), out tmp);
                    if (tmp > max) checkI = false;
                }
                //Neu da nhap sai 1 la roi thi dua ra thong bao=> kiem tra dk so float
                else
                {

                    Console.Write(message);
                    checkI = float.TryParse(Console.ReadLine(), out tmp);
                }
                //Neu la so float roi thi kiem tra mien gioi han
                if (tmp > max || tmp <= min) { tmp = -1; checkI = false; }
            } while (!checkI);
        }
        #endregion

    }
}
