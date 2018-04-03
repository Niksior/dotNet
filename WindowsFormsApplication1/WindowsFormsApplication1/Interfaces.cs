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
    }

    interface IDive
    {
        void Dive(int change);
    }

    interface IRise
    {
        void Rise(int change);
    }
}
