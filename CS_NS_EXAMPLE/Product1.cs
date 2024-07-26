namespace Sanpham
{
    public partial class Product1
    {
        public string name { set; get; }
        public decimal price { set; get; }

        public string GetInfo()
        {
            return $"{this.name} - {this.price}";
        }
    }
}
