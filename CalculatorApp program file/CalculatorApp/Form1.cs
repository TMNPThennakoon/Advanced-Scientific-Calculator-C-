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
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || isOperationPerformed)
                tbDisplayResult.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void button17_Click(object sender, EventArgs e) // C
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            lbCurrentOp.Text = "";
        }

        private void button18_Click(object sender, EventArgs e) // CE
        {
            tbDisplayResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e) // =
        {
            double secondValue;
            if (!double.TryParse(tbDisplayResult.Text, out secondValue))
            {
                tbDisplayResult.Text = "Error";
                return;
            }

            double result = 0;

            switch (operationPerformed)
            {
                case "+":
                    result = resultValue + secondValue;
                    break;
                case "-":
                    result = resultValue - secondValue;
                    break;
                case "X":
                    result = resultValue * secondValue;
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        tbDisplayResult.Text = "Divide by 0!";
                        return;
                    }
                    result = resultValue / secondValue;
                    break;
                case "^":
                    result = Math.Pow(resultValue, secondValue);
                    break;
                default:
                    tbDisplayResult.Text = "Unknown op";
                    return;
            }

            // Display the full expression and result
            tbDisplayResult.Text = $"{resultValue} {operationPerformed} {secondValue} = {result}";
            lbCurrentOp.Text = "";

            // Reset state
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = true;
        }

        private void button16_Click(object sender, EventArgs e) // backspace
        {
            if (tbDisplayResult.Text.Length > 0)
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);

            if (tbDisplayResult.Text == "")
                tbDisplayResult.Text = "0";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                double result = Math.Sin(val * Math.PI / 180);
                tbDisplayResult.Text = result.ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                double result = Math.Cos(val * Math.PI / 180);
                tbDisplayResult.Text = result.ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                double result = Math.Tan(val * Math.PI / 180);
                tbDisplayResult.Text = result.ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void precentge_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = (val / 100).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = Math.Sqrt(val).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void ln_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = Math.Log(val).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = Math.Log10(val).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
            try
            {
                resultValue = double.Parse(tbDisplayResult.Text);
                operationPerformed = "^";
                isOperationPerformed = true;
                lbCurrentOp.Text = resultValue + " ^";
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = (1 / val).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(tbDisplayResult.Text);
                long fact = 1;
                for (int i = 1; i <= val; i++)
                {
                    fact *= i;
                }
                tbDisplayResult.Text = fact.ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = (-val).ToString();
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(tbDisplayResult.Text);
                tbDisplayResult.Text = Math.Exp(val).ToString(); // e^x
            }
            catch
            {
                tbDisplayResult.Text = "Error";
            }
        }

        private void unitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Form3)
                {
                    openForm.BringToFront();
                    return;
                }
            }

            Form3 unitConverter = new Form3();
            unitConverter.StartPosition = FormStartPosition.CenterScreen;
            unitConverter.Show();
        }

        private void temperatureConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tempConverter = new Form4();
            tempConverter.Show();
        }
    }
}
