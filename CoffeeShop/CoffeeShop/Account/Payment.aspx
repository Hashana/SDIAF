<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="CoffeeShop.Account.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Payment Details</h2>
    <br/>
    
    <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
    <asp:TextBox ID="txtEmailPurchase" runat="server" input type ="email" required></asp:TextBox>
    <br/>
    <br/>
     <asp:Label ID="lblBillingPcode" runat="server" Text="Postcode"></asp:Label>
    <asp:TextBox ID="txtBillingPostcode" runat="server" required></asp:TextBox>
     <asp:Label ID="lblBillingHouseNumber" runat="server" Text="House Number"></asp:Label>
    <asp:TextBox ID="txtBillingHouseNum" runat="server" required></asp:TextBox>

     <asp:Button ID="btnFindBillingAddress" runat="server" OnClick="btnFindBillingAddress_Click" Text="Find Address" />
     <br />
     <asp:Label ID="lblBillingAddress" runat="server"></asp:Label>
     <br />
     <br />
     <asp:TextBox ID="txtCardNum" runat="server"></asp:TextBox>
     <asp:Label ID="Label1" runat="server" Text="Card Number"></asp:Label>
     <br />
     <br />
     <asp:TextBox ID="txtNameOnCard" runat="server"></asp:TextBox>
     <asp:Label ID="Label2" runat="server" Text="Name on Card"></asp:Label>
     <br />
     <br />
     <asp:TextBox ID="txtSecCode" runat="server"></asp:TextBox>
     <asp:Label ID="Label3" runat="server" Text="Security Code"></asp:Label>
     <br />
     <br />
     <asp:Label ID="lblAmount" runat="server"></asp:Label>
     <br />
     <br />
     <asp:Button ID="txtPlaceOrder" runat="server" OnClick="txtPlaceOrder_Click" Text="Make Payment" />

</asp:Content>
