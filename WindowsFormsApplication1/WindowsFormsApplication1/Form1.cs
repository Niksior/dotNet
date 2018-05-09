using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MainActions actions = new MainActions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toyCatalog.Items.Add("Łódź podwodna");
            toyCatalog.Items.Add("Samolot");
            toyCatalog.Items.Add("Samochód");
            toyCatalog.Items.Add("Komputer");
        }

        

        private void toyOwned_SelectedIndexChanged(object sender, EventArgs e)
        {
            speedBox.Enabled = false;
            depthBox.Enabled = false;
            altitudeBox.Enabled = false;
            depthValue.Text = "0";
            altitudeValue.Text = "0";
            speedValue.Text = "0";

            if (toyOwned.SelectedItem is IAccelerate)
            {
                speedBox.Enabled = true;
                speedValue.Text= ((IAccelerate) toyOwned.SelectedItem).Speed.ToString();
                
            }
            if (toyOwned.SelectedItem is IDive)
            {
                depthBox.Enabled = true;
                depthValue.Text = ((IDive)toyOwned.SelectedItem).Depth.ToString();
            }
            if (toyOwned.SelectedItem is IRise)
            {
                altitudeBox.Enabled = true;
                altitudeValue.Text = ((IRise)toyOwned.SelectedItem).Altitude.ToString();
            }
        }

        private void toyCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = toyCatalog.SelectedItem.ToString();
            toyNameBox.Text = curItem;
        }

        private void toyAdd_Click(object sender, EventArgs e)
        {
            int index = toyCatalog.SelectedIndex;
            string name = toyNameBox.Text;

            int i = 0;
            string newName = name;
            while(checkName(newName))
            {
                newName = String.Concat(name , i.ToString());
                i++;
            }

            if (index == 0)
            {
                Submarine submarine = new Submarine(newName);
                toyOwned.Items.Add(submarine);
            } else if(index == 1)
            {
                Plane plane = new Plane(newName);
                toyOwned.Items.Add(plane);
            } else if(index == 2)
            {
                Car car = new Car(newName);
                toyOwned.Items.Add(car);
            } else if(index == 3)
            {
                Computer computer = new Computer(newName);
                toyOwned.Items.Add(computer);
            }
        }

        private void toyDelete_Click(object sender, EventArgs e)
        {
            if (toyOwned.SelectedIndex > 0)
            { 
                toyOwned.Items.RemoveAt(toyOwned.SelectedIndex);
            }
        }

        private void increaseSpeed_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            accelerate.Accelerate(accelerate.Speed + 1);

            speedValue.Text = accelerate.Speed.ToString();
        }

        private void decreaseSpeed_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            accelerate.Accelerate(accelerate.Speed - 1);

            speedValue.Text = accelerate.Speed.ToString();
        }

        private void increaseAltitude_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IRise altitude = toy as IRise;

            altitude.Rise(altitude.Altitude + 1);

            altitudeValue.Text = altitude.Altitude.ToString();
        }
        private void decreaseAltitude_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IRise altitude = toy as IRise;

            altitude.Rise(altitude.Altitude - 1);

            altitudeValue.Text = altitude.Altitude.ToString();
        }

        private void increaseDepth_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IDive dive = toy as IDive;

            dive.Dive(dive.Depth + 1);

            depthValue.Text = dive.Depth.ToString();
        }

        private void decreaseDepth_Click(object sender, EventArgs e)
        {
            object toy = toyOwned.SelectedItem;

            IDive dive = toy as IDive;

            dive.Dive(dive.Depth - 1);

            depthValue.Text = dive.Depth.ToString();
        }

        public bool checkName(string name)
        {
            bool exist = false;
            foreach (var nam in toyOwned.Items)
            {
                if (nam.ToString() == name) exist = true;
            }
            return exist;
        }
    }
}
