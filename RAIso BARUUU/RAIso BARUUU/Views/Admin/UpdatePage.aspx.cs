using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Admin
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsStationery stat = StationeryController.getStatbyId(id);
            nameTb.Text = stat.StationeryName;
            priceTb.Text = stat.StationeryPrice.ToString();
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            String name = nameTb.Text;
            int price = Convert.ToInt32(priceTb.Text);
            String update = StationeryController.Update(id, name, price);
            if(update != null)
            {
                errorLbl.Text = update;
            }
            else
            {
                Response.Redirect("~/Views/Admin/AdminHomePage.aspx");
            }
        }
    }
}