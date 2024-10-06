using RAIso_BARUUU.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Admin
{
    public partial class InsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            int price = Convert.ToInt32(priceTb.Text);
            String insert = StationeryController.Insert(name, price);
            if(insert != null)
            {
                errorLbl.Text = insert;
            }
            else
            {
                Response.Redirect("~/Views/Admin/AdminHomePage.aspx");
            }
        }
    }
}