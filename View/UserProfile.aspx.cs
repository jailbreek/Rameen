using Raameenn.Controller;
using Raameenn.Model;
using System;
using System.Web.UI.WebControls;

namespace Raameenn.View
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var IdCookie = Request.Cookies["RoleId"];

                if (IdCookie == null)
                {
                    Response.Redirect("/View/Login.aspx");
                }

                int userId = int.Parse(IdCookie.Value);
                User user = UserController.GetUserById(userId);

                txtUsername.Text = user.Username;
                txtEmail.Text = user.Email;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditMode(true);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string newUser = txtUsername.Text;
            string newMail = txtEmail.Text;
            string newGender = ddlGender.SelectedValue;
            var IdCookie = Request.Cookies["IdCookie"];

            if (IdCookie == null)
            {
                Response.Redirect("/Pages/Login.aspx");
            }

            int userId = int.Parse(IdCookie.Value);

            bool isUpdated = UserController.Update(userId, newUser, newMail, newGender);

            if (isUpdated)
            {
                lblInfo.Text = "Info: Successfully updated your profile!";
                EnableEditMode(false);
            }
            else
            {
                lblInfo.Text = "Info: Cannot update your profile!";
            }
        }

        protected void txtUsername_Change(object sender, EventArgs e)
        {
            string newUser = txtUsername.Text;
        }

        protected void txtEmail_Change(object sender, EventArgs e)
        {
            string newMail = txtEmail.Text;
        }

        private void EnableEditMode(bool enable)
        {
            txtUsername.Enabled = enable;
            txtEmail.Enabled = enable;
            ddlGender.Enabled = enable;

            btnEdit.Visible = enable;
            btnSave.Enabled = enable;
            btnSave.Visible = enable;
        }

    }
}
