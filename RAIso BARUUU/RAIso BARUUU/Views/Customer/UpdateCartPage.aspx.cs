using RAIso_BARUUU.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class UpdateCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int newquantity = Convert.ToInt32(newquantitytb.Text);
            int userid = Convert.ToInt32(Request.QueryString["userid"]);
            int statid = Convert.ToInt32(Request.QueryString["statid"]);
            String update = CartController.UpdateCart(userid, statid, newquantity);
            if(update != null)
            {
                errorLbl.Text = update;
            }
            else
            {
                Response.Redirect("~/Views/Customer/CartPage.aspx");
            }
        }
    }
}