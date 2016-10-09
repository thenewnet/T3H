using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy_Bai1_2Oct
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Information st;

            Console.WriteLine("Mời bạn nhập họ tên:");
            st.FullName = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập địa chỉ:");
            st.Adress = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập Mã học sinh:");
            st.MaHS = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập điểm 1:");
            st.D1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập điểm 2:");
            st.D2 = float.Parse(Console.ReadLine());
            var dtb = (st.D1 + st.D2) / 2;
            Console.WriteLine("{0, 5} {1,15} {2,15} {3, 25}", "Họ và tên", "Địa chỉ", "Mã học sinh", "Điểm trung bình");
            Console.WriteLine("{0, 5} {1,15} {2,15} {3, 25}", st.FullName, st.Adress, st.MaHS, dtb);
            Console.ReadLine();
        }
    }
    public struct Information
    {
        public string FullName, Adress, MaHS;
        public float D1, D2;
    }
}
