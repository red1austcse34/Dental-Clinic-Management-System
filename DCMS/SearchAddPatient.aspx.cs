using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchAddPatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Search_Click(object sender, EventArgs e)
    {
        string searchContactNo = tbSearchContactNo.Text;
        Response.Redirect("ShowPatientDetails.aspx?con="+searchContactNo);
    }
    protected void add_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewPatient.aspx");
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void list_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShowPatients.aspx");
    }
}