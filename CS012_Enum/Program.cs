using System;

namespace CS012_Enum
{
    class Program
    {
        enum HOCLUC
        {
            Kem = 1,
            TrungBinh = 2,
            Kha = 3,
            Gioi = 4,
        }

        static void Main(string[] args)
        {
            HOCLUC hocLuc;
            hocLuc = HOCLUC.Kem;
            int so = (int)hocLuc;
            Console.WriteLine(so);
        }
    }
}
