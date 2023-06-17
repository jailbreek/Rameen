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
    public partial class DetailView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["historyCookie"];
            int id = int.Parse(cookie["id"]);
            List<detailView> disDetail = detailRepository.displayDetail(id);
            detGV.DataSource = disDetail;
            detGV.DataBind();
        }
    }
}