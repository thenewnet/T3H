using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Thinh_Bai1_Oct
{
    class Thinh_Bai1_Oct
    {
        public struct HocSinh
        {
            public string maHS;
            public string hoTen;
            public string diaChi;
            public float diem1;
            public float diem2;
        }
        static void Main(string[] args)
        {
            List<HocSinh> listHS = new List<HocSinh>();
           
            //nhap thong tin hoc sinh
            while (true)
            {
                Console.WriteLine("---------------------------------NHAP LIEU-------------------------------");
                HocSinh hs;
                Console.WriteLine("Nhap ma hoc sinh:");
                hs.maHS = Console.ReadLine();
                Console.WriteLine("Nhap ho ten:");
                hs.hoTen = Console.ReadLine();
                Console.WriteLine("Nhap dia chi:");
                hs.diaChi = Console.ReadLine();
                hs.diem1 = float.MinValue;
                hs.diem2 = float.MinValue;
                Console.WriteLine("Nhap diem mon 1:");
                Thinh_GiaiPhuongTrinhBacNhat_28Sep.Thinh_GiaiPhuongTrinhBacNhat.CheckNumber(ref hs.diem1,"Diem phai nhap diem tu 0-10: ",min:0,max:10);
                Console.WriteLine("Nhap diem mon 2:");
                Thinh_GiaiPhuongTrinhBacNhat_28Sep.Thinh_GiaiPhuongTrinhBacNhat.CheckNumber(ref hs.diem2, "Diem phai nhap diem tu 0-10: ", min: 0, max: 10);

                //
                listHS.Add(hs);
                Console.WriteLine("---------------------------------KET QUA-------------------------------");
                Console.WriteLine("{0,10} {1,15} {2,15} {3,5} {4,5} {5,5}", "MaHS", "Ho Ten", "Dia Chi", "Diem 1", "Diem 2", "Diem TB");
                foreach (HocSinh hs1 in listHS)
                {
                    Console.WriteLine("{0,10} {1,15} {2,15} {3,5} {4,5} {5,5}", hs1.maHS, hs1.hoTen, hs1.diaChi, hs1.diem1, hs1.diem2, (hs1.diem1 + hs1.diem2) / 2);
                }
                //
                Console.WriteLine("----------------------------------Y KIEN-------------------------------");
                Console.WriteLine("Chon Q de thoat. Nhan phim bat ky de tiep tuc:");
                string ktTraLoi = Console.ReadLine();
                if (ktTraLoi.ToUpper() == "Q") break;
                Console.Clear();

            }
            

        }
    }
}
