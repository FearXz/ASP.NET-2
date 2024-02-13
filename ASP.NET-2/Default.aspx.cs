using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie userData = new HttpCookie("login");

            if (!string.IsNullOrEmpty(username.Value) && !string.IsNullOrEmpty(password.Value))
            {
                userData.Values["username"] = username.Value;
                userData.Values["password"] = password.Value;

                userData.Expires = DateTime.Now.AddDays(7);

                Response.Cookies.Add(userData);

                Response.Redirect("logout.aspx");
            }
        }
    }
}