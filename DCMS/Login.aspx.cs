using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Log_Click(object sender, EventArgs e)
    {
        string user = USER.Text;
        string pass = PASS.Text;
        if (new AdminDAO().verifyAdmin(user, pass))
        {
            
            Response.Redirect("Menu.aspx?user="+user);
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Wrong User Name or Password!!! Please recheck!');</script>");
            //MessageBox.Show("Wrong User Name or Password!!! Please recheck!");
        }
    }
}