using System;

namespace Bai26
{
    class Program
    {
        public static void Main()
        {

            char ch;
            Console.Write("\n");
            Console.Write("Kiem tra nguyen am, phu am :\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot chu cai: ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'i':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'o':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'u':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'e':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                default:
                    Console.WriteLine("Chu cai vua nhap khong phai la nguyen am.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
