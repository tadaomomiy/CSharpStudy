﻿using System;

namespace ExTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            } catch (FormatException ex)
            {
                Console.WriteLine("Format error!" + ex.Message);
            } finally
            {

            }
        }
    }
}
