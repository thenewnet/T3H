using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class Program
    {
        public enum GioiTinh : int { Nam = 0, Nu = 1 };

        public struct NhanVien
        {
            public string maNhanVien { get; set; }
            public string tenNhanVien { get; set; }
            public GioiTinh gioiTinh { set; get; }
            public int soSanPham { get; set; }
            public double donGia { get; set; }
            public double luong { get; set; }
        }

        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            NhapThongTin(ref nv);
            TinhLuong(ref nv);
            Console.WriteLine("{0,-10} {1,-20} {2,-9} {3,-10} {4,-10} {5,-10}",
                               "Ma NV", "Ho ten", "Gioi tinh", "So SP", "Don gia", "Luong");
            InThongTin(nv);
            Console.ReadKey();
        }

        public static void NhapThongTin(ref NhanVien nv)
        {
            Console.Write("Nhap ma nhan vien: ");
            nv.maNhanVien = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
            nv.tenNhanVien = Console.ReadLine();
            Console.Write("Nhap gioi tinh nhan vien (0 la nam, 1 la nu): ");
            int gt = int.Parse(Console.ReadLine());
            nv.gioiTinh = (GioiTinh)gt;
            Console.Write("Nhap so san pham: ");
            nv.soSanPham = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            nv.donGia = double.Parse(Console.ReadLine());
        }

        public static void TinhLuong(ref NhanVien nv)
        {
            //Neu la nam
            if (nv.gioiTinh == 0)
            {
                nv.luong = nv.soSanPham * nv.donGia;
            }

            //Neu la nu thi phai X 10% (tuc la X 1.1)
            else
            {
                nv.luong = nv.soSanPham * nv.donGia * 1.1;
            }
        }

        public static void InThongTin(NhanVien nv)
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-9} {3,-10} {4,-10} {5,-10}",
                               nv.maNhanVien, nv.tenNhanVien, nv.gioiTinh, nv.soSanPham, nv.donGia, nv.luong);
        }
    }
}
