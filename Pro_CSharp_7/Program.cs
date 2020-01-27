using System;
using System.Windows.Forms;

namespace SimpleCSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Setup Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("*********************************************************");
            Console.WriteLine("********* Welcome to my Rocking App *********************");
            Console.WriteLine("*********************************************************");

            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for enter 
            Console.ReadLine();

            MessageBox.Show ("All Done!");

        }
    }
}
