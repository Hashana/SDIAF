using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Maps.Geocoding;

namespace CoffeeShop
{
    public partial class Purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string s;
        private string _address = "";

        public Purchase()
        {
          //  s = Request.QueryString["field1"];
        }

        protected void btnLookUpAddress_Click(object sender, EventArgs e)
        {
            // Find address
            var request = new GeocodingRequest();
            request.Address = txtPostcode.Text;
            // not sure what this is but it needs to be false
            request.Sensor = false;
            var response = new GeocodingService().GetResponse(request);
            var result = response.Results.First();
            // MessageBox.Show("Address = " + result.FormattedAddress, "address", MessageBoxButtons.OK);
            // lblAddress.Text = "Address:"+ txtHouseNum.Text + " " + result.FormattedAddress;
            //lblAddress.Text = "Address: " + txtHouseNum.Text + " " + result.AddressComponents.ElementAtOrDefault(0) + "\n" + result.AddressComponents.ElementAtOrDefault(1) + "\n" + result.AddressComponents.ElementAtOrDefault(2) + "\n" + result.AddressComponents.ElementAtOrDefault(3) + "\n" + result.AddressComponents.ElementAtOrDefault(4) + "\n" + result.AddressComponents.ElementAtOrDefault(5) + "\n" + result.AddressComponents.ElementAtOrDefault(6);
            lblAddress.Text = "Address: " + "<br/>" + txtHouseNum.Text + " " + result.AddressComponents.ElementAt(1).LongName + "<br/>" + result.AddressComponents.ElementAt(2).LongName + "<br/>" + result.AddressComponents.ElementAt(3).LongName + "<br/>" + result.AddressComponents.ElementAt(4).LongName + "<br/>" + result.AddressComponents.ElementAt(0).LongName + "<br/>" + result.AddressComponents.ElementAt(5).ShortName;
            _address = txtHouseNum.Text + "," + result.FormattedAddress;
        }
    }
}