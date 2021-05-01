using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Checkbox : Form
    {
        public Checkbox()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbA.Checked && cbD.Checked)
            {
                MessageBox.Show("回答正确！");
                this.Close();
            }
            else
            {
                MessageBox.Show("回答错误，正确答案AD。");
            }
        }
    }
}
