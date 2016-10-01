using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_Bai1._2_Sep
{
    class Program
    {
        static void Main(string[] args)
        {
            double heSoBien = 0;
            double heSoTuDo = 0;
            NhapHeSo(ref heSoBien, ref heSoTuDo);
            if (heSoBien == 0)
            {
                if (heSoTuDo == 0)
                {
                    Console.WriteLine("Phuong trinh {0}x + ({1}) = 0 nghiem dung voi moi x ", heSoBien, heSoTuDo);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem x = {0}", (-heSoTuDo) / heSoBien);
            }
            Console.ReadKey();
        }

        public static void NhapHeSo(ref double heSoBien, ref double heSoTuDo)
        {
            Console.Write("Nhap he so bien: ");
            heSoBien = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so tu do: ");
            heSoTuDo = double.Parse(Console.ReadLine());
        }
    }
}
