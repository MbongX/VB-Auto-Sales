using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_Auto_Sales
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            richTextBox1.Text = "VB Auto Centre prides itself on meeting all of its customers' automobile needs. The centre has facilities with everything related to vehicles, including sales and leasing for new and used cars, auto service and repair, detail shop, car wash, and auto parts. VB Auto Centre is looking to improve its services by automating its day-to-day activities and giving flexibility and control to its customers.";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void carwashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 CarWash = new Form4();
            this.Hide();
            CarWash.ShowDialog();
            this.Show();
        }

        private void autoPartsLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 SparkTables = new Form3();
            this.Hide();
            SparkTables.ShowDialog(); //-> New form overlays the prev form
            this.Show();
        }

        private void vehicleSalesFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarSale carSale = new CarSale();
            this.Hide();
            carSale.ShowDialog();
            this.Show();
        }
    }
}
