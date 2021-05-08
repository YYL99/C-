<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="你选择的爱好有："></asp:Label>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="游泳" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="篮球" />
            <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="旅游" />
            <asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" Text="足球" />
            <asp:CheckBox ID="CheckBox5" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged" Text="阅读" />
            <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" Text="电影" />
        </div>
    </form>
</body>
</html>
