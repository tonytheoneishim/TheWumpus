using System;
using System.Diagnostics;

namespace wumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string formAppPath = @"C:\Users\chang\source\repos\TheWumpus\wumps\bin\Debug\net8.0\"; // Replace with actual path
            try
            {
                Process.Start(formAppPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting form application: {ex.Message}");
            }
            Console.WriteLine("Console application continues...");
            Console.ReadKey();
        }
    }
}