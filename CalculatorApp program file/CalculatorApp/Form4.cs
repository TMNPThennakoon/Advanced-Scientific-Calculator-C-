using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void inputTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertedTemp_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // To Fahrenheit selected
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // To Celsius selected
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void convert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(inputTemp.Text);

                if (checkBox1.Checked)
                {
                    // Celsius to Fahrenheit
                    double fahrenheit = (input * 9 / 5) + 32;
                    convertedTemp.Text = $"{fahrenheit:0.##} °F";
                }
                else if (checkBox2.Checked)
                {
                    // Fahrenheit to Celsius
                    double celsius = (input - 32) * 5 / 9;
                    convertedTemp.Text = $"{celsius:0.##} °C";
                }
                else
                {
                    MessageBox.Show("Please select a conversion type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric temperature.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
