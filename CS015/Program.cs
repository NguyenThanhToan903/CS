using System;

namespace CS015
{
    // virtual method
    // Cannot create an instance of the abstract type or interface (Chi dung de ke thua)
    abstract class Product
    {
        protected double Price { set; get; }

        // public virtual void ProductInfor()
        // {
        //     Console.WriteLine($"Gia San Pham {Price}");
        // }
        public abstract void ProductInfor();

        public void Test() => ProductInfor();
    }

    // interface kha giong abstract
    // Khai bao nhung khong dung tao ra doi tuong, chi duoc dung tao ra co so
    //
    interface IHinhHoc
    {
        public double TinhChuVi();

        public double TinhDienTic();
    }

    class HinhChuNhat : IHinhHoc
    {
        public double a { set; get; }
        public double b { set; get; }

        public HinhChuNhat(double _a, double _b)
        {
            this.a = _a;
            this.b = _b;
        }

        public double TinhChuVi()
        {
            return 2 * (a + b);
        }

        public double TinhDienTic()
        {
            return a * b;
        }
    }

    class HinhTron : IHinhHoc
    {
        public double r { set; get; }

        public HinhTron(double _r)
        {
            this.r = _r;
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * r;
        }

        public double TinhDienTic()
        {
            return r * r * Math.PI;
        }
    }

    // Lop ke thua, inherit
    class Iphone : Product
    {
        public Iphone() => Price = 500;

        // Dinh nghia lai cho lop trua tuong.

        // Nap chong phuong thuc
        public override void ProductInfor()
        {
            Console.WriteLine("Dien Thoai Iphone");
            Console.WriteLine($"Gia cua san pham {Price}");
            // base.ProductInfor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Iphone I = new Iphone();
            // I.Test();

            HinhChuNhat h = new HinhChuNhat(4, 5);
            Console.WriteLine($"Dien Tich: {h.TinhDienTic()}, Chi vi: {h.TinhChuVi()}");

            HinhTron t = new HinhTron(1);
            Console.WriteLine($"Dien Tich: {t.TinhDienTic()}, Chi vi: {t.TinhChuVi()}");
        }
    }
}
