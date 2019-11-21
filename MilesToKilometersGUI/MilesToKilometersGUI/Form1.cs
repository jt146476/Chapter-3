using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double milesEntered;
            double Kilos;
            const double MILES_TO_KILOS = 1.6;

            milesEntered = Convert.ToDouble(txtMiles.Text);
            Kilos = milesEntered * MILES_TO_KILOS;

            lblToKilos.Text = "Kilometers is " + Kilos; 
        }
    }
}
