using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Maps;
using Google.Maps.Geocoding;
using Google.Maps.StaticMaps;

namespace CoffeeShop
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //PopulateMap();
        }



        //private void PopulateMap()
        //{
        //    CustomBrowser browser = new CustomBrowser();
        //    // Display Map
        //    var map = new StaticMapRequest();
        //    map.Center = new Location("E15 2PE");
        //    //  map.Size = new System.Drawing.Size(wbMap.Width, wbMap.Height);
        //    //  map.Zoom = zoom;
        //    map.Sensor = false;
        //    map.MapType = MapTypes.Roadmap;
        //    map.Markers.Add("E15 2PE");

        //    //  wbMap.Navigate(map.ToUri().ToString());

        //    browser.GetWebpage(map.ToUri().ToString());

        //}
    }
}


//}