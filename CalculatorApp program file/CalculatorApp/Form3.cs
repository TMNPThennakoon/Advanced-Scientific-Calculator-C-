using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form3 : Form
    {
        private string[] units = { "Inch", "Centimeters", "Feet", "Meter", "Kilometers" };

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); // Prevent repeated items
            comboBox2.Items.AddRange(units);
            comboBox2.SelectedIndex = 0;

            UpdateToUnits(); // Populate comboBox3 based on selected "From"
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateToUnits();
        }

        private void UpdateToUnits()
        {
            string selectedFrom = comboBox2.SelectedItem?.ToString();

            comboBox3.Items.Clear();
            foreach (string unit in units)
            {
                if (unit != selectedFrom)
                    comboBox3.Items.Add(unit);
            }

            if (comboBox3.Items.Count > 0)
                comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = double.Parse(textBox1.Text);

                string fromUnit = comboBox2.SelectedItem?.ToString();
                string toUnit = comboBox3.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(fromUnit) || string.IsNullOrEmpty(toUnit))
                {
                    MessageBox.Show("Please select both units.", "Unit Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double inMeters = ConvertToMeters(inputValue, fromUnit);
                double result = ConvertFromMeters(inMeters, toUnit);

                label4.Text = result.ToString("0.###");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertToMeters(double value, string unit)
        {
            switch (unit)
            {
                case "Inch": return value * 0.0254;
                case "Centimeters": return value * 0.01;
                case "Feet": return value * 0.3048;
                case "Meter": return value;
                case "Kilometers": return value * 1000;
                default: throw new ArgumentException("Invalid unit");
            }
        }

        private double ConvertFromMeters(double value, string unit)
        {
            switch (unit)
            {
                case "Inch": return value / 0.0254;
                case "Centimeters": return value / 0.01;
                case "Feet": return value / 0.3048;
                case "Meter": return value;
                case "Kilometers": return value / 1000;
                default: throw new ArgumentException("Invalid unit");
            }
        }

        // Optional empty event handlers (if wired in the Designer)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
