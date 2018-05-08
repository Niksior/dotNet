using System;

namespace zad2
{
    class Tablica
    {
        private int[] table;
        private int lastIndex;
        private int defaultValue = 6;

        public Tablica()
        {
            table = new int[3];
            FillTable(table);
            lastIndex = -1;
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
            
            Console.WriteLine("Provide index number, your actual table size equals " + lastIndex);
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
            Console.WriteLine("Value: " + lastIndex + " lastindes");
            Console.WriteLine("Value: " + table.Length + " length");
            int parsed = Int32.Parse(tmp);
            table[index] = parsed;
            Console.WriteLine("Value: " + parsed + " saved");
        }

        private void FillTable(int[] tmp)
        {
            for (int i = 0; i < tmp.Length; i++)
                tmp[i] = defaultValue;
        }

        private void ResizeTable(int newSize)
        {
            int[] tmp = new int[newSize];
            FillTable(tmp);
            for (int i = 0; i < table.Length; i++)
                tmp[i] = table[i];
            this.table = tmp;
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
