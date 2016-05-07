using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Google.Maps.Geocoding;

namespace CoffeeShop
{
    public partial class Purchase : System.Web.UI.Page
    {
        private string _name;
        private string Name;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            _name = Request.QueryString["name"];
       }

        private string s;
        private string _address = "";

     

        protected void btnLookUpAddress_Click(object sender, EventArgs e)
        {
            // Find address
            var request = new GeocodingRequest();
            request.Address = txtPostcode.Text;
            // not sure what this is but it needs to be false
            request.Sensor = false;
            var response = new GeocodingService().GetResponse(request);
            var result = response.Results.First();
            lblAddress.Text = "Address: " + "<br/>" + txtHouseNum.Text + " " + result.AddressComponents.ElementAt(1).LongName + "<br/>" + result.AddressComponents.ElementAt(2).LongName + "<br/>" + result.AddressComponents.ElementAt(3).LongName + "<br/>" + result.AddressComponents.ElementAt(4).LongName + "<br/>" + result.AddressComponents.ElementAt(0).LongName + "<br/>" + result.AddressComponents.ElementAt(5).ShortName;
            _address = txtHouseNum.Text + "," + result.FormattedAddress;
        }
    }
}