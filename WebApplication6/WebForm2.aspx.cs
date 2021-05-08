using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Show()
        {
            string result = "你选择的爱好有：";
            if (CheckBox1.Checked == true) result += CheckBox1.Text.ToString();
            if (CheckBox2.Checked == true) result += CheckBox2.Text.ToString();
            if (CheckBox3.Checked == true) result += CheckBox3.Text.ToString();
            if (CheckBox4.Checked == true) result += CheckBox4.Text.ToString();
            if (CheckBox5.Checked == true) result += CheckBox5.Text.ToString();
            if (CheckBox6.Checked == true) result += CheckBox6.Text.ToString();
            Response.Write(result);

            Label1.Text = "你选择的爱好有：";
            if (CheckBox1.Checked == true) Label1.Text += CheckBox1.Text.ToString();
            if (CheckBox2.Checked == true) Label1.Text += CheckBox2.Text.ToString();
            if (CheckBox3.Checked == true) Label1.Text += CheckBox3.Text.ToString();
            if (CheckBox4.Checked == true) Label1.Text += CheckBox4.Text.ToString();
            if (CheckBox5.Checked == true) Label1.Text += CheckBox5.Text.ToString();
            if (CheckBox6.Checked == true) Label1.Text += CheckBox6.Text.ToString();

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            Show();

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }
    }
}