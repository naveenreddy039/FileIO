using System;
using System.IO;

namespace Address13FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\hp\source\repos\Address13FileIO\Address13FileIO\Book.txt";

            Program.ReadAllLines(path);
            ReadFromStreamReader(path);
            WriteFromStreamWriter(path);

           
        }

        static void ReadAllLines(string path)
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);


        }
       
        
        
        public static void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
            Console.ReadKey();
        }
        public static void WriteFromStreamWriter(string path)
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World- .Net is awasome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}
