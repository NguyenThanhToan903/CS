using System;

namespace Program
{
    /*
    Lamda - Anonymous fuctions
    1)
    (thamso) => bieu_thuc;


    2)
    (thamso) => {
        cacbieuthuc;
        return bieu_thuc_tra_ve;
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Action<string> thongBao;
            // thongBao = (string s) => Console.WriteLine(s); // ~delegate void KIEU(string s) = Action<string>;
            // thongBao?.Invoke("Xin chao");

            Action thongBao;
            thongBao = () => Console.WriteLine("Xin chao cac ban");
            thongBao?.Invoke();

            // (int a, int b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // }
        }
    }
}
