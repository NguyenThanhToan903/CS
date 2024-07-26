using System;

namespace CS012_structEnum
{
    class Program
    {
        // class Product{
        //     public string name;
        //     public double price;

        //     public string info{
        //         get{
        //             return $"{name}, {price}";
        //         }
        //     }
        //     public string GetInfo(){
        //         return $"Ten san pham: {name}, gia: {price}";
        //     }
        //     public Product(string _name, double _price){
        //         name = _name;
        //         price = _price;
        //     }
        // }

        // Enum

        enum HOCLUC
        {
            Kem = 10,
            TrungBinh = 20,
            Kha = 30,
            Gioi = 40
        }

        static void Main(string[] args)
        {
            // Product sanpham1 = new Product("", 0);
            // sanpham1.name = "Iphone";
            // sanpham1.price = 1000;

            // Product sanpham2 = new Product("Nokia", 900);

            // sanpham2 = sanpham1;
            // sanpham2.name = "Iphone X";

            // Console.WriteLine(sanpham1.GetInfo());
            // Console.WriteLine(sanpham2.GetInfo());
            // Console.WriteLine(sanpham2.info);
        }
    }
}
