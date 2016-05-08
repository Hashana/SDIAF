<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Coffee.aspx.cs" Inherits="CoffeeShop.Coffee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Coffee.</h2>
     <asp:TextBox ID="txtQSearch" runat="server"></asp:TextBox>
    <asp:Button ID="btnQSearch" runat="server"  Text="Quick Search" OnClick="btnQSearch_Click" />
    <asp:Button ID="btnClearResults" runat="server" Text="Clear Search Results" OnClick="btnClearResults_Click" />
    <br/>
    <br/>
     <asp:Label ID="lblStrength" runat="server" Text="Strength"></asp:Label>
    <asp:DropDownList ID="ddlStrength" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStrength_SelectedIndexChanged">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Light to Medium Roast</asp:ListItem>
        <asp:ListItem>Medium Roast</asp:ListItem>
        <asp:ListItem>Medium to Dark Roast</asp:ListItem>
        <asp:ListItem>Dark Roast </asp:ListItem>
        <asp:ListItem>Very Dark Roast</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="lblGrind" runat="server" Text="Grind"></asp:Label>
    <asp:DropDownList ID="ddlGrind" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlGrind_SelectedIndexChanged" OnTextChanged="ddlGrind_SelectedIndexChanged" >
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Extra Coarse Grind</asp:ListItem>
        <asp:ListItem>Coarse Grind</asp:ListItem>
        <asp:ListItem>Medium Grind</asp:ListItem>
        <asp:ListItem>Fine Grind</asp:ListItem>
        <asp:ListItem>Extra Fine Grind</asp:ListItem>
    </asp:DropDownList>
   <asp:Label ID="lblOrigin" runat="server" Text="Origin"></asp:Label>
    <asp:DropDownList ID="ddlOrigin" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrigin_SelectedIndexChanged"/>
    <br/>
       <asp:Label ID="lblCoffee" runat="server" Text="L"></asp:Label>
</asp:Content>
