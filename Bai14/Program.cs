using System;

namespace Bai14
{
    //14.Nhập vào 1 số bất kỳ Kiểm tra một số là chẵn hay lẻ trong C#.
    class Program
    {
        static void Main(string[] args)
        {   int a;
            Console.WriteLine("Nhap vao so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("Day la so chan");
            }
            else
            {
                Console.WriteLine("Day la so le");
            }
            Console.ReadKey();
        }
    }
}
