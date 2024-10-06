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
    public partial class AddtoCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {         
            int userid = Convert.ToInt32(Request.QueryString["userid"]);
            int statid = Convert.ToInt32(Request.QueryString["statid"]);
            int quantity = Convert.ToInt32(quantityTb.Text.Trim());
            String add = CartController.addCart(userid, statid, quantity);
            if(add != null)
            {
                remindquantLbl.Text = add;
            }
            else
            {
                Response.Redirect($"~/Views/Customer/StationeryDetailPage.aspx?userid={userid}&statid={statid}");
            }
        }
    }
}