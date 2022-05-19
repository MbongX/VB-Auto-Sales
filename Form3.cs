using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB_Auto_Sales.models;
using static System.Console;

namespace VB_Auto_Sales
{
    public partial class Form3 : Form
    {


        //list of objects that will be treating as an object
        List<plug> plugs = new List<plug>();

        public string Vs { get; private set; }

        public Form3()
        {
            InitializeComponent();
            plugs.Add(new plug( "PR214", "MR43T", "RBL8", "14K22" ));
            plugs.Add(new plug( "PR223", "R43", "RJ6", "14K24" ));
            plugs.Add(new plug( "PR224", "R43N", "RN4", "14K30"));
            plugs.Add(new plug( "PR246", "R46N", "RN8", "14K44"));
            plugs.Add(new plug( "PR247", "R46TS", "RBL17Y", "14K33"));
            plugs.Add(new plug( "PR248", "R46TX", "RBL12-6", "14K35"));
            plugs.Add(new plug( "PR324", "S46", "J11", "14K38"));
            plugs.Add(new plug( "PR326", "SR46E", "XEJ8", "14K40"));
            plugs.Add(new plug( "PR444", "47L", "H12", "14K44"));
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Lookup Method 
            var SparkQuery = from i in plugs
                             where i.ToString() == "14k44"
                             select new { Vs = i.getVB_Brand() };
            foreach (var i in SparkQuery)
                textBox2.Text = Vs;          
         
        }

        private void vehicleSalesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarSale carSale = new CarSale();
            this.Hide();
            carSale.ShowDialog();
            this.Show();
        }

        private void autoPartsLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 SparkTables = new Form3();
            this.Hide();
            SparkTables.ShowDialog();
            this.Show();
        }

        private void carwashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 CarWash = new Form4();
            this.Hide();
            CarWash.ShowDialog();
            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 AboutVB = new Form5();
            this.Hide();
            AboutVB.ShowDialog();
            this.Show();
        }
    }
}

