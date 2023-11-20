using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = (float)(Convert.ToDouble(txtNum1.Text));
            float num2 = (float)(Convert.ToDouble(txtNum2.Text));

            if (cbOperator.Text == "+")
            {
                float total = BasicComputation.Addition(num1, num2);

                lblTotal.Text = total.ToString();
            }
            else if (cbOperator.Text == "-")
            {
                float total = BasicComputation.Subtraction(num1, num2);

                lblTotal.Text = total.ToString();
            }
            else if (cbOperator.Text == "*")
            {
                float total = BasicComputation.Multiplication(num1, num2);

                lblTotal.Text = total.ToString();
            }
            else if (cbOperator.Text == "/")
            {
                float total = BasicComputation.Division(num1, num2);

                lblTotal.Text = total.ToString();
            }
            else 
            {
                MessageBox.Show("Error");
            }
        }
    }
}
