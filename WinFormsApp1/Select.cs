using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnA.Checked)
            {
                lblHelp.Text = "你选择了A选项";
            }
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnB.Checked)
            {
                lblHelp.Text = "你选择了B选项";
            }
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnC.Checked)
            {
                lblHelp.Text = "你选择了C选项";
            }
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnD.Checked)
            {
                lblHelp.Text = "你选择了D选项";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnA.Checked)
            {
                MessageBox.Show("恭喜你答对了！");
                this.Close();
            }
            else
            {
                MessageBox.Show("回答错误,正确答案A。");
            }
        }
    }
}
