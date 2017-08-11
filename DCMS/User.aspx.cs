using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Confirm_Click(object sender, EventArgs e)
    {
        string user = Name.Text;
        string pass = Pass.Text;
        if (pass.Equals(CPass.Text))
        {
            if(new AdminDAO().addAdmin(new AdminDTO(user, pass)))
            {
                 Response.Redirect("Menu.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error!!! Please try again!!');</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Password doesn't match!!!');</script>");
        }
    }
}