using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                Image1.ImageUrl = "./Image/男.jpg";
            }
            else
            {
                Image1.ImageUrl = "./Image/女.jpg";
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                Image1.ImageUrl = "./Image/女.jpg";
            }
            else
            {
                Image1.ImageUrl = "./Image/男.jpg";
            }
        }
    }
}