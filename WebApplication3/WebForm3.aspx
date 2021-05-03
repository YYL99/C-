<%@ Page Language="C#" %>
<html>
    <head>
        <title>使用控制示例</title>
    </head>
<body>
    <form id="Form1" method="post" runat="server">
        HTML输入框：<input type="text" value="abc" runat="server" id="TextBox_Html" /><br />
        HTML按钮：<input type="button" value="OK" runat="server" id="Button_Html" /><br />
        Web输入框：<asp:TextBox ID="TextBox_Web" runat="Server">abc</asp:TextBox><br />
        Web按钮：<asp:Button ID="Button_Web" runat="Server" Text="OK"></asp:Button><br />
        <%--代表注释--%>
    </form>
</body>
</html>
