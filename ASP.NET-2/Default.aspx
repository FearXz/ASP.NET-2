<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <input id="username" runat="server" type="text" />
        <input id="password" runat="server" type="text" />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </main>

</asp:Content>
