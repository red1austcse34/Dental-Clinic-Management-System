using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void bManageAppoinment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientLogin.aspx");
    }
    protected void bRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewPatient.aspx");
    }
}