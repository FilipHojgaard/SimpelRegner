using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpelRegner
{
    public partial class Form1 : Form
    {
        public int Chooser;
        Beregner beregner = new Beregner();

        public Form1()
        {
            InitializeComponent();
        }

        private void udregnKnap_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(beregner.chooser);
            int svar = beregner.Calculate();
            ResultLabel.Text = svar.ToString();
        }

        private void firstNumber_ValueChanged(object sender, EventArgs e)
        {
            beregner.a = (int)firstNumber.Value;
        }

        private void secondNumber_ValueChanged(object sender, EventArgs e)
        {
            beregner.b = (int)secondNumber.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mega simpelt");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Plus")
            {
                beregner.chooser = 1;
            }
            if (comboBox1.SelectedItem == "Minus")
            {
                beregner.chooser = 2;
            }
            if (comboBox1.SelectedItem == "Gange")
            {
                beregner.chooser = 3;
            }
            if (comboBox1.SelectedItem == "Division")
            {
                beregner.chooser = 4;
            }
        }
    }
}
