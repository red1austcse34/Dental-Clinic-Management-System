using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddTreatment : System.Web.UI.Page
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
        if (new TreatmentDAO().addTreatment(new TreatmentDTO(tbName.Text, Convert.ToInt32(tbCost.Text))))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Added Successfully!!!');</script>");
            Response.Redirect("Menu.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Couldn't Process!!!');</script>");
            Response.Redirect("AddTreatment.aspx");
        }
    }
}