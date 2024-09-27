using System.IO;

namespace ExFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\fazso\source\repos\file1.txt";
            string targetPath = @"C:\Users\fazso\source\repos\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);    
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("an error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
