using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0;
        double b = 0;
        bool c = false;
        string d;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        { 
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "1";
                c = false;
            }
        }

        private void Number2_Click(object sender, EventArgs e)
        {

            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "2";
                c = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "3";
                c = false;
            }
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "4";
                c = false;
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "5";
                c = false;
            }
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "6";
                c = false;
            }
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "7";
                c = false;
            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "8";
                c = false;
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "9";
                c = false;
            }
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if ((d == "+") || (d == "-") || (d == "*") || (d == "/"))
            {
                textBox1.Clear();
            }
            if (c != true)
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += "0";
                c = false;
            }
            if (d == "/")
            {
                textBox1.Clear();
                MessageBox.Show("被除数不能为0!");
            }
        }

        private void SPOT_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text += "";
                c = false;
            }
            textBox1.Text += ".";
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            textBox1.Clear();
            d = "+";
            textBox1.Text = d;
        }

        private void RED_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            textBox1.Clear();
            d = "-";
            textBox1.Text = d;
        }

        private void MUL_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            textBox1.Clear();
            d = "*";
            textBox1.Text = d;
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            textBox1.Clear();
            d = "/";
            textBox1.Text = d;
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case "+":
                    a = b + double.Parse(textBox1.Text);
                    textBox1.Text = a + "";
                    break;
                case "-":
                    a = b - double.Parse(textBox1.Text);
                    textBox1.Text = a + "";
                    break;
                case "*":
                    a = b * double.Parse(textBox1.Text);
                    textBox1.Text = a + "";
                    break;
                case "/":
                    a = b / double.Parse(textBox1.Text);
                    textBox1.Text = a + "";
                    break;
                case "=":
                    textBox1.Clear();
                    break;
            }
            c = true;
            d = "=";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string newtext = text.Remove(text.Length - 1, 1);
            textBox1.Text = newtext;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //鼠标后退一位
        }
    }
}
