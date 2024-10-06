using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class CartPage : System.Web.UI.Page
    {
        private List<Cart> cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadCartData();
            }
        }

        private void LoadCartData()
        {
            MsUser currentUser = (MsUser)Session["user"];
            cart = CartController.getCarts(currentUser.UserID);
            CartGV.DataSource = cart;
            CartGV.DataBind();
        }

        protected void CartGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                MsUser currentUser = (MsUser)Session["user"];
                GridViewRow row = CartGV.Rows[e.NewEditIndex];
                String name = row.Cells[0].Text;
                String statname = row.Cells[1].Text;
                MsUser user = UserController.getUserbyusername(name);
                MsStationery stat = StationeryController.getStatbyName(statname);
                int statid = stat.StationeryID;
                int userid = currentUser.UserID;
                Response.Redirect($"~/Views/Customer/UpdateCartPage.aspx?statid={statid}&userid={userid}");
            }
        }

        protected void CartGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                MsUser currentUser = (MsUser)Session["user"];
                GridViewRow row = CartGV.Rows[e.RowIndex];
                String name = row.Cells[0].Text;
                String statname = row.Cells[1].Text;
                MsUser user = UserController.getUserbyusername(name);
                MsStationery stat = StationeryController.getStatbyName(statname);
                int userid = currentUser.UserID;
                int statid = stat.StationeryID;
                CartController.DeleteCart(statid, userid);
                LoadCartData();
            }
        }

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                MsUser currentUser = (MsUser)Session["user"];
                int userid = currentUser.UserID;

                if (cart == null)
                {
                    LoadCartData();
                }

                TransactionHeader newTransaction = TransactionHeaderRepository.Create(userid);

                foreach (var carts in cart)
                {
                    TransactionDetailRepository.Create(newTransaction.TransactionID, carts.StationeryID, carts.Quantity);
                }
                CartController.DeleteAll(userid);
                LoadCartData();
            }
        }
    }
}