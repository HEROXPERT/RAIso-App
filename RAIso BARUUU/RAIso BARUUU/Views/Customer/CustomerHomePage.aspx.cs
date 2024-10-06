using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                MsUser user;
                if (Session["user"] == null)
                {
                    var username = Request.Cookies["user_cookie"].Value;
                    user = UserController.getUserbyusername(username);
                    Session["user"] = user;
                }
                else
                {
                    user = (MsUser)Session["user"];
                }

                List<MsStationery> stationeries = StationeryController.getStationery();
                StationeryGV.DataSource = stationeries;
                StationeryGV.DataBind();
            }
        }

        protected void StationeryGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                MsUser currentUser = (MsUser)Session["user"];
                int userid = currentUser.UserID;
                int statid = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"~/Views/Customer/StationeryDetailPage.aspx?userid={userid}&statid={statid}");
            }
        }
    }
}