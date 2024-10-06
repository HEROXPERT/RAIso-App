using RAIso_BARUUU.Handler;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class StationeryDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int statid = Convert.ToInt32(Request.QueryString["statid"]);
            MsStationery stat = StationeryHandler.getStationerybyId(statid);
            actualstatnameLbl.Text = stat.StationeryName;
            actualpriceLbl.Text = stat.StationeryPrice.ToString();
        }

        protected void addcartBtn_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Request.QueryString["userid"]);
            int statid = Convert.ToInt32(Request.QueryString["statid"]);
            Response.Redirect($"~/Views/Customer/AddtoCartPage.aspx?userid={userid}&statid={statid}");
        }
    }
}