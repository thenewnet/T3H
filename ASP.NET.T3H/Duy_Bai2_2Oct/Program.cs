using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duy_Bai2_2Oct
{
    class Program
    {
        public struct Informations
        {
            public string MaNV, TenNV;
            public decimal DonGia;
            public int SoLuong;
            public GioiTinh gioitinh;
        }
        public enum GioiTinh { Nam = 0, Nu = 1 };
        static void Main(string[] args)
        {
            Informations Staff;

            Console.WriteLine("Moi ban nhap Ma nhan vien");
            Staff.MaNV = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ten nhan vien");
            Staff.TenNV = Console.ReadLine();
            Console.WriteLine("Moi ban nhap gioi tinh, Nam = 0, Nu = 1");
            var gt = int.Parse(Console.ReadLine());
            Staff.gioitinh = (GioiTinh)gt;
            Console.WriteLine("Moi ban nhap so SP");
            Staff.SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap don gia");
            Staff.DonGia = decimal.Parse(Console.ReadLine());

            var luong = Staff.SoLuong * Staff.DonGia;
            decimal Luong = Staff.gioitinh == GioiTinh.Nam ? (Staff.SoLuong * Staff.DonGia) : (Staff.SoLuong * Staff.DonGia) + ((Staff.SoLuong * Staff.DonGia) / 10);
            Console.WriteLine("Thong tinluong cua nhan vien");
            Console.WriteLine("{0,5} {1,10} {2,10} {3,10} {4,10} {5,10}", "Ma NV", "Ho Ten", "Gioi Tinh", "so SP", "Don Gia", "Luong");
            Console.WriteLine("{0,5} {1,10} {2,10} {3,10} {4,10} {5,10}", Staff.MaNV, Staff.TenNV, Staff.gioitinh, Staff.SoLuong, Staff.DonGia, Luong);
            Console.ReadLine();
        }
    }
}
