<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CoffeeShop.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>How to contact us:</h3>
    <address>
        CoffeeCo<br />
        Barbers Road<br />
        London, <br />
        E15 2PE <br />
        <abbr title="Phone">Phone:</abbr>
        0207 645 981
    </address>

    <address>
      <strong>Support:</strong>   <a href="mailto:SDIAF1516@gmail.com">SDIAF1516@gmail.com</a><br />
       <%-- <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>--%>
    </address>
    <script src="http://maps.googleapis.com/maps/api/js"></script>
    <div id="googleMap" style="width:100%;height:500px;"><script type="text/javascript">  
        var map;

        var position = { lat: 51.5335598, lng: -0.0146764 };

        var map = new google.maps.Map(document.getElementById('googleMap'), {
            zoom: 15,
            center: position
        });

        var marker = new google.maps.Marker({
            position: position,
            map: map,
            animation:google.maps.Animation.BOUNCE,
            title: 'Our Base!'
        });

       
  
    </script>  </div>
   </asp:Content>
