using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1labelModelabelMode : Form
    {
        public Form1labelModelabelMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] inputNumbers = textBox1.Text.Split(' ');

            // Convert the input numbers to a list of doubles
            List<double> numbers = new List<double>();
            foreach (string input in inputNumbers)
            {
                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                }
            }

            // Calculate median, mode, and average
            double mode = CalculateMode(numbers);
            double average = numbers.Average();
            labelMode.Text = $"Mode: {mode}";
            labelAverage.Text = $"Average: {average}";
        }
        private double CalculateMode(List<double> numbers)
        {
            var mode = numbers.GroupBy(x => x)
                 .OrderByDescending(x => x.Count()).ThenBy(x => x.Key)
                 .Select(x => (int)x.Key)
                 .FirstOrDefault();

            return mode;
        }
    }
}
