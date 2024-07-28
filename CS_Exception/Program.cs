using System;
using MyException;

namespace CS_Exception
{
    class Program
    {
        static void Register(string? name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }

            if (age <= 18 || age > 100)
            {
                throw new AgeException(age);
            }
            Console.WriteLine($"Xin chao: {name} ({age})");
        }

        static void Main(string[] args)
        {
            try
            {
                Register("Nguyen Thanh Toan", 10);
            }
            catch (NameEmptyException nee)
            {
                Console.WriteLine(nee.Message);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
                ae.Detail();
            }
        }
    }
}
