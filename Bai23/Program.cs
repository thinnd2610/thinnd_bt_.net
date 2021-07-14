using System;

namespace Bai23
{
//    23. Giải phương trình bậc hai trong C#
//Chương trình C# để nhập nhiệt độ và in ra thông báo tương ứng (
//Nhiệt độ< 0 thì thông báo là thời tiết giá rét
//Nhiệt độ 0-10: thời tiết rất lạnh
//Nhiệt độ 10-20: thời tiết lạnh
//Nhiệt độ 20-30: thời tiết bình thường
//Nhiệt độ 30-40: thời tiết nóng
//Nhiệt độ >= 40: thời tiết rất nóng)
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("TRUNG TAM KHI TUONG THUY VAN TRUNG UONG");
            Console.WriteLine("Vui long nhap nhiet do");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Thoi tiet gia ret");
            }
                else if(a >= 0 && a<10)
                {
                    Console.WriteLine("Thoi tiet rat lanh");
                }
                else if (a >= 10 && a < 20)
                {
                    Console.WriteLine("Thoi tiet lanh");
                }else if(a>=20 && a < 30)
                {
                    Console.WriteLine("Thoi tiet binh thuong");
                }
                else if (a>=30 && a<40)
                {
                    Console.WriteLine("Thoi tiet nong");

                }
            else
            {
                Console.WriteLine("Thoi tiet rat nong");
            }
            
            
            Console.ReadKey();
        }
    }
}
