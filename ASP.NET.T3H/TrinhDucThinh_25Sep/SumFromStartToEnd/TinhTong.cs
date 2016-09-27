using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFromStartToEnd
{
    class TinhTong
    {

        #region Main

        static void Main(string[] args)
        {
            while (true)
            {
                //Nhap so bat dau
                Console.WriteLine("Nhap so bat dau");
                int start = Convert.ToInt32(Console.ReadLine());

                //Nhap so ket thuc
                Console.WriteLine("Nhap so ket thuc");
                int end = Convert.ToInt32(Console.ReadLine());

                //Tinh tong
                int sum = 0;
                for (int i = start; i <= end; i++)
                    sum += i;
                Console.WriteLine("Tong la:{0}", sum);

                //Hoi y kien nguoi dung
                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string ch = Console.ReadLine();
                if (ch.ToUpper() == "Q") break;
            }

            Console.ReadLine();
        }

        #endregion
       
    }
}
