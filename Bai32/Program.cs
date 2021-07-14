using System;

namespace Bai32
{
    //32. Viết một chương trình C# hiển thị một menu có các lựa chọn để tính diện tích các hình tròn, hình chữ nhật, hình tam giác tương ứng với dữ liệu đã nhập.
    class Program
    {
        static void Main(string[] args)
        {   int chon;
            double s = 0;
            do
            {
                Console.WriteLine("--------MENU--------");
                Console.WriteLine("1.Tinh dien tich hinh tron");
                Console.WriteLine("2.Tinh dien tich hinh chu nhat");
                Console.WriteLine("3.Tinh dien tich hinh tam giac");
                Console.WriteLine("4.Thoat");
                Console.WriteLine("Moi lua chon cua ban");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        int r;
                        Console.Write("Nhap ban kinh hinh tron: ");
                        r = Convert.ToInt32(Console.ReadLine());
                        s = 3.14 * r * r;
                        break;
                    case 2:
                        int l, w;
                        Console.Write("Nhap chieu dai hinh chu nhat: ");
                        l = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap chieu rong hinh chu nhat: ");
                        w = Convert.ToInt32(Console.ReadLine());
                        s = l * w;
                        break;
                    case 3:
                        int b, h;
                        Console.Write("Nhap canh huyen tam giac:");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap chieu cao tam giac:");
                        h = Convert.ToInt32(Console.ReadLine());
                        s = 0.5 * b * h;
                        break;
                    case 4:
  
                        break;
                    default:
                        Console.WriteLine("Vui long lua chon");
                        break;
                }
                Console.WriteLine("Dien tich hinh la: {0}", s);
            } while (chon>0&&chon<=3);
            

            Console.ReadKey();
        }
    }
}
