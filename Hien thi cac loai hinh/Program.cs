using System;

namespace Hien_thi_cac_loai_hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choice = -1;
            while (Choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Ve hinh chu nhat");
                Console.WriteLine("2. Ve hinh tam giac vuong");
                Console.WriteLine("3. Ve hinh tam giac can");
                Console.WriteLine("0. Ket thuc");
                Console.WriteLine("Nhap lua chon cua ban");

                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("*********");
                        Console.WriteLine("********");
                        Console.WriteLine("*******");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        break;
                    case 3:
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        Console.WriteLine("**********");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("nhap lai");
                        break;
                }
                Console.ReadKey();
            }
    }
}
