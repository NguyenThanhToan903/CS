using System;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace fileExample
{
    public class Program
    {
        class Product
        {
            public int ID { set; get; }
            public double Price { set; get; }

            public string Name { set; get; }

            public void Save(Stream stream)
            {
                // int -> 4 byte
                var bytes_id = BitConverter.GetBytes(ID);
                stream.Write(bytes_id, 0, 4);

                // double -> 8 byte

                var bytes_price = BitConverter.GetBytes(Price);
                stream.Write(bytes_price, 0, 8);

                var bytes_name = Encoding.UTF8.GetBytes(Name);
                var bytes_length = BitConverter.GetBytes(bytes_name.Length);
                stream.Write(bytes_length, 0, 4);
                stream.Write(bytes_name, 0, bytes_name.Length);
            }

            public void Restore(Stream stream)
            {
                var bytes_id = new byte[4];
                stream.Read(bytes_id, 0, 4);
                ID = BitConverter.ToInt32(bytes_id, 0);

                var bytes_price = new byte[8];
                stream.Read(bytes_price, 0, 8);
                Price = BitConverter.ToDouble(bytes_price, 0);

                var bytes_length = new byte[4];
                stream.Read(bytes_length, 0, 4);
                int Length = BitConverter.ToInt32(bytes_length, 0);

                var bytes_name = new byte[Length];
                stream.Read(bytes_name, 0, Length);
                Name = Encoding.UTF8.GetString(bytes_name, 0, Length);
            }
        }

        public static void Main(string[] args)
        {
            {
                // var drives = DriveInfo.GetDrives();
                // DriveInfo drive = new DriveInfo("C:\\");
                // foreach (var drive in drives)
                // {
                //     Console.WriteLine($"Drive: {drive.Name}");
                //     Console.WriteLine($"Drive Type: {drive.DriveType}");
                //     Console.WriteLine($"Label: {drive.VolumeLabel}");
                //     Console.WriteLine($"Format: {drive.DriveFormat}");
                //     Console.WriteLine($"Size: {drive.TotalSize}");
                //     Console.WriteLine($"Free: {drive.TotalFreeSpace}");
                // }

                // string path = "obj";

                // if (Directory.Exists(path))
                // {
                //     Console.WriteLine($"{path} - Ton tai");
                // }
                // else
                // {
                //     Console.WriteLine($"{path} - Khong ton tai");
                // }

                // var files = Directory.GetFiles(path);

                // foreach (var file in files)
                // {
                //     Console.WriteLine(file);
                // }
            }

            {
                // string filename = "abc.txt";
                //         IEnumerable<string> content = new List<string> { "Xin chao cac ban 2022" };
                //         File.AppendAllLines(filename, content);
            }
            // File.Delete("456.txt");


            // Read/ Write with stream

            string path = "data.dat";
            using var stream = new FileStream(path: path, FileMode.Open);

            // Luu du lieu

            {
                // byte[] buffer = { 1, 2, 3 };
                // int offset = 0;
                // int count = 3;

                // stream.Write(buffer, offset, count);

                // // Doc du lieu
                // int soByteDocDuoc = stream.Read(buffer, offset, count);

                // // int, double, .. -> Byte
                // int abc = 1;
                // var bytes_abc = BitConverter.GetBytes(abc);
                // // bytes --> int, double,..

                // BitConverter.ToInt32(bytes_abc, 0);

                // string s = "Abc";
                // var bytes_s = Encoding.UTF8.GetBytes(s);

                // Encoding.UTF8.GetString(bytes_s, 0, 10);
            }
            Product product = new Product();
            // {
            //     ID = 10,
            //     Price = 234,
            //     Name = "San pham abc"
            // };

            // product.Save(stream);

            product.Restore(stream);

            Console.WriteLine($"{product.ID} - {product.Price} - {product.Name}");
        }
    }
}
