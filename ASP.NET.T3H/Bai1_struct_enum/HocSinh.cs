using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_struct_enum
{
    struct HocSinh
    {
        #region Property
        
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string MaHocSinh { get; set; }
        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        #endregion

        #region Method
        public float diemTB(HocSinh hs)
        {
            return (Diem1 + Diem2) / 2;
        }
        #endregion
    }
}
