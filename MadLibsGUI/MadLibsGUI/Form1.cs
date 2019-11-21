using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txt_PickANumber1.Text) - Convert.ToDouble(txt_PickANumber2.Text);

            lbl_Result.Text = "The " + txt_Color.Text + "Dragon is the " + txt_WordEndingInEst +
                "Dragon of all. It has " + num + " " + txt_BodyPartPlural +
                ", and a " + txt_Animal.Text + " Shaped like a " + txt_Noun +
                ", although it will feast on nearly anything."; 
        }
    }
}
