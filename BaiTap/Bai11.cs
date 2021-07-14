using System;

namespace BaiTap
{
    class Bai11
    { 
        //11. Nhập hai số từ bàn phím, trả về true nếu cả hai số cùng chẵn, nếu không thì trả về false.
        static void Main(string[] args)
        {
            int a, b;
            float quang_duong;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Nhap quang duong (don vi met): ");

            Console.WriteLine("Nhap so a : ");
            a= Console.ReadLine();
            Console.WriteLine("Nhap so b : ");
            Console.ReadLine();
            if (a % 2 && b % 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
