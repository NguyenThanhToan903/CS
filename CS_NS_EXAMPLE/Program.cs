using System;
using MyNamespace;
using XYz = MyNamespace.ABC;

namespace CS_NS_EXAMPLE
{
    class Program
    {
        static void Main()
        {
            Sanpham.Product1 product = new Sanpham.Product1();
            product.name = "IPad";
            product.price = 1000;
        }
    }
}
