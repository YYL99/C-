﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                Page.Response.Redirect("WebForm3.aspx");
            }
            else
            {
                Page.Response.Redirect("WebForm4.aspx");
            }
        }
    }
}