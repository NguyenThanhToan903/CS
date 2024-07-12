using System;
using System.Runtime.InteropServices;

namespace CS002
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "helo";
            Console.WriteLine("Xin chao day la CS");
            Console.ResetColor();
            Console.WriteLine("Hello World");

            float a,
                b;
            string sinput;
            Console.WriteLine("Hay nhap vao so a: ");
            sinput = Console.ReadLine();
            a = float.Parse(sinput);

            Console.WriteLine("Hay nhap vao so b: ");
            sinput = Console.ReadLine();
            b = Convert.ToSingle(sinput);

            Console.WriteLine("Tham so a: {0}\nTham so b: {1}", a, b);

            var c = 1; // c kieu  nguyen
            var d = "abc"; // d string
        }
    }
}
