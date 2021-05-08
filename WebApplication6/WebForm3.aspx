<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication6.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图片</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Text="男" GroupName="Group1" OnCheckedChanged="RadioButton1_CheckedChanged" />
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" Text="女" GroupName="Group1" OnCheckedChanged="RadioButton2_CheckedChanged" />
        </div>
        <div>

            <asp:Image ID="Image1" runat="server" AlternateText="选择性别" />

        </div>
    </form>
</body>
</html>
