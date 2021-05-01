using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if(count < 13)
            {
                label1.Text = "你一共单击了" + count.ToString() + "次按钮";
            }
            else
            {
                label1.Text = "可不要再按了！！";
            }
            //利用随机数使得按钮点击之后改变位置。this.Width - btnClickMe.Width保证位于Form可见范围内
            //Random r = new Random();
            //btnClickMe.Left = r.Next(this.Width - btnClickMe.Width);
            //btnClickMe.Top = r.Next(this.Height - btnClickMe.Height);
        }
        private int count = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "点我毫无用处！哈哈哈";
        }
    }
}
