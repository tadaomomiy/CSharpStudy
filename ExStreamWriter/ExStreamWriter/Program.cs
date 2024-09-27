namespace ExStreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\fazso\source\repos\file1.txt";
            string targetPath = @"C:\Users\fazso\source\repos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
