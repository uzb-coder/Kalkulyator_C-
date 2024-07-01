﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULYATOR
{
    public partial class Form1 : Form
    {

        int value1;
        int value2;
        double result = 0;
        string sign;
        int daraja;
        float ildiz;
        float x;
        float foiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "÷";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            daraja = Convert.ToInt32(textBox1.Text);
            sign = " Sqr =";
            label1.Text = textBox1.Text + sign;
            result = Math.Pow(daraja, 2);
            label2.Text = Convert.ToString(result);
            textBox1.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            daraja = Convert.ToInt32(textBox1.Text);
            sign = " Ildizi =";
            label1.Text = textBox1.Text + sign;
            result = Math.Sqrt(daraja);
            label2.Text = Convert.ToString(result);
            textBox1.Text = "";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = 1 / x;
            label2.Text = Convert.ToString(result);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            foiz = Convert.ToInt32(textBox1.Text);
            result = foiz / 100;
            label2.Text= Convert.ToString(result);
            label1.Text = "";
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text;
            if (sign == "+")
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "÷")
            {
                result = value1 / value2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

    }
}
