using System;

namespace Bai5
{
//    5. Chương trình C# để nhập hai số và nhập một phép toán. Tương ứng với phép toán đã nhập bạn thực hiện phép tính trên hai số và in kết quả ra màn hình
//Ví dụ: 
//Nhập số thứ nhất là 5
//Phép toán là +
//Nhập số thứ hai là 4
//--> Kết quả là 9
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap vao so a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so b");
            b = Convert.ToInt32(Console.ReadLine());
            int phep_tinh;
            Console.WriteLine("Lua chon phep tinh + , - , * ,/");
            phep_tinh = Convert.ToInt32(Console.ReadLine());
            switch (phep_tinh)
            {
                case 1:
                    int cong;
                    cong = a + b;
                    Console.WriteLine("Phep tinh cong a + b = "+cong);
                    break;
                case 2:
                    int tru;
                    tru = a - b;
                    Console.WriteLine("Phep tinh tru a - b= " + tru);
                    break;
                case 3:
                    int nhan;
                    nhan = a * b;
                    Console.WriteLine("Phep tinh nhan a * b = " + nhan);
                    break;
                case 4:
                    int chia;
                    chia = a / b;
                    Console.WriteLine("Phep tinh chia a/b= " + chia);
                    break;
                default:
                    Console.WriteLine("Vui long nhap phep tinh");
                    break;
                   
            }
            Console.ReadKey();
        }
    }
}
