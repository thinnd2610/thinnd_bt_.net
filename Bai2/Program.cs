using System;

namespace Bai2
{
//    Nhập một số và vẽ tam giác số với độ rộng theo bề ngang là một số khác được nhập từ bàn phím.Ví dụ, với số 4 và độ rộng là 5 thì chúng ta có tam giác:
//Ví dụ, với số 4 và độ rộng là 5 thì chúng ta có tam giác:
//4 4 4 4 4
//4 4 4 4
//4 4 4
//4 4
//4
    class Program
    {
        public static void Main()
        {

            Console.Write("Nhap mot so : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap do rong cua tam giac: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }

            Console.ReadKey();
        }
    }
}
