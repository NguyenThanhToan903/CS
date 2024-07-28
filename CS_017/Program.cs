using System;
using System.Security.Cryptography.X509Certificates;

namespace CS_017
{
    class CountNumber
    {
        public static int number = 0;

        public static void Info()
        {
            Console.WriteLine("So lan truy cap: " + number);
        }

        public void Count()
        {
            CountNumber.number++;
        }
    }

    class Student
    {
        public readonly string name;

        public Student(string _name)
        {
            this.name = _name;
        }
    }

    class Vector
    {
        double x;
        double y;

        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public void Info()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        // vector = vector + vector
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector operator +(Vector v1, double a)
        {
            return new Vector(v1.x + a, v1.y + a);
        }

        // Indexer [chiso]
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;

                        break;
                    case 1:
                        y = value;
                        break;

                    default:
                        throw new Exception("Chi so sai");
                }
            }
            get
            {
                switch (i)
                {
                    case 0:
                        return x;

                    case 1:
                        return y;

                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }
        public double this[string s]
        {
            set
            {
                switch (s)
                {
                    case "todox":
                        x = value;

                        break;
                    case "todoy":
                        y = value;
                        break;

                    default:
                        throw new Exception("Chi so sai");
                }
            }
            get
            {
                switch (s)
                {
                    case "todox":
                        return x;

                    case "todoy":
                        return y;

                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            {
                //  CountNumber c1 = new CountNumber();
                // CountNumber c2 = new CountNumber();

                // c1.Count();
                // c2.Count();
                // c2.Count();

                // CountNumber.Info();
            }
            {
                // Student s = new Student("Thanh Toan");

                // Console.WriteLine(s.name);
            }
            {
                // Vector v1 = new Vector(2, 3);
                // Vector v2 = new Vector(1, 1);

                // v1.Info();
                // v2.Info();
                // var v3 = v1 + v2;
                // v3.Info();
                // var v4 = v1 + 10;
                // v4.Info();
            }
            Vector v = new Vector(2, 3);

            v[0] = 5;
            v[1] = 6;

            v.Info();

            v["todox"] = 10;
            v["todoy"] = 10;
            v.Info();
            // v[0] ~ x
            // v[1] ~ y

            // v["todox"] ~ x
            // v["todoy"] ~ y
        }
    }
}
