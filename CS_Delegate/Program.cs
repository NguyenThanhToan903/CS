using System;

// Delegate (type) bien = phuongthuc


namespace CS_Delegate
{
    public delegate void ShowLog(string message);

    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        // delegate int KIEU1();

        // static int Tong(int a, int b) => a + b;

        // static int Hieu(int a, int b) => a - b;

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"Ket qua la: {kq}");
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // ShowLog? log = null;
            // log = Info;
            // log?.Invoke("Xin chao");

            // log = Warning;

            // log += Info;
            // log += Warning;
            // log += Warning;

            // log("Hoc ve delegate");

            // Action, Func : delegate - generic

            // Action action; //~delegate void Kieu()
            // Action<string, int> action1; //~delegate void Kieu(string s, int i)
            // Action<string> action2;

            // action2 = Warning;
            // action2 += Info;

            // action2?.Invoke("Action run");

            // Func<int> f1; // ~delegate int KIEU();
            // Func<string, double, string> f2; // ~delegate string KIEU(string s, double s);(tham so duoc liet ke phia truoc, kieu tra ve phia sau)

            // Func<int, int, int> tinhToan; //~delegate int KIEU(int a, int b);

            int a = 5;
            int b = 10;
            // tinhToan = Tong;
            // Console.WriteLine($"KQ {tinhToan(a, b)}");
            Tong(a, b, Info);
        }
    }
}
