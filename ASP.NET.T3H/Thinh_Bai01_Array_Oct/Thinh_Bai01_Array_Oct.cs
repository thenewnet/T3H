using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinh_TinhToanDaySo_28Sep;

namespace Thinh_Bai01_Array_Oct
{
    class Thinh_Bai01_Array_Oct
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //
                Console.WriteLine("--------Nhap so luong phan tu: -------");
                int n=int.MinValue;
                Thinh_TinhToanDaySo_28Sep.Thinh_TinhToanDaySo_28Sep.CheckNumber(ref n, "n phai la so nguyen >0: ", limitMin: 0, limitMax: int.MaxValue);
                
                //
                Console.WriteLine("--------------------Ket Qua-----------");
                Random rd=new Random();
                Console.WriteLine("Day so ngau nhien co {0} phan tu: ",n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" {0}", rd.Next(10,100));
                }

                //
                Console.WriteLine("\n-----------------hoi y kien ------------------");
                Console.WriteLine("Chon Q de thoat. Nhan phim bat ky de tiep tuc:");
                string ktTraLoi = Console.ReadLine();
                if (ktTraLoi.ToUpper() == "Q") break;
                Console.Clear();

            }
        }
    }
}
