using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string s = "";
                int max = Int32.Parse(sr.ReadLine()), num = 0;
                for (int i = 0; i < 10; i++)
                {
                    Convert.ToInt32(sr.ReadLine());

                    s = sr.ReadLine();
                    if (int.TryParse(s, out num)) max = max < num ? num : max;
                    while (s != null) ;
                    sr.Close();
                    using (StreamWriter sw = new StreamWriter(path)) ;
                    sr.ReadLine();
                    sr.Close();
                }
            }
        }
    }
}



