using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedPraisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_raise_Click(object sender, EventArgs e)
        {
            double salaryIncrease;
            double entry;

            entry = Convert.ToDouble(txt_entry.Text);
            salaryIncrease = entry * 1.04;

            lbl_result.Text = "New salary increase is " + salaryIncrease; 
        }

        private void txt_entry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
