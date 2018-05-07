using System;
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
        int speed = 0;

        public Car(string name)
        {
            this.name = name;
        }
        public void Accelerate(int change)
        {
            this.speed = change;
        }
        string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return name;
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }
    }

    public class Submarine : IAccelerate, IDive
    {
        string name = "łódź podwodna";
        int speed = 0;
        int depth = 0;

        public Submarine(string name)
        {
            this.name = name;
        }
        public void Accelerate(int change)
        {
            this.speed = change;
        }

        public void Dive(int change)
        {
            this.depth = change;
        }
        string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return name;
        }
        public int Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                this.depth = value;
            }
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }
    }

    public class Plane : IAccelerate, IRise
    {
        string name = "samolot";
        int speed = 0;
        int altitude = 0;

        public Plane(string name)
        {
            this.name = name;
        }
        public void Accelerate(int change)
        {
            this.speed = change;
        }

        public void Rise(int change)
        {
            this.altitude = change;
        }
        string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return name;
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }
        public int Altitude
        {
            get
            {
                return this.altitude;
            }
            set
            {
                this.altitude = value;
            }
        }

    }

    public class Computer
    {
        string name = "komputer";

        public Computer(string name)
        {
            this.name = name;
        }
        string getName()
        {
            return name;
        }
        public override string ToString()
        {
            return name;
        }
    }


}
