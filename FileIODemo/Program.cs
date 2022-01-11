using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            String path = @"C:\Users\hp\source\repos\FileIODemo\FileIODemo\Example.txt";
            String path1 = @"C:\Users\hp\source\repos\FileIODemo\FileIODemo\ExampleDemo.txt";

            //Program.ReadAllLines(path);
            ReadFileExist(path);
            //Program.ReadAllText(path);
            FileCopy(path,path1);
            //DeleteFile(path);
            ReadFromStreamReader(path);
            WriteFromStreamWriter(path);


            Console.ReadKey();

            static void ReadFileExist(string path)
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("File exists");

                }
                else
                {
                    Console.WriteLine("File doesNot exist");
                }
            }
            
           
        }
        static void ReadAllLines(string path)
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

           
        }
        static void ReadAllText(string path)
        {
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            

          
        }
        static void FileCopy(string path,string path1)
        {
            File.Copy(path, path1);
            Console.WriteLine("***********************");
        }
        public static void DeleteFile(string path)
        {
            File.Delete(path);
            Console.ReadKey();
        }
        public static void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path)) 
            {
                string s = "";

                while((s= sr.ReadLine()) !=null)
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
