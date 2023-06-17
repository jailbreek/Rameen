using Raameenn.Controller;
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
    public partial class EditRamen1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie kuki = Request.Cookies["RamenInfo"];
            int id = int.Parse(kuki["id"]);
            List<RamenView> ramens = RamenRepository.selectRamen(id);
            editGV1.DataSource = ramens;
            editGV1.DataBind();
        }

        protected void edit_btn1_Click(object sender, EventArgs e)
        {
            HttpCookie kuki = Request.Cookies["RamenInfo"];
            edit_status.Text = RamenController.editRamen(kuki["id"].ToString(), editName.Text, editDD.SelectedValue.ToString(), editBroth.Text, editPrice.Text);
            Response.Redirect("EditRamen1.aspx");
        }

        protected void editBack_btn1_Click(object sender, EventArgs e)
        {
            HttpCookie kuki = Request.Cookies["RamenInfo"];
            kuki.Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("EditRamen.aspx");
        }
    }
}