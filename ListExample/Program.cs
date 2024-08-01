using System;
using System.Collections.Generic;

namespace ListExample
{
    public class Program
    {
        // List
        public static void Main(string[] args)
        {
            List<int> ds1 = new List<int>();
            // List<string> ds2;

            ds1.Add(1);
            ds1.Add(2);

            ds1.AddRange(new int[] { 3, 4, 5 });

            // Console.WriteLine(ds1.Count());
            // Console.WriteLine(ds1[1]);

            foreach (var item in ds1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
