using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddDoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Confirm_Click(object sender, EventArgs e)
    {
        if (new DoctorDAO().add(new DoctorDTO(0, tbName.Text, Convert.ToInt32(tbSalary.Text), true)))
        {
            Response.Redirect("Doctors.aspx");
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Doctors.aspx");
    }
}