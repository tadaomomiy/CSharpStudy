using ExercicioStream.Entities;
using System.Globalization;

namespace ExercicioStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\temp\myFolder\newfolder";
            //string filePath = @"C:\temp\myFolder\newfolder\product.csv"; // Mine

            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }

                    //Directory.CreateDirectory(path + @"\out");

                    //string targetPath = path + @"\out\summary.csv";

                    //using (StreamReader sr = new StreamReader(filePath))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {
                    //        string line = sr.ReadLine();
                    //        string[] cells = line.Split(',');
                    //        double price = double.Parse(cells[1], CultureInfo.InvariantCulture);
                    //        int quantity = int.Parse(cells[2]);

                    //        double totalValue = price * quantity;

                    //        using (StreamWriter sw = File.AppendText(targetPath))
                    //        {
                    //            sw.WriteLine(cells[0] + "," + totalValue.ToString("F2", CultureInfo.InvariantCulture));
                    //        }
                    //    }
                    //}
                    //Console.WriteLine("Success"); //Mine

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
