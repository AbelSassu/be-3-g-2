using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace be_3_g_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["LOGIN"];
            if (login != null)
            {
                string name = login.Values["username"];
                Response.Write($"Benvenuto {name}, ora puoi anche sloggare.");
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["LOGIN"];
            login.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(login);
            Response.Redirect("Login.aspx");
        }
    }
}