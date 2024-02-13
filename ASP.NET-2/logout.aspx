<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="ASP.NET_2.logout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
    </head>
    <body>
        <asp:Button id="ButtonLogout" runat="server" Text="Logout" OnClick="ButtonLogout_Click" />
        <p id="userData" runat="server"></p>
        
    </body>
    </html>
</asp:Content>
