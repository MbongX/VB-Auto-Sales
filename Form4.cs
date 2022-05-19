using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VB_Auto_Sales
{
    public partial class Form4 : Form
    {
        private PrintDocument pd;

        public Form4()
        {
            InitializeComponent();
            //package
            comboBox1.Items.Add("Standard");
            comboBox1.Items.Add("Deluxe");
            comboBox1.Items.Add("Executive");
            comboBox1.Items.Add("Luxury");
            //interior
            //   comboBox2.Items.Add("Shampoo Carpets")  ;
            //   comboBox2.Items.Add("Shampoo Upholstery")  ;
            //   comboBox2.Items.Add("Interior Protection Coat (Dashboard and console)")  ;
            //   comboBox2.Items.Add("Scotchgard")  ;
            //Exterior
            // comboBox3.Items.Add("Hand Wash")  ;
            //  comboBox3.Items.Add("Hand Wax")  ;
            // comboBox3.Items.Add("Check Engine Fluids")  ;
            //  comboBox3.Items.Add("Detail Engine Compartments")  ;
            //  comboBox3.Items.Add("Detail Undercarriage")  ;
            //fragrance
             comboBox4.Items.Add("Hawaiian Mist");
             comboBox4.Items.Add("Baby Powder");
             comboBox4.Items.Add("Pine");
             comboBox4.Items.Add("Country Floral");
             comboBox4.Items.Add("Pine Colada");
             comboBox4.Items.Add("Vanilla");


            //disabling the other combobox
            comboBox2.Enabled = false ;
            comboBox3.Enabled = false ;
            comboBox4.Enabled = false ;

            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit Button
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print order
            //sample code ......
            PrintDialog pdialog = new PrintDialog();
            pdialog.Document = pd;
            if (pdialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem is "Standard")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Enabled = false;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox3.Items.Add("Hand Wash");
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

            }
            else if (comboBox1.SelectedItem is "Deluxe")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled= true;
                comboBox2.Items.Add("Shampoo Carpets");
                comboBox3.Items.Add("Hand Wash");
                comboBox3.Items.Add("Hand Wax");

            }
            else if (comboBox1.SelectedItem is "Executive")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox2.Items.Add("Shampoo Carpets");
                comboBox2.Items.Add("Interior Protection Coat (Dashboard and console)");
                comboBox3.Items.Add("Hand Wash");
                comboBox3.Items.Add("Hand Wax");
                comboBox3.Items.Add("Check Engine Fluids");


            }
            else if (comboBox1.SelectedItem is "Luxury")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox2.Items.Add("Shampoo Carpets");
                comboBox2.Items.Add("Shampoo Upholstery");
                comboBox2.Items.Add("Scotchgard");
                comboBox3.Items.Add("Hand Wash");
                comboBox3.Items.Add("Hand Wax");
                comboBox3.Items.Add("Check Engine Fluids");
                comboBox3.Items.Add("Detail Engine Compartments");
                comboBox3.Items.Add("Detail Undercarriage");

            }
            else
            {
                MessageBox.Show("Pick a package!!!");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 AboutVB = new Form5();
            this.Hide();
            AboutVB.ShowDialog();
            this.Show();
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
