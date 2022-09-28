using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = "Odabrali ste prijevoz " + Environment.NewLine;
            if (radioButtonAvion.Checked ==true) { Text += "Avion"; }
            if (radioButtonAutobus.Checked == true) { Text += "Autobus"; }
            if (radioButtonVlastiti.Checked == true) { Text += "Vlastiti prijevoz"; }
            textBox1.Text = Text;
        }
    }
}
