using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Guest
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsStationery> stationeries = StationeryController.getStationery();
            StationeryGV.DataSource = stationeries;
            StationeryGV.DataBind();
        }
    }
}