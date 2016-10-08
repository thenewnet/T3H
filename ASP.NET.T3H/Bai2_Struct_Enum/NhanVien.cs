using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Struct_Enum
{
    public enum GioiTinh
    {
        nu,
        nam
    }
    struct NhanVien
    {
        #region property
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public GioiTinh Sex { get; set; }
        public int SoSanPham { get; set; }
        public int DonGia { get; set; }
        #endregion
        #region method
        public float tinhLuong(NhanVien nv)
        {
            if(nv.Sex == GioiTinh.nu)
            {
                return SoSanPham * DonGia * (float)1.1;
            }
            else
            {
                return SoSanPham * DonGia;
            }
        }
        #endregion
    }
}
