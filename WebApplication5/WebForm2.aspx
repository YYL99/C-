<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="链接按钮控件LinkButton"></asp:Label>
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Group1" Text="男" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="False"></asp:RadioButton>
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Group1" Text="女" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="False"></asp:RadioButton>
    <%--必须拥有OnCheckedChanged属性，即控件被选中时的状态 --%>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnCommand="LinkButton1_Command">购物>></asp:LinkButton>
</asp:Content>
