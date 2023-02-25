using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;


        public CalculatorForm()
        {
            InitializeComponent();
            MaxDisplayLength();
        }

        #region Buttonns 7-8-9

        private void button7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "7";
            calculatorDisplay.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "8";
            calculatorDisplay.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "9";
            calculatorDisplay.Text += input;
        }

        #endregion

        #region Buttons 4-5-6

        private void button4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "4";
            calculatorDisplay.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "5";
            calculatorDisplay.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "6";
            calculatorDisplay.Text += input;
        }

        #endregion

        #region Buttons 1-2-3-0

        private void button3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "3";
            calculatorDisplay.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "2";
            calculatorDisplay.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "1";
            calculatorDisplay.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += "0";
            calculatorDisplay.Text += input;
        }

        #endregion

        #region MaxDisplayLengthMethod FIX ME!

        public void MaxDisplayLength()
        {
            //Doesn't work
            if (calculatorDisplay.Text.Length >= 10)
            {
                MessageBox.Show("Error no more than 10 digits please.", "Error", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region OperationButtons

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }

        #endregion

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            //Clear for next calculation after hitting equal
            this.calculatorDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;


            if (operation == '+')
            {
                result = num1 + num2;
                calculatorDisplay.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                calculatorDisplay.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                calculatorDisplay.Text = result.ToString();
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                {
                    result = num1 % num2;
                    calculatorDisplay.Text = result.ToString() + "R";
                }
                else
                {
                    calculatorDisplay.Text = "ERROR";
                }
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    calculatorDisplay.Text = result.ToString();
                }
                else
                {
                    calculatorDisplay.Text = "DIV/ZERO!";
                }
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += '.';
            calculatorDisplay.Text += input;
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            var neg = Convert.ToInt32(calculatorDisplay.Text);
            var negative = neg * -1;
            input = negative.ToString();
            calculatorDisplay.Text = input;
        }
    }
}