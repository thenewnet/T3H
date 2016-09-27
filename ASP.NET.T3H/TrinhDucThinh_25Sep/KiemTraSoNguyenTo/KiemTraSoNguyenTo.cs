using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSoNguyenTo
{
    public class KiemTraSoNguyenTo
    {


        #region Main

        static void Main(string[] args)
        {
            while (true)
            {
                //Hien thi thong bao cho nguoi dung nhap vao so can kiem tra
                bool check = false;
                long num;
                do
                {
                    Console.WriteLine("Nhap so ban can kiem tra:");
                    check = long.TryParse(Console.ReadLine(), out num);
                } while (!check);

                //Kiem tra so do co la so nguyen to va hien thi ket qua;
                Console.WriteLine("{0} {1}", num, IsPrime(num) ? "la so nguyen to" : "Khong phai la so nguyen to");
                Console.WriteLine("{0} {1}", num, IsPrime01(num) ? "la so nguyen to" : "Khong phai la so nguyen to");
                Console.ReadKey();

            }
        }
        #endregion


        #region Methods static

        //c1
        public static bool IsPrime(long num)
        {
            if (num == 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        //c2
        //Cac so nguyen to la cac so le
        //Cac so nguyen to deu co dang 6*k-1 or 6*k+1 tru 2 va 3.

        public static bool IsPrime01(long num)
        {
            if ((num == 2) || (num == 3))
            {
                return true;
            }

            if ((num % 2 == 0) || (num % 3 == 0) || (num < 2))
            {
                return false;
            }

            int i = -1;
            long sqrt_n = (long)Math.Sqrt(num);

            do
            {
                i += 6;
                if ((num % i == 0) || (num % (i + 2) == 0))
                {
                    break;
                }
            } while (i <= sqrt_n);

            return (i > sqrt_n);
        }

        #endregion

    }
}
