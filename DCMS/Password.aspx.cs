using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Password : System.Web.UI.Page
{
    string user = "", pass = "", newPass = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        user = Request.QueryString["user"];
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Confirm_Click(object sender, EventArgs e)
    {
        user = Request.QueryString["user"];
        pass = PASS.Text;
        newPass = Newpass.Text;
        new AdminDAO().changePass(user, pass, newPass);
        Response.Redirect("Menu.aspx");
    }
}