<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="CoffeeShop.Purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shipping Details</h2>
    <br/>

    <br/>
    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" required></asp:TextBox>
    <asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
    <asp:TextBox ID="txtSurname" runat="server" required></asp:TextBox>

    <br/>
    <br/>
    <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>
    <asp:TextBox ID="txtPostcode" runat="server" required></asp:TextBox>
     <asp:Label ID="lblHouseNumber" runat="server" Text="House Number"></asp:Label>
    <asp:TextBox ID="txtHouseNum" runat="server" required></asp:TextBox>

    <asp:Button ID="btnLookUpAddress" runat="server" Text="Find Address" OnClick="btnLookUpAddress_Click" />
    <br/>
    <br/>
     <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>


    <br />


    <br />
    


    <br />
    <br />
    <asp:Button ID="btnPaymentDetails" runat="server" OnClick="btnPaymentDetails_Click" Text="Next" />


</asp:Content>
