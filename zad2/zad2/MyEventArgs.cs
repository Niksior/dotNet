using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class MyEventArgs : EventArgs
    {
        public MyEventArgs(int size)
        {
            TableSize = size;
        }
        public int TableSize { get; set; }
    }
}
