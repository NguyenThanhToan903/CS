using System;

namespace CS003
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kq;
            int a,
                b;
            a = 5;
            b = 6;
            kq = a == b;
            Console.WriteLine($"a == b  ==> {a == b}");
            Console.WriteLine($"a != b  ==> {a != b}");
        }
    }
}
