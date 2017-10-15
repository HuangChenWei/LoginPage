using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (login__username.Text == "s1066037" && login__password.Text == "s1066037")
        {
            Session["id"] = login__username.Text;
            Session["pswd"] = login__password.Text;
            Response.Redirect("~/default.aspx");
        }
    }
}