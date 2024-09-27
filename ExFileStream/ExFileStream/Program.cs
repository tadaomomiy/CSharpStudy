namespace ExFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fazso\source\repos\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs); // maneira comum
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
            finally { 
                if(sr != null) sr.Close();
                //if(fs != null) fs.Close();
            }
        }
    }
}
