<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Group1" Text="男" 
        AutoPostBack="true" OnCheckedChanged="RadioButton1_CheckedChanged" ></asp:RadioButton>
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Group1" Text="女" 
        AutoPostBack="true" OnCheckedChanged="RadioButton2_CheckedChanged" ></asp:RadioButton>
</asp:Content>
