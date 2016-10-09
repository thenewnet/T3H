using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy_Bai3_2Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(10, 100);
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
