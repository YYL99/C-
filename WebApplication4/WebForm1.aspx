<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="递增显示数字" CommandName="Show Numbers_Asc" 
        CommandArgument="Asc" OnCommand="Button_Command" />
    <asp:Button ID="Button2" runat="server" Text="递减显示数字" CommandName="Show Numbers_Desc" 
        CommandArgument="Desc" OnCommand="Button_Command" />
    <asp:Button ID="Button3" runat="server" Text="递减显示字母" CommandName="Show Letters_Desc" 
        CommandArgument="Desc" OnCommand="Button_Command" />
    <asp:Button ID="Button4" runat="server" Text="递增显示字母" CommandName="Show Letters_Asc" 
        CommandArgument="Asc" OnCommand="Button_Command" />
</asp:Content>
