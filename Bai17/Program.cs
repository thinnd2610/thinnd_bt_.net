using System;

namespace Bai17
{
    //17. Chương trình C# để nhập tuổi của một người,
    //kiểm tra và thông báo xem người đó có đủ độ tuổi bầu cử không,
    //    sau đó in thông báo tương ứng. (Độ tuổi bầu cử là >= 18)
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("HOI DONG BAU CU QUOC GIA");
            Console.WriteLine("KIEM TRA TUOI CUA BAN DA DU TUOI DI BAU CU HAY CHUA ?");
            Console.WriteLine("Hay nhap tuoi cua ban : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("Xin loi , ban chua du tuoi lam chuyen ay | tuoi bau cu tu 18 +");
            }
            else
            {
                Console.WriteLine("Ban da du tuoi di bau cu | Hay bau chon cho toi nhe : NGO DUC THIN - SBD : 2610 | XIN CAM ON !");
            }
            Console.ReadKey();
        }
    }
}
