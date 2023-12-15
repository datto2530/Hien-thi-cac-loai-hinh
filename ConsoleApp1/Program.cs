using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ve hinh chu nhat");
            Console.WriteLine("2. Ve hinh tam giac vuong (top-right)");
            Console.WriteLine("3. Ve hinh tam giac vuong (top-left)");
            Console.WriteLine("4. Ve hinh tam giac vuong (bottom-left)");
            Console.WriteLine("5. Ve hinh tam giac vuong (bottom-right)");
            Console.WriteLine("6. Ve hinh tam giac can");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Nhap lua chon cua ban: ");
            choice = Int32.Parse(Console.ReadLine());
            while (choice < 1 || choice > 7)
            {
                Console.WriteLine("Vui long nhap lai lua chon cua ban (tu 1 den 7): ");
                choice = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Lua chon cua ban la: " + choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ve hinh chu nhat");
                    for (int i = 0; i < 5; i++) ;
                    {
                        for (int j = 0; j <20; j++) ;
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ve hinh tam giac vuong (top-right)");
                    break;
                case 3:
                    Console.WriteLine("Ve hinh tam giac vuong (top-left)");
                    break;
                case 4:
                    Console.WriteLine("Ve hinh tam giac vuong (bottom-left)");
                    break;
                case 5:
                    Console.WriteLine("Ve hinh tam giac vuong (bottom-right)");
                    break;
                case 6:
                    Console.WriteLine("Ve hinh tam giac can");
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
