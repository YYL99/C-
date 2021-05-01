using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datefrom = DateTime.Parse(dateTimePicker1.Text);
            DateTime dateto = DateTime.Parse(dateTimePicker2.Text);
            if (datefrom <= DateTime.Now)
            {
                MessageBox.Show("日期不能小于当天");
                return;
            }
            if (datefrom > dateto)
            {
                MessageBox.Show("开始日期不能大于结束日期");
                return;
            }
            MessageBox.Show("正确");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
