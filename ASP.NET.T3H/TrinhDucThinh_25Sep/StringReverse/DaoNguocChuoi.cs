using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class DaoNguocChuoi
    {
        
        #region Main

        static void Main(string[] args)
        {
            //Nhap vao mot chuoi
            Console.WriteLine("Nhap vao mot chuoi");
            string str = Console.ReadLine();

            //xu ly dua ket qua vao strReverse
            string strReverse = ReverseString(str);

            //Hien thi
            Console.WriteLine("{0} chuoi dao nguoc {1}", str, strReverse);
            Console.ReadLine();

        }
        #endregion
      

        #region Method static
        //Phuong thuc dao nguoc chuoi
        private static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr); // đảo ngược mãng
            return new string(arr); // trả về chuỗi mới sau khi đảo mãng

        }
        #endregion
       
    }
}
