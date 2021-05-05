using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hello World, ASP.NET!";
            Response.Write("用户操作的控件名为：" + 
                ((System.Web.UI.WebControls.WebControl)sender).ID.ToString() + "<br>");
            Response.Write("用户操作的参数为：" + e.ToString() + "<br>");
        }
    }
}