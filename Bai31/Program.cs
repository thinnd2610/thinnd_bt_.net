using System;

namespace Bai31
{
    //31. Nhập số tháng bất kỳ và hiển thị số ngày của tháng đó trong C#
    class Program
    {
        static void Main(string[] args)
        { 
            int thang;
            Console.WriteLine("Nhap so thang bat ki: ");
            do
            { 
                Console.WriteLine("Vui long nhap tu 1-12");
                thang = Convert.ToInt32(Console.ReadLine());
               
            }while (thang<1 || thang>12);
            switch (thang)
                {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("Thang co 31 ngay");
                            break;
                        case 2:
                            Console.WriteLine("Thang co 28 ngay");
                            Console.WriteLine("Trong nam nhuan thang co 29 ngay");

                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("Thang co 30 ngay");
                            break;

                        default:
                        Console.WriteLine("Vui long nhap dung du lieu");
                            break;
                 }
            Console.ReadKey();
        }
    }
}
