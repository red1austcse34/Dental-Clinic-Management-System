using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageAppointment : System.Web.UI.Page
{
    public static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Convert.ToInt32(Request.QueryString["id"]);
        }
    }
    protected void bGetA_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("GetAppointment.aspx?pID="+id);
    }
    protected void bModifyA_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("EditAppointment.aspx?pID=" + id);
    }
}