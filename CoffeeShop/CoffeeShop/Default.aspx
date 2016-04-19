<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CoffeeShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CoffeeCo</h1>  
    <div id="slideshow">
    <img src="images/loveBeans.jpg" alt="" />
    <img src="images/3Cups.jpg" alt="" />
    <img src="images/coffeeText.jpg" alt="" />
    </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Coffee of the Month</h2>
            <p>
               For May we have selected our  ... range as coffee of the month. 
                ....ADD IMAGE AND EXPLANATION
          </p>
        </div>
        <div class="col-md-4">
             <h2>Awards</h2>
            <p>
                As an international coffee supplier we have been presented with awards for our coffee all over the world. <br/>
                    <img src="images/ukBrewersCup.jpg" alt="" style="width: 150px; height: 100px;" />
                    <img src="images/ausAward.png" alt="" style="width: 150px; height: 100px;" />
                <br/><img src="images/brewersCup.png" alt="" style="width: 100px; height: 100px;" />
                <img src="images/goldenCup.jpg" alt="" style="width: 100px; height: 100px;" />
                    <img src="images/bestBrew.jpg" alt="" style="width: 100px; height: 100px;" />
            
        </div>
        <div class="col-md-4">
            <h2>Coming soon!</h2>
            <p>
                Be sure to be on the look out for our new mobile app. To be launched in June, you will soon be able to access all your favourite coffees via Android and iOS!
               <img src="images/android.jpg" alt="" style="width: 100px; height: 100px;" />
               <img src="images/ios.jpg" alt="" style="width: 150px; height: 100px;" />
              </p>
           

        <%--        You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>--%>
            </p>
        </div>
    </div>

</asp:Content>
