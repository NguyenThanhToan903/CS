using System;

namespace CS004
{
    class Program
    {
        static void Main(string[] args)2
        
        {
            int a;
            Console.WriteLine("Nhap so a: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("a la so chan.");
            }
            else
            {
                Console.WriteLine("a la so le.");
            }
        }
    }
}
