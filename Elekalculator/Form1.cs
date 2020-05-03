using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Elekalculator
{
    public partial class Form1 : Form
    {
        double value = 0.0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((result.Text == "0") || (operationPressed))
            {
                result.Clear();
                operationPressed = false;
            }

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text += b.Text;
            }
            else
                result.Text += b.Text;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
                buttonEqual.PerformClick();
            else
                value = double.Parse(result.Text, CultureInfo.InvariantCulture);

            operation = b.Text;
            operationPressed = true;
            equation.Text = value.ToString(CultureInfo.InvariantCulture) + " " + operation;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            switch (operation)
            {
                case "+":
                    result.Text = (double.Parse(result.Text, CultureInfo.InvariantCulture) + value).ToString(CultureInfo.InvariantCulture);
                    break;
                case "/":
                    result.Text = (double.Parse(result.Text, CultureInfo.InvariantCulture) / value).ToString(CultureInfo.InvariantCulture);
                    break;
                case "*":
                    result.Text = (double.Parse(result.Text, CultureInfo.InvariantCulture) * value).ToString(CultureInfo.InvariantCulture);
                    break;
                case "-":
                    result.Text = (double.Parse(result.Text, CultureInfo.InvariantCulture) - value).ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    break;
            }
            value = double.Parse(result.Text, CultureInfo.InvariantCulture);
            operationPressed = false;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            operation = "";
            operationPressed = false;
            equation.Text = " ";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonEqual.Focus();

            switch(e.KeyChar.ToString())
            {
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    buttonPlus.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "/":
                    buttonDivide.PerformClick();
                    break;
                case "*":
                    buttonMult.PerformClick();
                    break;
                case "=":
                    buttonEqual.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
