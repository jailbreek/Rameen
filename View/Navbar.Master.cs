using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        private Dictionary<string, string> buyer = new Dictionary<string, string> {
                { "Home", "Home.aspx" },
                { "Order Ramen", "/View/Order/Navbar.aspx"},
                { "History", "/View/History/Navbar.aspx" },
                { "Profile", "/View/UserProfile.aspx" }
            };

        private Dictionary<string, string> seller = new Dictionary<string, string>
            {
                { "Home", "Home.aspx" },
                { "Manage Ramen", "/View/Ramen/ManageRamen.aspx"},
                { "Order Queue", "/View/Order/Queue.aspx" },
                { "Profile", "/View/UserProfile.aspx" }
            };

        private Dictionary<string, string> admin = new Dictionary<string, string>
            {
                { "Home", "Home.aspx" },
                { "Manage Ramen", "~/View/Ramen/ManageRamen.aspx"},
                { "Order Queue", "~/View/Order/Queue.aspx" },
                { "History", "~/View/History/Navbar.aspx" },
                { "Report", "~/View/Report/Navbar.aspx" },
                { "Profile", "~/View/UserProfile.aspx" }
            };

        private Dictionary<string, string> menuItems;
        protected void Page_Load(object sender, EventArgs e)
        {
            var idCookie = Request.Cookies["RoleId"];

            if (idCookie == null)
            {
                Response.Redirect("/View/Login.aspx");
            }


            var roleCookie = Request.Cookies["Role"];

            if (roleCookie != null)
            {
                lblrole.Text = roleCookie.Value;
            }

            switch (roleCookie.Value)
            {
                case "admin":
                    this.menuItems = this.admin;
                    break;
                case "buyer":
                    this.menuItems = this.buyer;
                    break;
                case "seller":
                    this.menuItems = this.seller;
                    break;
                default:
                    this.menuItems = this.buyer;
                    break;
            }

            foreach (KeyValuePair<string, string> menuItem in menuItems)
            {
                HyperLink link = new HyperLink();
                link.Text = menuItem.Key;
                link.NavigateUrl = menuItem.Value;
                menuHolder.Controls.Add(link);
                menuHolder.Controls.Add(new LiteralControl(" | "));
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            if (Request.Cookies["RoleId"] != null)
            {
                Response.Cookies["Role"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["RoleId"].Expires = DateTime.Now.AddDays(-1);

                Response.Redirect("/View/Login.aspx");
            }
        }
    }
}