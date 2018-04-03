using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Car : IAccelerate
    {
        string name = "auto";
        int speed;

        Car(string name) => this.name = name;

        public void Accelerate(int change)
        {
            this.speed += change;
        }
    }

    public class Submarine : IAccelerate, IDive
    {
        string name = "łódź podwodna";
        int speed = 0;
        int depth = 0;

        Submarine(string name) => this.name = name;

        public void Accelerate(int change)
        {
            this.speed += change;
        }

        public void Dive(int change)
        {
            this.depth += change;
        }
    }

    public class Plane : IAccelerate, IRise
    {
        string name = "samolot";
        int speed = 0;
        int altitude = 0;

        Plane(string name) => this.name = name;

        public void Accelerate(int change)
        {
            this.speed += change;
        }

        public void Rise(int change)
        {
            this.altitude += change;
        }
    
    }

    public class Computer
    {
        string name = "komputer";

        Computer(string name) => this.name = name;
    }


}
