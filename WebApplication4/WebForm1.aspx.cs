using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Command (object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ShowNumbers_Asc":
                    Page.Response.Write("您单击了按钮“递增显示数字”!<br>");
                    ShowNumbers(e.CommandArgument);
                    break;
                case "ShowNumbers_Desc":
                    Page.Response.Write("您单击了按钮“递减显示数字”!<br>");
                    ShowNumbers(e.CommandArgument);
                    break;
                case "ShowLetters_Asc":
                    Page.Response.Write("您单击了按钮“递增显示字母”!<br>");
                    ShowLetters(e.CommandArgument);
                    break;
                case "ShowLetters_Desc":
                    Page.Response.Write("您单击了按钮“递减显示字母”!<br>");
                    ShowLetters(e.CommandArgument);
                    break;
                default:
                    break;
            }
        }

        private void ShowNumbers(object commandArgument)
        {
            Page.Response.Write("触发了方法ShowNumbers(" + commandArgument.ToString() + ")<br>");
            if (commandArgument.ToString() == "Asc")
            {
                Page.Response.Write("1 2 3 4 5");
            }else if (commandArgument.ToString() == "Desc")
            {
                Page.Response.Write("5 4 3 2 1");
            }
        }

        private void ShowLetters(object commandArgument)
        {
            Page.Response.Write("触发了方法ShowLetters(" + commandArgument.ToString() + ")<br>");
            if (commandArgument.ToString() == "Asc")
            {
                Page.Response.Write("a b c d e");
            }
            else if (commandArgument.ToString() == "Desc")
            {
                Page.Response.Write("e d c b a");
            }
        }
    }
}