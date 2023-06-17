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
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<RamenView> ramens = RamenRepository.displayRamen();
            RamenGV.DataSource = ramens;
            RamenGV.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRamen.aspx");
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditRamen.aspx");
        }
    }
}