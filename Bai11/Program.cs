using System;

namespace Bai11
{
    //11. Nhập hai số từ bàn phím, trả về true nếu cả hai số cùng chẵn, nếu không thì trả về false.
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Boolean c=true;
            Console.WriteLine("Nhap so a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a%2== 0 && b % 2 == 0)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c = false);
            }
            Console.ReadKey();
        }
    }
}
