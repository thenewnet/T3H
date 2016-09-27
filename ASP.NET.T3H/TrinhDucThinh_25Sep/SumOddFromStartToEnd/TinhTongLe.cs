using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddFromStartToEnd
{
    class TinhTongLe
    {

        #region Main

        static void Main(string[] args)
        {
            while (true)
            {

                //Nhap so bat dau va so ket thuc
                Console.WriteLine("Nhap so bat dau");
                int start = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nhap so bat dau");
                int end = Convert.ToInt32(Console.ReadLine());
                int sum1 = 0;

                //Tinh toan
                //c1
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 != 0) sum1 += i;
                }

                //c2
                int sum2 = 0;
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0) continue;
                    sum2 += i;
                }
                //c3
                int sum3 = 0;
                int newStart = start % 2 == 0 ? start + 1 : start;
                for (int i = newStart; i <= end; i = i + 2)
                {
                    sum3 += i;
                }

                //Hien thi ket qua
                Console.Clear();
                Console.WriteLine("Tong cac so le tu {0} den {1} la {2} {3} {4}", start, end, sum1, sum2, sum3);

                //Hoi y kien nguoi dung
                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string ch = Console.ReadLine();
                if (ch.ToUpper() == "Q") break;
                Console.ReadLine();
            }
        }

        #endregion
      
    }
}
