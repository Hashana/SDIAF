<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestEmail.aspx.cs" Inherits="CoffeeShop.Account.RequestEmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Request Email.</h2>
     <br/>
    <p>Please leave your email address and we will notify you when this coffee becomes available again.</p><br/>
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label><asp:TextBox ID="txtLowStockEmailRequest" runat="server" input type ="email" required></asp:TextBox>
   

    <asp:Button ID="btnEmailRequest" runat="server" Text="Request Notification" OnClick="btnEmailRequest_Click" />
   

</asp:Content>
