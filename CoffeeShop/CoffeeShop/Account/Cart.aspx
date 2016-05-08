<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="CoffeeShop.Account.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shopping Cart</h2>
    <asp:Label ID="lblCart" runat="server"></asp:Label>
    <asp:Label ID="lblSubTotal" runat="server"></asp:Label>
    <asp:Label ID="lblProceedToPayment" runat="server"></asp:Label>
    <script   src="https://code.jquery.com/jquery-2.2.3.js"   integrity="sha256-laXWtGydpwqJ8JA+X9x2miwmaiKhn8tVmOVEigRNtP4="   crossorigin="anonymous"></script>
    <script>
        $('input[type=number]').change(function () {
            var form = $(this).closest('form');
            var max = $(this).closest('td').prev('td').html();

            if ($(this).val() > max) {
                alert($(this).val());        
                alert(max);
                alert("Sorry, we don't have that many");
                form.submit();
            } else {
                var action = form.attr('action');
                var array = action.split("=");
                var newAction = array[0] + "=" + array[1] + "=" + array[2] + "=" + array[3] + "=" + $(this).val();
                form.attr('action', newAction);
                form.submit();
            }
        });
    </script>
</asp:Content>
