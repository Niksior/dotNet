using System;

namespace zad2
{
    class Tablica
    {
        private int[] table;
        private int lastIndex;
        private int defaultValue = 6;
        public event EventHandler<MyEventArgs> TableResized;
        //https://docs.microsoft.com/pl-pl/dotnet/standard/events/how-to-raise-and-consume-events

     

        public Tablica()
        {
            table = new int[3];
            lastIndex = -1;
            
        }

        protected virtual void OnTableResized(MyEventArgs e)
        {
            EventHandler<MyEventArgs> handler = TableResized;
            if(handler != null)
            {
                handler(this, e);
            }
        }


        public void ReadValue(int i)
        {
            if(i <= lastIndex && i > -1)
            {
                Console.WriteLine("Value = " + table[i]);
            } else
            {
                throw new OutOfRange();
            }
                
        }

        public void WriteValue()
        {
            
            Console.WriteLine("Provide index number, your actual table size equals " + lastIndex + 1);
            String tmp;
            tmp = Console.ReadLine();
            int index = Int32.Parse(tmp);
            if (index < 0)
                throw new OutOfRange();
            while (index > table.Length - 1)
            {
                ResizeTable(table.Length * 2);
            }
            Console.WriteLine("Provide value, it will be written on position [" + index + "]");
            tmp = Console.ReadLine();
            if (index > lastIndex) lastIndex = index;
            int parsed = Int32.Parse(tmp);
            table[index] = parsed;
            Console.WriteLine("Value: " + parsed + " saved");
        }

        private void FillTable(int[] tmp ,int range)
        {
            for (int i = 0; i < range; i++)
                tmp[i] = defaultValue;
        }

        private void ResizeTable(int newSize)
        {
            int[] tmp = new int[newSize];
            FillTable(tmp, lastIndex);
            for (int i = 0; i < table.Length; i++)
                tmp[i] = table[i];
            this.table = tmp;
            MyEventArgs args = new MyEventArgs();
            args.TableSize = newSize;
            OnTableResized(args);
        }

        public void Add()
        {
            if(table.Length - 1 == lastIndex)
            {
                ResizeTable(table.Length * 2);
            }
            Console.WriteLine("Provide the value to add on the end of table");
            int value = Int32.Parse(Console.ReadLine());
            lastIndex++;
            table[lastIndex] = value;
        }

    }
}
