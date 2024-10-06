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
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsStationery> stationeries = StationeryController.getStationery();
            StationeryGV.DataSource = stationeries;
            StationeryGV.DataBind();
        }

        protected void StationeryGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = StationeryGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            StationeryController.Delete(id);
            List<MsStationery> stationeries = StationeryController.getStationery();
            StationeryGV.DataSource = stationeries;
            StationeryGV.DataBind();
        }

        protected void StationeryGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = StationeryGV.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Admin/UpdatePage.aspx?id=" + id);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertPage.aspx");
        }
    }
}