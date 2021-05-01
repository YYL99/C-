using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            listBox1.Items.Add(str);
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            listBox1.Items.Remove(str);
        }
    }
}
