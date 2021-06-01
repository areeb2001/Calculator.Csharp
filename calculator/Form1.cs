using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal number1, number2, results;
        int operatorr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Remover("7");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Remover("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Remover("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remover("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Remover("5");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Remover("6");
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == string.Empty || textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Please Enter any value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            number1 = Convert.ToDecimal(textBox1.Text);
            operatorr = 3;
            textBox1.Text = "";
            info.Text = "Enter Second number";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()==string.Empty || textBox1.Text.Trim()=="0")
            {
                MessageBox.Show("Please Enter any value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            number1 = Convert.ToDecimal(textBox1.Text);
            operatorr = 1;
            textBox1.Text = "";
            info.Text = "Enter Second number";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Remover("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Remover("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Remover("1");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Remover("0");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".";
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == string.Empty || textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Please Enter any value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            number1 = Convert.ToDecimal(textBox1.Text);
            operatorr = 2;
            textBox1.Text = "";
            info.Text = "Enter Second number";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == string.Empty || textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Please Enter any value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            number1 = Convert.ToDecimal(textBox1.Text);
            operatorr = 4;
            textBox1.Text = "";
            info.Text = "Enter Second number";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = 0.0m;
            number2 = 0.0m;
            operatorr = 0;
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || textBox1.Text.Trim() == "0")
            {
                MessageBox.Show("Please Enter any value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            number2 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            Result();
        }

        private void Remover(string number)
        {
            if (info.Text.Trim() != string.Empty )
            {
                info.Text = string.Empty;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text += number;
            }
        }
        public void Result()
        {
            switch (operatorr)
            {
                case 1:
                    results = number1 + number2;
                    break;
                case 2:
                    results = number1 - number2;
                    break;
                case 3:
                    results = number1 * number2;
                    break;
                        case 4:
                    results = number1 / number2;
                    break;
                default:
                    break;
            }
            textBox1.Text = decimal.Round(results, 2).ToString();

        }
    }
}
