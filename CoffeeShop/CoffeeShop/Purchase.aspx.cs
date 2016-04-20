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
            lblAddress.Text = "Address:"+ txtHouseNum.Text  + result.FormattedAddress;
            _address = txtHouseNum.Text + "," + result.FormattedAddress;;
        }
    }
}