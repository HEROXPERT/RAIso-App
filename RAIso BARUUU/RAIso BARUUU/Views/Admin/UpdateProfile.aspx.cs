using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;
using System.Web.UI;

namespace RAIso_BARUUU.Views.Admin
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser user = UserController.getUserbyusername("Admin");
                usernameTb.Text = user.UserName;
                passwordTb.Text = user.UserPassword;
                dobTb.Text = user.UserDOB.ToString("yyyy-MM-dd");
                genderDDL.Text = user.UserGender;
                addressTb.Text = user.UserAddress;
                phoneTb.Text = user.UserPhone;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            MsUser user = UserController.getUserbyusername("Admin");
            String usernameBefore = user.UserName;
            String username = usernameTb.Text.Trim();
            String password = passwordTb.Text.Trim();
            String address = addressTb.Text.Trim();
            String phone = phoneTb.Text.Trim();
            DateTime dob = Convert.ToDateTime(dobTb.Text);
            String gender = genderDDL.SelectedValue;
            String update = UserController.UpdateAdmin(user.UserID, username, gender, dob, phone, address, password, usernameBefore);
            if (update != null)
            {
                errorLbl.Text = update;
            }
            else
            {
                Response.Redirect("~/Views/Customer/AdminHomePage.aspx");
            }
        }
    }
}