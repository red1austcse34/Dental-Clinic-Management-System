using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Log_Click(object sender, EventArgs e)
    {
        string contact = CONTACT.Text;
        int id = Convert.ToInt32(ID.Text);
        if (new PatientDAO().verifyPatient(contact, id))
        {
            Response.Redirect("ManageAppointment.aspx?id=" + id.ToString());
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Contact Number & ID does not match!');</script>");
        }
    }
}