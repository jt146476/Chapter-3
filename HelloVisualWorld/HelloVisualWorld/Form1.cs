using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class HelloVisualWorld : Form
    {
        public HelloVisualWorld()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }

        private void btn_goodbye_Click(object sender, EventArgs e)
        {
            helloLabel.Visible = false;
        }
    }
}
