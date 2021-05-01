using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 注册新用户 : Form
    {
        public 注册新用户()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtHelp.Text = "请输入您的姓名！";
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名为空，请重新输入！");    //提示框
                txtName.Focus();    //设置焦点
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtHelp.Text= "请输入您的密码！";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码为空，请重新输入！");
                txtPassword.Focus();
            }
        }

        private void txtAgain_Enter(object sender, EventArgs e)
        {
            txtHelp.Text = "请再次输入您的密码！！";
        }

        private void txtAgain_Validating(object sender, CancelEventArgs e)
        {
            if ((txtPassword.Text.Trim() != string.Empty) && (txtAgain.Text.Trim() == string.Empty))
            {
                MessageBox.Show("密码为空，请重新输入！");
                txtAgain.Focus();
            }else if (txtAgain.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("密码输入有误，请重新输入！");
                txtPassword.Clear();    //清除密码
                txtAgain.Clear();       //清除确认密码
                txtAgain.Focus();
            }
        }

        private void txtGender_Enter(object sender, EventArgs e)
        {
            txtHelp.Text = "请您的性别！";
        }

        private void txtGender_Validating(object sender, CancelEventArgs e)
        {
            if ((txtGender.Text.Trim() != "男") && (txtGender.Text.Trim() != "女"))
            {
                MessageBox.Show("性别输入不正确，请重新输入！");
                txtGender.SelectAll();
                txtGender.Focus();
            }
        }

        private void txtTelephone_Enter(object sender, EventArgs e)
        {
            txtHelp.Text = "请输入电话号码！";
        }

        private void txtTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("电话号码输入不正确！");
                txtTelephone.Clear();
                txtTelephone.Focus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("用户名为空，请重新输入！");
                txtName.Focus();
            }else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码为空，请重新输入！");
                txtPassword.Focus();
            }else if (txtAgain.Text.Trim() == string.Empty)
            {
                MessageBox.Show("密码为空，请重新输入！");
                txtAgain.Focus();
            }else if (txtGender.Text.Trim() == string.Empty)
            {
                MessageBox.Show("性别为空，请重新输入！");
                txtGender.Focus();
            }else if (txtTelephone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("电话号码为空，请重新输入！");
                txtTelephone.Focus();
            }
            else
            {
                MessageBox.Show("正在注册……");
            }
        }
    }
}
