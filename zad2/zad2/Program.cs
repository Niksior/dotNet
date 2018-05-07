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
        private bool flag = true;

        public Program()
        {

        }

        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[12];
            Console.Title = "Tabbed";
            Program program = new Program();
            while(program.flag)
            {
                program.ShowMenu();
                program.ChooseOption();
            }
            
 
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
            Console.WriteLine("0 - exit");
            Console.WriteLine("---------------------------------------");
        }

        private void ChooseOption()
        {
            Console.Write("Val: ");
            int choice = Console.Read() - 48;
            Console.ReadLine();                 //consuming the buffer
            Console.WriteLine(" ");
            switch(choice)
            {
                case 0:
                    this.flag = false;
                    break;
            }
           
        }
    }
}
