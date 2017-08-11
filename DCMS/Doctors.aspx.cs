using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctors : System.Web.UI.Page
{
    DataSet d;
    protected void Page_Load(object sender, EventArgs e)
    {
        d = new DoctorDAO().getDocs();
        if (d != null)
        {
            if (d.Tables[0].Rows.Count != 0)
            {
                Docs.DataSource = d;
                Docs.DataBind();
            }
            else
            {
                Docs.DataSource = null;
                Docs.DataBind();
            }
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddDoc.aspx");
    }
}