using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Guest
{
    public partial class Guest : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/HomePage.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/Register.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/Login.aspx");
        }
    }
}