using System;

namespace zad2
{
    class Tablica
    {
        private int[] table;
        private int lastIndex;
        private int defaultValue;
        public event EventHandler<MyEventArgs> TableResized;

        public Tablica()
        {
            this.table = new int[3];
            this.defaultValue = 3;
            this.FillTable(table);
            this.lastIndex = -1;
        }

        public int GetLastIndex()
        {
            return lastIndex;
        }

        public int GetTableLength()
        {
            return table.Length;
        }

        protected virtual void OnTableResized(MyEventArgs e)
        {
            TableResized?.Invoke(this, e);
        }


        public int ReadValue(int i)
        {
            return table[i];
                
        }

        public void WriteValue(int index, int val)
        {      
            if (index > table.Length - 1)
            {
                ResizeTable((index + 1) * 2);
            }
            if (index > lastIndex) lastIndex = index;
            table[index] = val;
        }

        private void FillTable(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = defaultValue;
        }

        private void ResizeTable(int newSize)
        {
            int[] tmp = new int[newSize];
            FillTable(tmp);
            for (int i = 0; i < lastIndex; i++)
                tmp[i] = table[i];
            this.table = tmp;
            
            OnTableResized(new MyEventArgs(newSize));
        }

        public void Add(int value)
        {
            if(table.Length - 1 == lastIndex)
            {
                ResizeTable(table.Length * 2);
            }
            lastIndex++;
            table[lastIndex] = value;
        }

    }
}
