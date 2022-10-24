using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
