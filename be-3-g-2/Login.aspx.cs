using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace be_3_g_2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie login = new HttpCookie("LOGIN");
            login.Values["username"]= TextName.Text;
            login.Values["password"] = TextPass.Text;
            login.Expires = DateTime.Now.AddDays(20);
            Response.Cookies.Add(login);
            Response.Redirect("WebForm1.aspx");
        }
    }
}