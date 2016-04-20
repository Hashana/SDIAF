<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="CoffeeShop.Purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Purchase Details?</h2>
    <br/>
    <asp:Label ID="lblTest" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
     <asp:Label ID="lblPostcode" runat="server" Text="Postcode"></asp:Label>
    <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
     <asp:Label ID="lblHouseNumber" runat="server" Text="House Number"></asp:Label>
    <asp:TextBox ID="txtHouseNum" runat="server"></asp:TextBox>

    <asp:Button ID="btnLookUpAddress" runat="server" Text="Find Address" OnClick="btnLookUpAddress_Click" />
    <br/>
    <br/>
     <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>

</asp:Content>
