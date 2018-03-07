using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IAccelerate
    {
        int Accelerate(int change);
    }

    interface IDive
    {
        int Dive(int change);
    }

    interface IRise
    {
        int Rise(int Rise);
    }
}
