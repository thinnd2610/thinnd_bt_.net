using System;

namespace Bai29
{
    //29. Chương trình C# để nhập một số và hiển thị ngày trong tuần tương ứng
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap 1 ngay trong tuan 1-7");
             int a;
            do
            {
                Console.WriteLine("Vui long nhap tu 1-7");
                a = Convert.ToInt32(Console.ReadLine());
                
            } while (a<0 || a>7);
 
            switch (a)
            {
                case 1:
                    Console.WriteLine("Thu 2");
                    break;
                case 2:
                    Console.WriteLine("Thu 3");
                    break;
                case 3:
                    Console.WriteLine("Thu 4");
                    break;
                case 4:
                    Console.WriteLine("Thu 5");
                    break;
                case 5:
                    Console.WriteLine("Thu 6");
                    break;
                case 6:
                    Console.WriteLine("Thu 7");
                    break;
                case 7:
                    Console.WriteLine("Chu nhat");
                    break;
                default:
                    Console.WriteLine("Vui long nhap du lieu");
                    break;
            }
        }
    }
}
