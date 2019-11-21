using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total;
            double average;

            total = Convert.ToDouble(txtScore1.Text) + Convert.ToDouble(txtScore2.Text) +
                 Convert.ToDouble(txtScore3.Text) + Convert.ToDouble(txtScore4.Text) +
                  Convert.ToDouble(txtScore5.Text);

            average = total / 5;

            lblResult.Text = "Average score is: " + average;
        }
    }
}
