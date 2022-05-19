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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //submit button
            CarSale vbSales = new CarSale();
            this.Hide();
            vbSales.ShowDialog(); //-> New form overlays the prev form
            this.Show(); // if you don't want the form to overlay you can omit the above code then include this one only
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // <a href="https://www.flaticon.com/free-icons/login" title="login icons">Login icons created by Freepik - Flaticon</a>
        }
    }
}
