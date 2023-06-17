using Raameenn.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raameenn.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var IdCookie = Request.Cookies["RoleId"];
            if (IdCookie != null)
            {
                if (!String.IsNullOrEmpty(IdCookie.Value))
                {
                    Response.Redirect("/View/Home.aspx");
                }
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInputs();

            if (isValid)
            {
                string Username = txtUsername.Text;
                string Email = txtEmail.Text;
                string Gender = ddlGender.SelectedValue;
                int RoleId = int.Parse(ddlRole.SelectedValue);
                string Password = txtConPass.Text;

                UserController.RegisUser(Username, Email, Gender, RoleId, Password);

                Response.Redirect("/View/Login.aspx");
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            isValid &= ValidateField(txtUsername, errorUsr, "", "Length must be between 5 and 15 characters and contain alphabets with spaces only", (value) => value.Length >= 5 && value.Length <= 15 && IsValidUsername(value));
            isValid &= ValidateField(txtEmail, errorEmail, "", "Must end with '.com'", (value) => value.EndsWith(".com"));
            isValid &= ValidateField(ddlGender, errorGender, "", "Please select a valid gender", (value) => value != "Select");
            isValid &= ValidateField(ddlRole, errorRole, "", "Please select a role", (value) => value != "Select");
            isValid &= ValidateField(txtPass, errorPass, "", "Password is required", (value) => !string.IsNullOrEmpty(value));
            isValid &= ValidateField(txtConPass, errorConpass, "", "Passwords do not match", (value) => value == txtPass.Text.Trim());

            return isValid;
        }

        private bool ValidateField<TControl>(TControl control, Label errorLabel, string fieldName, string errorMsg, Func<string, bool> validationFunc) where TControl : Control
        {
            string value = (control as TextBox)?.Text.Trim() ?? (control as DropDownList)?.SelectedValue;

            if (!validationFunc(value))
            {
                errorLabel.Text = $"({errorMsg})";
                errorLabel.Visible = true;
                return false;
            }
            errorLabel.Visible = false;
            return true;
        }

        private bool IsValidUsername(string input) //Alphabet with space
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/View/Login.aspx");
        }
    }
}