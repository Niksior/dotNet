using System;

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
            program.table.TableResized += table_TableResized;
            while(program.flag)
            {
                program.ShowMenu();
                program.ChooseOption();
            }
        }

        static void table_TableResized(object sender, MyEventArgs e)
        {
            Console.WriteLine("\tTable resized to {0}.", e.TableSize);
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
            int choice = Int32.Parse(Console.ReadLine());                 
            Console.WriteLine(" ");
            switch(choice)
            {
                case 0:
                    this.flag = false;
                    break;
                case 1:
                    try
                    {
                        Console.WriteLine("Provide index to show value");
                        int val = Int32.Parse(Console.ReadLine());
                        if (val <= table.GetLastIndex() && val > -1)
                        {
                            Console.WriteLine("Value = " + table.ReadValue(val));
                        }
                        else
                        {
                            throw new OutOfRange();
                        }
                        
                    } catch (OutOfRange e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Provide index number, your actual table size equals " + (table.GetLastIndex() + 1));
                        String tmp;
                        tmp = Console.ReadLine();
                        int index = Int32.Parse(tmp);
                        if (index < 0)
                            throw new OutOfRange();
                        Console.WriteLine("Provide value, it will be written on position [" + index + "]");
                        tmp = Console.ReadLine();
                        int val = Int32.Parse(tmp);
                        table.WriteValue(index, val);
                        Console.WriteLine("Value: " + val + " saved");
                    } catch (OutOfRange e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Provide the value to add on the end of table");
                        int value = Int32.Parse(Console.ReadLine());
                        table.Add(value);
                    } catch (OutOfRange e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
        }
    }
}
