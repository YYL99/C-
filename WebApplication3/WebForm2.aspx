<%@ Page Language="C#" %>
<html>
    <head>
        <title>使用<Script>...</Script>示例</title>
        <script language="C#" runat="server">
            string func1(string day)
            {
                string plan = "";
                switch (day)
                {
                    case "Monday":
                        plan = "向客户提案!";
                        break;
                    case "Thuseday":
                        plan = "参加菲菲的生日!";
                        break;
                    case "Wednesday":
                        plan = "shopping!";
                        break;
                    case "Thursday":
                        plan = "去健身房!";
                        break;
                    case "Friday":
                        plan = "向老板汇报工作!";
                        break;
                    default :
                        plan = "周末狂欢!";
                        break;
                }
                return plan;
            }
        </script>
    </head>
    <body>
        <%
            string today = System.DateTime.Today.DayOfWeek.ToString();
            string output = func1(today);
            Response.Write("今天是" + today + ",我计划");
            Response.Write(output);
            %>
    </body>
</html>