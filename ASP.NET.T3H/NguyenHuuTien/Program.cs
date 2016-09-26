using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TinhTongStartEnd(3, 5));
            Console.WriteLine(TinhTongLe(3, 19));
            BangCuuChuong(5);
            Console.ReadKey();
        }

        public static int TinhTongStartEnd(int start, int end)
        {
            if (start == end) return start;
            return TinhTongStartEnd(start, end - 1) + end;
        }

        public static int TinhTongLe(int start, int end)
        {
            int result = new int();
            if ((end - start) == 1)
            {
                if (start % 2 == 0)
                {
                    result = end;
                }
                else result = start;
            }
            else if (((start % 2) == 0) && ((end % 2) == 0))
            {
                result = ((start + end) * ((end - start) / 2)) / 2;
            }
            else if ((((start % 2) == 0) && ((end % 2) == 1)))
            {
                result = (((end - start - 1) / 2 + 1) * (start + 1 + end)) / 2;
            }
            else if (((start % 2) == 1) && ((end % 2) == 0))
            {
                result = (((start + end) * ((end - start + 1) / 2)) / 2) - ((end - start + 1) / 4);
            }
            else
            {
                result = (((start + end) * ((end - start) / 2)) / 2) + ((end + start) / 2);
            }
            return result;
        }

        public static void BangCuuChuong(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
