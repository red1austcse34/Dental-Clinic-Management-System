using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ShowPatients : System.Web.UI.Page
{
    DataSet d = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        d = new PatientDAO().getPatients();
        if (d != null)
        {
            if (d.Tables[0].Rows.Count != 0)
            {
                Patients.DataSource = d;
                Patients.DataBind();
            }
            else
            {
                Patients.DataSource = null;
                Patients.DataBind();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("SearchAddPatient.aspx");
    }
}