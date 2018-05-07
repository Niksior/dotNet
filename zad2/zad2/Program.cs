using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        private Tablica table = new Tablica();

        public Program()
        {

        }

        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[12];
            Console.Title = "Tabbed";
            Program program = new Program();
            program.ShowMenu();
 
        }

        private void ShowMenu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hello");
            Console.WriteLine("I am your int table");
            Console.WriteLine("Choose and option");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 - show value");
            Console.WriteLine("2 - write value on index");
            Console.WriteLine("3 - add value on the end");
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
