using System;
using MyLib;

namespace CS_EXTENSIONMETHOD
{
    // extension method
    // lop tinh static ~

    static class Abc
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "Xin chao cac ban.";
            s.Print(ConsoleColor.Cyan);

            double a = 1.5;

            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBacHai());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());
        }
    }
}
