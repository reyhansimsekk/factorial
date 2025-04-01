using System;
using System.Windows.Forms;

namespace FactorialApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative number.");
                    return;
                }

                long result = CalculateFactorial(number);
                lblResult.Text = $"Factorial of {number} is {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
