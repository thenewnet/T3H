using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangCuuChuong
{
    class BangCuuChuong
    {
        #region Main

        static void Main(string[] args)
        {
            while (true)
            {
                //Nhap mot so 
                Console.WriteLine("Nhap mot so tu 1 den 9");
                int n = int.Parse(Console.ReadLine());

                //Hien thi bang cuu chuong cua so da nhap
                Console.Clear();
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
                }

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
