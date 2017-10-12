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

        private void checkPlus_CheckedChanged(object sender, EventArgs e)
        {
            beregner.chooser = 1;
            checkMinus.Checked = false;
            checkGange.Checked = false;
            checkDivision.Checked = false;
        }

        private void checkMinus_CheckedChanged(object sender, EventArgs e)
        {
            beregner.chooser = 2;
            checkPlus.Checked = false;
            checkGange.Checked = false;
            checkDivision.Checked = false;
        }

        private void checkGange_CheckedChanged(object sender, EventArgs e)
        {
            beregner.chooser = 3;
            checkMinus.Checked = false;
            checkPlus.Checked = false;
            checkDivision.Checked = false;
        }

        private void checkDivision_CheckedChanged(object sender, EventArgs e)
        {
            beregner.chooser = 4;
            checkMinus.Checked = false;
            checkGange.Checked = false;
            checkPlus.Checked = false;
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
    }
}
