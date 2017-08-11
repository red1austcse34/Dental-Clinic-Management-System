using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ViewAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        new AppointmentDAO().adjust();
        if (!IsPostBack)
        {
            DataSet d = new AppointmentDAO().appList();
            if (d != null)
            {
                if (d.Tables[0].Rows.Count != 0)
                {
                    AppList.DataSource = d;
                    AppList.DataBind();
                }
                else
                {
                    AppList.DataSource = null;
                    AppList.DataBind();
                }
            }
        }
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditAppointmentAdmin.aspx");
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
}