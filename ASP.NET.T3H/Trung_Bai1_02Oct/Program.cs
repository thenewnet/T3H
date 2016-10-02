using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trung_Bai1_02Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student;

           

            Console.WriteLine("Moi nhap ten");
            student.FullName = Console.ReadLine();

            Console.WriteLine("Moi nhap dia chi");
            student.Address = Console.ReadLine();

            Console.WriteLine("Moi nhap diem 1");
            student.Mark1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Moi nhap diem 2");
            student.Mark2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Moi nhap gioi tinh, Nam = 0, Nu = 1");
            var gt = int.Parse(Console.ReadLine());

            student.GioiTinh = (Sex) gt;

            var mark = (student.Mark1 + student.Mark2)/2;

            Console.WriteLine("******* Ket qua la ********");
            Console.WriteLine("{0, 15} {1,20} {2, 10} {3, 5}", "Họ và tên", "Địa chỉ", "Điểm trung bình", "Giới Tính");
            Console.WriteLine("{0, 15} {1, 20} {2, 10}, {3, 5}", student.FullName, student.Address, mark, student.GioiTinh);

            Console.ReadLine();
        }

       
    }
        struct  Student
        {
            public string FullName;
            public string Address;
            public float Mark1;
            public float Mark2;
            public Sex GioiTinh;
        }

    enum Sex
    {
       Nam, Nữ
    }
    
}
