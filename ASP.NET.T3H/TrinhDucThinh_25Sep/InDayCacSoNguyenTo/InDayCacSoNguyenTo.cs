using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDayCacSoNguyenTo
{
    class InDayCacSoNguyenTo
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Nhap so bat dau va so ket thuc

                Console.WriteLine("Nhap so bat dau");
                int start = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nhap so bat dau");
                int end = Convert.ToInt32(Console.ReadLine());

                //kiem tra va dua ra ket qua
                Console.WriteLine("Danh sach cac so nguyen to tu {0} den {1}", start, end);
                for (int i = start; i <= end; i++)
                {
                    if (KiemTraSoNguyenTo.KiemTraSoNguyenTo.IsPrime(i)) Console.WriteLine("{0}", i);
                }

                //Hoi y kien nguoi dung
                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string ch = Console.ReadLine();
                if (ch.ToUpper() == "Q") break;

            }
            Console.ReadLine();
        }
    }
}
