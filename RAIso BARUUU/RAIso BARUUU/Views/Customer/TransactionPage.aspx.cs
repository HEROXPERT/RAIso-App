using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                MsUser currentUser = (MsUser)Session["user"];
                List<TransactionHeader> th = TransactionHeaderRepository.getTransactionHeaderByUserId(currentUser.UserID);
                TransactionGV.DataSource = th;
                TransactionGV.DataBind();
            }
        }

        protected void TransactionGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = TransactionGV.Rows[e.NewSelectedIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Customer/TransactionDetailPage.aspx?id=" + id);
        }
    }
}