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

        class DuLieuNhap : EventArgs
        {
            public int data { set; get; }

            public DuLieuNhap(int x) => data = x;
        }

        // publisher
        class UserInput
        {
            // public event SuKienNhapSo suKienNhapSo;

            //  ~ delegate void KIEU(object? sender, EventArgs args)
            public event EventHandler suKienNhapSo; //

            public void Input()
            {
                do
                {
                    Console.Write("Nhan vao so nguyen: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    suKienNhapSo?.Invoke(this, new DuLieuNhap(i));
                } while (true);
            }
        }

        class TinhCanBac2
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo += (sender, e) =>
                {
                    DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                    Console.WriteLine("Ban vua nhap so: " + duLieuNhap.data);
                };
            }

            //  ~ delegate void KIEU(object? sender, EventArgs args)

            public void Can(object sender, EventArgs e)
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                int i = duLieuNhap.data;
                Console.WriteLine($"Can bac 2 cua {i}: {Math.Sqrt(i)}");
                Console.WriteLine($"{(Double)Math.Sqrt(i) * (Double)Math.Sqrt(i)}");
            }
        }

        class BinhPhuong
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo += TinhBinhPhuong;
            }

            public void TinhBinhPhuong(object sender, EventArgs e)
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                int i = duLieuNhap.data;
                Console.WriteLine($"Binh phuong cua {i}: {i * i}");
            }
        }

        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine();
                Console.WriteLine("Thoat ung dung.");
            };
            //publisher
            UserInput userInput = new UserInput();
            //subsriber
            TinhCanBac2 tinhCan = new TinhCanBac2();

            BinhPhuong binhPhuong = new BinhPhuong();

            tinhCan.Sub(userInput);
            binhPhuong.Sub(userInput);

            userInput.Input();
        }
    }
}
