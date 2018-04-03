using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> ownedToys = new List<string>();

        public Form1()
        {
            InitializeComponent();
            List<string> toyList = new List<string>();
            toyList.Add("Łódź podwodna");
            toyList.Add("Samolot");
            toyList.Add("Samochód");
            toyList.Add("Komputer");

            toyCatalog.DataSource = toyList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decreaseAltitude_Click(object sender, EventArgs e)
        {

        }

        private void toyOwned_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            if(index == 0)
            {

            }
        }
    }
}
