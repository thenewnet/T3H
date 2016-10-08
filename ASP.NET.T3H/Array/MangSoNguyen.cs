using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNguyen
{
    class MangSoNguyen

    {
        #region property
        public int[] MangNGuyen { get; set; }
        #endregion
        #region method
        #region tinh tong cac phan tu trong mang
        public int tongMang(MangSoNguyen arr)
        {
            var kq = 0;
            foreach (int a in arr.MangNGuyen)
            {
                kq += a;
            }
            return kq;
        }
        #endregion

        #region tinh tong le
        public int tongLe(MangSoNguyen arr)
        {
            var kq = 0;
            foreach (int a in arr.MangNGuyen)
            {
                if (a % 2 != 0)
                {
                    kq += a;
                }
            }
            return kq;
        }
        #endregion
    


        #region sap xep tang
        public void tangDan(MangSoNguyen arr)
        {

            Array.Sort(arr.MangNGuyen);
        }

        #endregion
        
        #region sap xep giam
        public void giamDan(MangSoNguyen arr)
        {
           for(int i=0;i<arr.MangNGuyen.Length-1;i++)
           {
               for(int j=i+1;j<arr.MangNGuyen.Length;j++)
               {
                   if(arr.MangNGuyen[j]>arr.MangNGuyen[i])
                   {
                       int tam = arr.MangNGuyen[i];
                       arr.MangNGuyen[i] = arr.MangNGuyen[j];
                       arr.MangNGuyen[j] = tam;
                   }
               }
           }
        }
        #endregion

        #region gia tri max
        public int max(MangSoNguyen arr)
        {
            int Somax = arr.MangNGuyen[0];
            for(int i=1;i<arr.MangNGuyen.Length;i++)
            {
                if (Somax < arr.MangNGuyen[i])
                    Somax = arr.MangNGuyen[i];
            }
            return Somax;
        }

        #endregion

        #endregion



        
    }
}
