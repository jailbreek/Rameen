using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View.Transaction
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<historyView> disHeader = historyRepository.displayHeaders();
            histGV.DataSource = disHeader;
            histGV.DataBind();
        }

        protected void histGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = histGV.SelectedRow;
            string id = row.Cells[1].Text;
            HttpCookie cookie = new HttpCookie("historyCookie");
            cookie["id"] = id;
            cookie.Expires.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("DetailView.aspx");
        }
    }
}