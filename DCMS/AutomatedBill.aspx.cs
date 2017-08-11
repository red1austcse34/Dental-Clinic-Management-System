using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class AutomatedBill : System.Web.UI.Page
{
    int id = 0;
    string treatment = "";
    string tooth = "";
    string numOfTooth = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            tbPatientID.Text = id.ToString();
            SqlDataReader DR = new TreatmentDAO().getTreatments();
            while (DR.Read())
            {
                ddlTreatment.Items.Add(DR[0].ToString());
            }
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Pay_Click(object sender, EventArgs e)
    {
        tooth = tbTooth.Text;
        numOfTooth = tbNumOfTooth.Text;
        treatment = ddlTreatment.SelectedValue.ToString();
        string cost = tbCost.Text;
        if (new PaymentDAO().pay(new PaymentDTO(tbPatientID.Text, tbDocID.Text, treatment, tooth, numOfTooth, cost)))
        {
            MessageBox.Show("Success!!!");
        }
        else MessageBox.Show("ERROR!!!");
        //Response.Redirect("FinalBill.aspx?pid="+id.ToString()+"&treatment="+treatment+"&num="+numOfTooth+"&tooth="+tooth);
        
    }
    protected void tbPatientID_TextChanged(object sender, EventArgs e)
    {
        id = Convert.ToInt32(tbPatientID.Text);
    }
    protected void Calculate_Click(object sender, EventArgs e)
    {
        tooth = tbTooth.Text;
        numOfTooth = tbNumOfTooth.Text;
        treatment = ddlTreatment.SelectedValue.ToString();
        tbCost.Text = (Convert.ToInt32(numOfTooth) * new TreatmentDAO().getCost(treatment)).ToString();
    }
}