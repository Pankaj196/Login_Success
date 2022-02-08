using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Success
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(txtUname.Text,txtPass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUname.Text, true);
            }
            else
            {
                Response.Write("Invalid Credentials");
            }
            //Response.Redirect("Success.aspx");
        }
    }
}