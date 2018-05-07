using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IAccelerate
    {
        void Accelerate(int change);
        int Speed { get; set; }
    }

    interface IDive
    {
        void Dive(int change);
        int Depth { get; set; }
    }

    interface IRise
    {
        void Rise(int change);
        int Altitude { get; set; }
    }
}
