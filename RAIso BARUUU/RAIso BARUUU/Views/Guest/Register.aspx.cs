using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Factory;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAIso_BARUUU.Views.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTb.Text.Trim();
            String password = passwordTb.Text.Trim();
            String address = addressTb.Text.Trim();
            String phone = phoneTb.Text.Trim();
            DateTime dob = Convert.ToDateTime(dobTb.Text);
            String gender = genderDDL.SelectedValue;
            String insertCheck = UserController.Register(username, gender, dob, phone, address, password);
            if(insertCheck == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
            else
            {
                errorLbl.Text = insertCheck;
            }
        }
    }
}