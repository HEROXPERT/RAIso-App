using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class Customer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/CustomerHomePage.aspx");
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/CartPage.aspx");
        }

        protected void transactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/TransactionPage.aspx");
        }

        protected void updateprofileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/UpdateProfilePage.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            
            Session.Remove("user");
            Response.Redirect("~/Views/Guest/Login.aspx");
        }
    }
}