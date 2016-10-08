using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_struct_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            nhap(ref hs);
            var diemtb = hs.diemTB(hs);
            xuat(hs, diemtb);
            Console.ReadKey();
        }
        #region nhap thong tin
        private static void nhap(ref HocSinh hs)
        {
            Console.WriteLine("nhap ho ten:");
            hs.HoTen = Console.ReadLine();
            Console.WriteLine("nhap dia chi:");
            hs.DiaChi = Console.ReadLine();
            Console.WriteLine("nhap ma hoc sinh:");
            hs.MaHocSinh = Console.ReadLine();
            Console.WriteLine("nhap diem mon 1:");
            hs.Diem1 = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem mon 2:");
            hs.Diem2 = float.Parse(Console.ReadLine());
        }
        #endregion
        #region xuat thong tin
        private static void xuat(HocSinh hs,object diemtb)
        {
            Console.WriteLine("ho ten: {0}", hs.HoTen);
            Console.WriteLine("ma sinh vien: {0}", hs.MaHocSinh);
            Console.WriteLine("dia chi: {0}", hs.DiaChi);
            Console.WriteLine("diem mon 1: {0}", hs.Diem1);
            Console.WriteLine("diem mon 2: {0}", hs.Diem2);
            Console.WriteLine("diem trung binh: {0}", diemtb);
        }
        #endregion
    }
}
