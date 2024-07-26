using System;

namespace CS014_Inherit
{
    class Animal //sealed
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao lop Animal");
        }

        public Animal(string abc)
        {
            Console.WriteLine($"Khai bao Animal {abc}");
        }

        public int Legs { set; get; }

        public float Weight { set; get; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }

    class Cat : Animal
    {
        public string Food { set; get; }

        public Cat(string s)
            : base(s)
        {
            this.Legs = 4;
            this.Food = "Mouse";
            Console.WriteLine("Khoi tao lop Cat");
        }

        public void Eat()
        {
            Console.WriteLine(Food);
        }

        public new void ShowLegs()
        {
            Console.WriteLine($"Loai meo co  {Legs} chan");
        }

        public void ShowInfo()
        {
            base.ShowLegs();
            ShowLegs();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Meo");
        }
    }
}
