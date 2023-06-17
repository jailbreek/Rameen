using System;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Raameenn.Controller;
using Raameenn.Model;

namespace Raameenn.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idCookie = Request.Cookies["RoleId"];
            var roleCookie = Request.Cookies["Role"];
            if (idCookie == null)
            {
                Response.Redirect("/View/Login.aspx");
            }

            if (!IsPostBack)
            {
                if (roleCookie != null)
                {
                    if (roleCookie.Value.Equals("buyer"))
                    {
                        return;
                    }

                    if (roleCookie.Value.Equals("seller"))
                    {
                        LoadCustomerData("buyer");
                        return;
                    }

                    if (roleCookie.Value.Equals("admin"))
                    {
                        LoadCustomerData("seller");
                        return;
                    }

                }
            }
        }

        private void LoadCustomerData(string role)
        {
            List<User> customers = UserController.GetAllUserByRole(role);

            GDcustoms.DataSource = customers;

            GDcustoms.DataBind();
        }
    }
}
