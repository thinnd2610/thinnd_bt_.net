using System;

namespace Bai20
{
    //20. Tìm số lớn nhất trong C#  3 số đã nhập từ bàn phím
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Nhap so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if(a > b && a>c)
            {
                Console.WriteLine("So a la so lon nhat  "+a);
            }
            else if(b>a&& b > c)
            {
                Console.WriteLine("So b lon nhat la "+b);
            }
            else
            {
                Console.WriteLine("So c la so lon nhat"+c);
            }
            Console.ReadKey();
        }
    }
}
