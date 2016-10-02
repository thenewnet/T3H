using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trung_Mang_02Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] soNguyen = {2, 6, 3, 7, 19, 22, 14, 23, 15, 2};
            Console.WriteLine("So lon nhat la: {0}", GetMax(soNguyen));
            Console.WriteLine("So nho nhat la: {0}", GetMin(soNguyen));
            Console.ReadLine();
        }

        /// <summary>
        /// Method to get max element of integer array
        /// </summary>
        /// <param name="soNguyen">integer array</param>
        /// <returns></returns>
        public static int GetMax(int[] soNguyen)
        {
            //initial for max value
            int max = soNguyen[0];

            //through all element of array
            for (int i = 0; i <= soNguyen.Length - 1; i++)
            {
                if (max < soNguyen[i])
                {
                    max = soNguyen[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Method to get munimum element of integer array
        /// </summary>
        /// <param name="soNguyen">integer array</param>
        /// <returns></returns>
        public static int GetMin(int[] soNguyen)
        {
            return 0;
        }
    }
}
