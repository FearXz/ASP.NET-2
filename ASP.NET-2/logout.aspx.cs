using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_2
{
    public partial class logout : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                userData.InnerText = "Username: " + Request.Cookies["login"]["username"];
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            DeleteCookie("login");
        }

        protected void DeleteCookie(string cookie)
        {
            HttpCookie userData = new HttpCookie(cookie);
            userData.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(userData);
            Response.Redirect("Default.aspx");
        }
    }
}