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
    public partial class AddRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Meat> meats = MeatRepository.displayMeat();
            meatListGV.DataSource = meats;
            meatListGV.DataBind();
        }

        protected void btn_add1_Click(object sender, EventArgs e)
        {
            addStatus_txt.Text = RamenController.addRamen(RamenName_txt.Text, addMeatDD.Text, broth_txt.Text, price_txt.Text);
        }

        protected void addBack_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRamen.aspx");
        }
    }
}