using RAIso_BARUUU.Controller;
using RAIso_BARUUU.Model;
using System;
using System.Web;

namespace RAIso_BARUUU.Views.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                {
                    usernameTb.Text = Request.Cookies["username"].Value;
                    passwordTb.Text = Request.Cookies["password"].Value;
                }
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text.Trim();
            string password = passwordTb.Text.Trim();
            string login = UserController.Login(username, password);

            if (login.Equals("success"))
            {
                MsUser user = UserController.getUserbyusername(username);
                int userid = user.UserID;
                Session["user"] = user;

                if (checkRememberme.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserName;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(-1);
                }
                Response.Redirect("~/Views/Customer/CustomerHomePage.aspx?userid=" + userid);
            }
            else if (login.Equals("Admin"))
            {
                Response.Redirect("~/Views/Admin/AdminHomePage.aspx");
            }
            else
            {
                errorLbl.Text = login;
            }
        }
    }
}