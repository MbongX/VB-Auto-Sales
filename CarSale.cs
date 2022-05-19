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
    public partial class CarSale : Form
    {
        //class Calculate { public double Calculate() { } }
        //constants of the program
        const double stereoSystem = 5999d;
        const double leatherInterior = 29999d;
        const double compNavigator = 15900d;
        const double standard = 0d;
        const double pearlized = 9999d;
        const double customizedDetailing = 12999d;
        const double taxRate = 0.15d;
        double extFinish;
        double carSale;
        //Method to calculate the subtotal(excluding vat/tax)
        double calc(double saleValue, double extraValue)
        {
            double amount = saleValue + extraValue;
            return amount;
        }
        //Method to check on which checkbox has been selected then add up the values before bringing them ont the calc function to calculate
        double checkBoxState()
        {
            double accessoriesTotal;
            if (acc_Stereo.Checked && acc_Leather.Checked && acc_Nav.Checked)
            {
                accessoriesTotal = stereoSystem + leatherInterior + compNavigator;
            }
            else if (acc_Stereo.Checked && acc_Leather.Checked)
            {
                accessoriesTotal = stereoSystem + leatherInterior;
            }
            else if (acc_Stereo.Checked)
            {
                accessoriesTotal = stereoSystem;
            }
            else if (acc_Leather.Checked)
            {
                accessoriesTotal = leatherInterior;
            }
            else if (acc_Nav.Checked)
            {
                accessoriesTotal = compNavigator;
            }
            else
            {
                accessoriesTotal = 0d;
            }
            return accessoriesTotal;
        }

        //Method to check on which radio button has been enabled on the Exterior Finish GroupBox
        double radioState()
        {
            if (fin_Standard.Checked)
            {
                extFinish = standard;
            }
            else if (fin_Pearl.Checked == true)
            {
                extFinish = pearlized;
            }
            else if (fin_Detail.Checked == true)
            {
                extFinish = customizedDetailing;
            }
            else
            {
                MessageBox.Show("Choose an exterior finishing for your car !!!");
            }
            return extFinish;
        }
        public CarSale()
        {
            InitializeComponent();
        }

        private void CarSale_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate Button

            //car sale value
            double carSaleV()
            {
                try
                {
                    carSale = Double.Parse(CarSalePrice.Text);
                }
                catch (Exception input)
                {
                    label9.Text = input.Message;
                }
                return carSale;
            }
            //trade in value if present
            string tradeInValue = TradeIn.Text;

            //variable declared for use late to store the Trade-In value
            double tValue;

            //checking wheather or not is the trad-In Value stated if not we use '0'
            if (tradeInValue.Length > 0)
            {
                tValue = Double.Parse(TradeIn.Text);
            }
            else
            {
                tValue = 0;
            }
            ///**************************
            double accessoryFinishV = checkBoxState() + extFinish;
            //SubTotal
            double subTotal = calc(carSaleV(), accessoryFinishV);
            //Tax                                                 
            double tax = subTotal * taxRate;
            //Grand Total ^_^
            double totalIncTax = subTotal + tax;
            //Printing out the Accessory & Finish Total
            Acc_finish.Text = accessoryFinishV.ToString();
            //Printing out the Subtotal
            Subtotal.Text = subTotal.ToString();
            //Printngout the sales tax 
            Tax.Text = tax.ToString();
            //Printing the total
            Total.Text = totalIncTax.ToString();
            //Printing the Amount Due
            AmountDue.Text = (totalIncTax - tValue).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Print Button
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Button
            //clearing out data in the textboxes
            CarSalePrice.Clear();
            Acc_finish.Clear();
            Subtotal.Clear();
            Tax.Clear();
            Total.Clear();
            TradeIn.Clear();
            AmountDue.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exit Button
            Close();
        }
        //Checking RadioButton state and assigning a variable is checked
        private void ExtFinishRButton_CheckedChanged(object sender, EventArgs e)
        {
            extFinish = standard;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            extFinish = pearlized;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            extFinish = customizedDetailing;
        }

        private void AllRadioBoxes_CheckedChanged(Object sender, EventArgs e)
        {
            // Check if the raiser of the event is a checked Checkbox.
            // Of course we also need to to cast it first.
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
            }
            else
            {
                MessageBox.Show("Please choose an exterior finish");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void claculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Calculate Menu Strip

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Calculate
            button1_Click(sender, e);
        }

        private void exitToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoPartsLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 Form3 SparkTables = new Form3();
            this.Hide();
            SparkTables.ShowDialog(); //-> New form overlays the prev form
            this.Show(); // if you don't want the form to overlay you can omit the above code then include this one only
        }
    }
}