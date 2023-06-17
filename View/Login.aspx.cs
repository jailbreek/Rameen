using Raameenn.Controller;
using Raameenn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckAndRedirectToHomePage();
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateInput(username, password))
            {
                User userLogin = UserController.Login(username, password);

                if (userLogin != null)
                {
                    bool isSetCookies = chkRememberMe.Checked;

                    if (isSetCookies)
                    {
                        SetUserCookies(userLogin);
                    }

                    Response.Redirect("/View/Home.aspx");
                }
                else
                {
                    ShowErrorMessage("Invalid username or password.");
                }
            }
            else
            {
                ShowErrorMessage("Please enter a valid username and password.");
            }
        }
        protected void CheckAndRedirectToHomePage()
        {
            HttpCookie IdCookie = Request.Cookies["RoleId"];
            if (IdCookie != null && !string.IsNullOrEmpty(IdCookie.Value))
            {
                Response.Redirect("/View/Home.aspx");
            }
        }
        protected bool ValidateInput(string username, string password)
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
        protected void SetUserCookies(User user)
        {
            if (user != null && user.Role != null)
            {
                HttpCookie IdCookie = new HttpCookie("RoleId", user.RoleId.ToString())
                {
                    Expires = DateTime.Now.AddDays(1)
                };
                HttpCookie roleCookie = new HttpCookie("Role", user.Role.Name)
                {
                    Expires = DateTime.Now.AddDays(1)
                };
                Response.Cookies.Add(IdCookie);
                Response.Cookies.Add(roleCookie);
            }
        }

        protected void ShowErrorMessage(string message)
        {
            errorMsg.Text = message;
            errorMsg.Visible = true;
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Register.aspx");
        }
    }
}