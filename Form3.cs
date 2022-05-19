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



        List<plug> plugs = new List<plug>();

        public Form3()
        {
            InitializeComponent();
            plugs.Add(new plug("PR214", "MR43T", "RBL8", "14K22" ));
            plugs.Add(new plug("PR223", "R43", "RJ6", "14K24" ));
            plugs.Add(new plug( "PR224", "R43N", "RN4", "14K30"));
            plugs.Add(new plug( "PR246", "R46N", "RN8", "14K44"));
            plugs.Add(new plug( "PR247", "R46TS", "RBL17Y", "14K33"));
            plugs.Add(new plug( "PR248", "R46TX", "RBL12-6", "14K35"));
            plugs.Add(new plug( "PR324", "S46", "J11", "14K38"));
            plugs.Add(new plug( "PR326", "SR46E", "XEJ8", "14K40"));
            plugs.Add(new plug("PR444", "47L", "H12", "14K44"));
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // LOOKUP LOGIC GOES FROM HERE..
            for (int i = 0; i < plugs.Count; i++) {
                WriteLine(plugs[i].getBrand_A());
            }
        }
    }
}

