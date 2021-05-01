using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(txtAdd1.Text.Trim());
                int num2 = Int32.Parse(txtAdd2.Text.Trim());
                txtSum.Text = (num1 + num2).ToString();
            }
            catch (Exception ex)
            {
                txtHelp.Text = "出现错误:" + ex.Message;
            }
            finally
            {
                txtHelp.Text = "正常运行";
            }
        }
    }
}
