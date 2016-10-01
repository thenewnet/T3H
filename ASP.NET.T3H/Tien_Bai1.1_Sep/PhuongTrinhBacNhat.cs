using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tien_Bai1._1_Sep
{
    class PhuongTrinhBacNhat
    {
        public double heSoBien { get; set; }
        public double heSoTuDo { get; set; }

        public PhuongTrinhBacNhat()
        {
            heSoBien = heSoTuDo = 0;
        }

        public PhuongTrinhBacNhat(double heSoBien, double heSoTuDo)
        {
            this.heSoBien = heSoBien;
            this.heSoTuDo = heSoTuDo;
        }

        public void Giai()
        {
            if (heSoBien == 0)
            {
                if (heSoTuDo == 0)
                {
                    Console.WriteLine("Phuong trinh {0}x + ({1}) = 0 nghiem dung voi moi x ", heSoBien, heSoTuDo);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem x = {0}", (-heSoTuDo) / heSoBien);
            }
        }
    }
}
