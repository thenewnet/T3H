using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nhap(ref nv);
            var luong = nv.tinhLuong(nv);
            xuat(nv, luong);
            Console.ReadKey();
            
        }
        #region nhap thong tin
        private static void nhap(ref NhanVien nv)
        {
            Console.WriteLine("nhap ma nhan vien:");
            nv.MaNhanVien = Console.ReadLine();
            Console.WriteLine("nhap ten nhan vien:");
            nv.TenNhanVien = Console.ReadLine();
            Console.WriteLine("Gioi tinh: ");
            string tam = Console.ReadLine().ToLower();
            nv.Sex = (tam == GioiTinh.nam.ToString()) ? GioiTinh.nam : GioiTinh.nu;
            Console.WriteLine("nhap so san pham:");
            nv.SoSanPham = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia:");
            nv.DonGia = int.Parse(Console.ReadLine());

        }
        #endregion
        #region xuat thong tin
        private static void xuat(NhanVien nv,object luong)
        {
            Console.WriteLine("ma nhan vien: {0}", nv.MaNhanVien);
            Console.WriteLine("ten nhan vien: {0}", nv.TenNhanVien);
            Console.WriteLine("gioi tinh: {0}", nv.Sex);
            Console.WriteLine("so san pham: {0}", nv.SoSanPham);
            Console.WriteLine("don gia: {0}", nv.DonGia);
            Console.WriteLine("luong: {0}", luong);
        }
        #endregion
    }
}
