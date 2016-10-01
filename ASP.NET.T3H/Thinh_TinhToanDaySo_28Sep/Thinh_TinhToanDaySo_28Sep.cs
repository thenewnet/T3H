using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh_TinhToanDaySo_28Sep
{
    class Thinh_TinhToanDaySo_28Sep
    {
       
        #region Variable
        //Tao mot ArrayList de luu tru gia tri nhap vao cua mang
        private static ArrayList arr = new ArrayList();
        #endregion


        #region Main
        static void Main(string[] args)
        {
            StartMenu(arr);
        }
        #endregion


        #region Methods static
        //In ra man hinh menu lua chon 
        public static void StartMenu(ArrayList arr)
        {
            #region Hien thi menu thong bao ban dau
            Console.Clear();
            Console.WriteLine("Phep tinh tren day so nguyen");
            Console.WriteLine("*******************************");
            Console.WriteLine("1.Tong day so\n2.Tong cac so le trong day \n3.Tong cac so chan trong day \n4.Thoat");
            Console.WriteLine("Nhap lua chon cua ban tu 1 den 4");
            #endregion

            //Kiem tra dieu kien nhap
            #region Kiem tra dieu kien nhap "tuy chon"
            int ch = int.MinValue;
            CheckNumber(ref ch,"Ban phai nhap tuy chon tu 1 den 4.\n", limitMin:1, limitMax:4);
            #endregion

            #region Tuy vao tung truong hop de dua ra cach thuc hien
            switch (ch)
            {
                case 1:
                    //Thuc hien tinh tong day
                    CalSumArray(arr);

                    break;
                case 2:
                    //Thuc hien tinh tong le
                    CalSumOdd(arr);
                    break;
                case 3:
                    //Thuc hien tinh tong chan
                    CalSumEven(arr);
                    break;
                case 4:
                    break;

            }
            #endregion

        }

        //Phuong thuc tinh tong chan
        public static void CalSumEven(ArrayList arr)
        {
            Console.WriteLine("-----------------------Chon phep tinh 3-----------------------------");
            //Kiem tra=> comment Check Order
            CheckOrder();

            //Tinh tong chan

            int sumEven = 0;
            foreach (int i in arr)
                if (i % 2 == 0)
                    sumEven += i;

            //Hien thi day so tinh toan=> Tong chan
            Output(arr);
            Console.WriteLine("\nTong cac so chan trong day vua nhap la:{0}", sumEven);

            //Hoi y kien nguoi dung
            AnswerUser();
        }

        //Phuong thuc tinh tong le
        private static void CalSumOdd(ArrayList arr)
        {
            Console.WriteLine("-----------------------Chon phep tinh 2-----------------------------");
            //Kiem tra ->comment CheckOrder
            CheckOrder();

            //Tinh tong cac so le
            int sumOdd = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    sumOdd += i;
                }
            }
            //Hien thi day so tinh toan=> dua ra tong le tinh duoc o tren
            Output(arr);
            Console.WriteLine("\nTong cac so le trong day vua nhap la:{0} ", sumOdd);

            //Hoi y kien nguoi dung
            AnswerUser();


        }

        //Hoi Y kien nguoi dung xem co muon tiep tuc chuong trinh nua hay khong
        private static void AnswerUser()
        {
            Console.WriteLine("Nhan C de tiep tuc. Nhan phim bat ky de thoat");
            string asw = Console.ReadLine();
            if (asw.ToUpper() == "C") StartMenu(arr);
        }

        //giai thich method CheckOrder.
        //kiem tra xem co phai lan dau ho thuc hien phep toan
        //Neu dung thi Nhap lai.
        //Neu co roi thi hoi xem co muon nhap lai hay khong.
        //-Dong y thi cho nhap lai
        //-Khong dong y thi thuc hien tinh toan tren mang da nhap
        private static void CheckOrder()
        {
            //Kiem tra: Neu day so da nhap. Nguoi dung co muon nhap day so khac de tinh toan hay khong.
            if (arr.Count != 0)
            {
                Console.WriteLine("-Nhan phim Y de nhap lai day so\n-Nhan phim bat ky khac de thuc hien tinh toan tren day da nhap");
                string check = Console.ReadLine();
                if (check.ToUpper() == "Y")
                {
                    //Xoa phan tu da co trong day so
                    arr.RemoveRange(0, arr.Count);
                    //Nhap phan tu moi
                    Input(arr);
                }
            }
            //Truong hop: Dau tien nguoi dung thuc hien tinh toan
            if (arr.Count == 0)
                Input(arr);
        }

        //phuong thuc tinh tong 
        private static void CalSumArray(ArrayList arr)
        {
            Console.WriteLine("-----------------------Chon phep tinh 1-----------------------------");
            //Kiem tra ->comment tren
            CheckOrder();

            //Tinh tong cac phan tu vua nhap
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            //Hien thi day so vua nhap va in ra day so do
            Output(arr);
            Console.WriteLine("\n-Tong cua day so vua nhap: {0}", sum);

            //Hoi y kien nguoi dung
            AnswerUser();
        }

        //phuong thuc nhap du lieu 
        private static void Input(ArrayList arr)
        {
            Console.Write("-----------------Input-----------------------\n");
            Console.WriteLine("Nhap so luong phan tu:");

            //Kiem tra dieu kien nhap cho n
            int n = int.MinValue;
            CheckNumber(ref n, "Ban phai nhap vao mot so nguyen 0<n<100:",limitMax:100,limitMin:0);

            //Nhap tung phan tu
            for (int i = 0; i < n; i++)
            {
                //tao mot bien tam de kiem tra d
                int tmp = int.MinValue;
                Console.Write("Nhap phan tu thu {0}: ", i + 1);

                //message la thong bao khi 
                string message = "Nhap lai phan tu thu " + (i + 1) + " :";
                //Kiem tra nhap tmp thoa man
                //-la mot so nguyen
                //-co gia tri lon nhat la Max cua so nguyen
                CheckNumber(ref tmp, message, int.MaxValue,int.MinValue);
                arr.Add(tmp);

            }
            Console.WriteLine();

        }

        //Kiem tra dieu kien nhap vao cua tmp:
        //-Phai la mot so 
        //-Gia tri phai nho hon gioi han limit
        //-Neu co loi thi thong bao ra message thong bao de nhap lai gia tri den khi nao tmp thoa man(la mot so va nho hon limit)
        //-bien flag:kiem tra xem day co phai lan dau nhap sai hay khong.
        //-Gia tri thoa man duoc tra ve qua tham so tmp
        public static void CheckNumber(ref int tmp, string message, int limitMax = 100,int limitMin=int.MinValue,int flag=int.MinValue)
        {
            bool checkI = false;
            do
            {
                if (tmp==flag)
                {
                    checkI = int.TryParse(Console.ReadLine(), out tmp);
                    if (tmp > limitMax) checkI = false;
                }
                else
                {
                   
                    Console.Write(message);
                    checkI = int.TryParse(Console.ReadLine(), out tmp);
                }

                if (tmp > limitMax|| tmp <limitMin) { tmp = -1; checkI = false; }
            } while (!checkI);
        }

        //phuong thuc hien thi du lieu 
        private static void Output(ArrayList arr)
        {
            Console.Write("----------------------------KET QUA---------------------------------\n");
            Console.Write("-Day so vua nhap: ");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }
        #endregion

    }
        
      
}
