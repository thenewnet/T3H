using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinh_TinhToanDaySo_28Sep;
using Thinh_GiaiPhuongTrinhBacNhat_28Sep;

namespace Thinh_Bai2_Oct
{
    class Thinh_Bai2_Oct
    {

        public enum GioiTinh { nam, nu}
        public struct NhanVien {
            public string maNV;
            public string hoTenNV;
            public GioiTinh gioiTinh;
            public int soSP;
            public float donGia;
        }
        static void Main(string[] args)
        {
            List<NhanVien> listNV = new List<NhanVien>();
            NhanVien nv;
            while (true)
            {
                Console.WriteLine("--------------Nhap thong tin nhan vien-------------");
                Console.WriteLine("Ma nhan vien:");
                nv.maNV = Console.ReadLine();
                Console.WriteLine("Ho ten nhan vien:");
                nv.hoTenNV = Console.ReadLine();
                Console.WriteLine("Nhap 0 neu la nam or 1 neu la nu:");
                int gt=int.MinValue;
                Thinh_TinhToanDaySo_28Sep.Thinh_TinhToanDaySo_28Sep.CheckNumber(ref gt, "Nhap 0 neu la nam, 1 neu la nu: ", limitMin: 0, limitMax: 1);
                nv.gioiTinh = (GioiTinh)gt;
                Console.WriteLine("Nhap so luong san pham: ");
                nv.soSP = int.MinValue;
                Thinh_TinhToanDaySo_28Sep.Thinh_TinhToanDaySo_28Sep.CheckNumber(ref nv.soSP, "So luong san pham >0 va nho hon 1000", limitMin: 0, limitMax: 1000);
                Console.WriteLine("Nhap don gia: ");
                nv.donGia=float.MinValue;
                Thinh_GiaiPhuongTrinhBacNhat_28Sep.Thinh_GiaiPhuongTrinhBacNhat.CheckNumber(ref nv.donGia, "Don gia phai >0", min: 0, max: float.MaxValue);

                //
                listNV.Add(nv);
                Console.WriteLine("-----------------Ket qua nhan vien-------------");
                Console.WriteLine("{0,10} {1,20} {2,5} {3,5} {4,10} {5,10}", "Ma NV", "Ho Ten", "Gioi Tinh", "so SP", "Don Gia", "Luong");
                foreach(NhanVien nv1 in listNV)
                    Console.WriteLine("{0,10} {1,20} {2,5} {3,5} {4,10} {5,10}",nv1.maNV,nv1.hoTenNV,nv1.gioiTinh,nv1.soSP,nv1.donGia,nv1.gioiTinh==GioiTinh.nam?(nv1.soSP*nv1.donGia):(nv1.soSP*nv1.donGia)+(nv1.soSP*nv1.donGia)/10);
                //
                Console.WriteLine("-----------------hoi y kien ------------------");
                Console.WriteLine("Chon Q de thoat. Nhan phim bat ky de tiep tuc:");
                string ktTraLoi = Console.ReadLine();
                if (ktTraLoi.ToUpper() == "Q") break;
                Console.Clear();

            }
        }
    }
}
