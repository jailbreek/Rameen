using Raameenn.Model;
using Raameenn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View.Ramen
{
    public partial class EditRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<RamenView> ramens = RamenRepository.displayRamen();
            editGV.DataSource = ramens;
            editGV.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            editGV.EditIndex = e.NewEditIndex;
            int index = editGV.EditIndex;
            GridViewRow row = editGV.Rows[index];
            string id = row.Cells[1].Text;
            HttpCookie cookie = new HttpCookie("RamenInfo");
            cookie["id"] = id;
            cookie.Expires.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("EditRamen1.aspx");
        }

        protected void editBackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }
    }
}