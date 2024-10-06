using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;

namespace RAIso_BARUUU.Views.Customer
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser user = (MsUser)Session["user"];
                if (user != null)
                {
                    usernameTb.Text = user.UserName;
                    passwordTb.Text = user.UserPassword;
                    dobTb.Text = user.UserDOB.ToString("yyyy-MM-dd");
                    genderDDL.SelectedValue = user.UserGender;
                    addressTb.Text = user.UserAddress;
                    phoneTb.Text = user.UserPhone;
                }
                else
                {
                    Response.Redirect("~/Views/Guest/Login.aspx");
                }
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            if (user != null)
            {
                string usernameBefore = user.UserName;
                string username = usernameTb.Text.Trim();
                string password = passwordTb.Text.Trim();
                string address = addressTb.Text.Trim();
                string phone = phoneTb.Text.Trim();
                DateTime dob = Convert.ToDateTime(dobTb.Text);
                string gender = genderDDL.SelectedValue;

                string update = UserController.Update(user.UserID, username, gender, dob, phone, address, password, usernameBefore);
                if (update != null)
                {
                    errorLbl.Text = update;
                }
                else
                {
                    Session["user"] = UserController.getUserbyId(user.UserID);
                    Response.Redirect("~/Views/Customer/CustomerHomePage.aspx?userid=" + user.UserID);
                }
            }
            else
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
        }
    }
}