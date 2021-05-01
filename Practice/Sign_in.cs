using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtName.Text.Trim() == "admin") && (txtPawssed.Text.Trim() == "123"))
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败，账号或密码不正确！");
            }
        }
    }
}
