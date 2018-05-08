using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            lastIndex = 0;
        }

        public void ReadValue(int i)
        {
            if(i < lastIndex && i >= 0)
            {
                Console.WriteLine("Value = " + table[i]);
            } else
            {
                throw new OutOfRange();
            }
                
        }

        public void WriteValue()
        {
            Console.WriteLine("Provide index number, your actual table range is 0-" + (table.Length - 1));
            String tmp;
            tmp = Console.ReadLine();
            int index = Int32.Parse(tmp);
            if (index < 0)
                throw new OutOfRange();
            if (index > table.Length - 1)
            {
                this.lastIndex = index;
                ResizeTable(index + 1);
            }
            Console.WriteLine("Provide value, it will be written on position [" + index + "]");
            tmp = Console.ReadLine();
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
            if(lastIndex == 0) /////////////////////////
            lastIndex++;
            table[lastIndex] = value;
        }

    }
}
