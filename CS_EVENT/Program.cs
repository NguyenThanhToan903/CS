using System;

namespace CS_EVENT
{
    class Program
    {
        /*
            publisher -> class - phat su kien
            subsriber -> class - nhan su kien
        */
        public delegate void SuKienNhapSo(int x);

        // publisher
        class UserInput
        {
            public SuKienNhapSo suKienNhapSo { set; get; }

            public void Input()
            {
                do
                {
                    Console.Write("Nhan vao so nguyen: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    suKienNhapSo?.Invoke(i);
                } while (true);
            }
        }

        class TinhCanBac2
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo = Can;
            }

            public void Can(int i)
            {
                Console.WriteLine($"Can bac 2 cua {i}: {Math.Sqrt(i)}");
            }
        }

        static void Main(string[] args)
        {
            //publisher
            UserInput userInput = new UserInput();
            //subsriber
            TinhCanBac2 tinhCan = new TinhCanBac2();

            tinhCan.Sub(userInput);
            userInput.Input();
        }
    }
}
