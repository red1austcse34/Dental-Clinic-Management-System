using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public partial class ShowPatientDetails : System.Web.UI.Page
{
    string con = "";
    int id=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con = Request.QueryString["con"];
            DataSet D = new DataSet();
            D = new PatientDAO().getPatient(con);
            id = Convert.ToInt32(D.Tables[0].Rows[0][0]);
            if (D.Tables[0].Rows.Count > 0)
            {
                tbName.Text = D.Tables[0].Rows[0][1].ToString();
                tbAddress.Text = D.Tables[0].Rows[0][2].ToString();
                tbContactNo.Text = D.Tables[0].Rows[0][3].ToString();
                tbAge.Text = D.Tables[0].Rows[0][4].ToString();
                tbSex.Text = D.Tables[0].Rows[0][5].ToString();
                tbMaritalStatus.Text = D.Tables[0].Rows[0][6].ToString();
                tbOccupation.Text = D.Tables[0].Rows[0][7].ToString();
                MedInfo.InnerText = D.Tables[0].Rows[0][8].ToString();
            }
            else
            {
                MessageBox.Show("No match found!");
                Response.Redirect("SearchAddPatient.aspx");
            }
        }
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        con = Request.QueryString["con"];
        DataSet D = new DataSet();
        D = new PatientDAO().getPatient(con);
        id = Convert.ToInt32(D.Tables[0].Rows[0][0]);
        string name = tbName.Text;
        string address = tbAddress.Text;
        string contactNo = tbContactNo.Text;
        int age = Convert.ToInt32(tbAge.Text);
        string sex = tbSex.Text;
        string mStatus = tbMaritalStatus.Text;
        string occ = tbOccupation.Text;
        string medInfo = MedInfo.InnerText;
        if (new PatientDAO().updatePatient(id, new PatientDTO(name, address, contactNo, age, sex, mStatus, occ, medInfo)))
        {

            Response.Redirect("SearchAddPatient.aspx");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Update Error!! Please try again!!!');</script>");
        }
    }
    protected void Proceed_Click(object sender, EventArgs e)
    {
        con = Request.QueryString["con"];
        DataSet D = new DataSet();
        D = new PatientDAO().getPatient(con);
        id = Convert.ToInt32(D.Tables[0].Rows[0][0]);
        Response.Redirect("AutomatedBill.aspx?id=" + id);
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("SearchAddPatient.aspx");
    }
    protected void History_Click(object sender, EventArgs e)
    {
        con = Request.QueryString["con"];
        DataSet D = new DataSet();
        D = new PatientDAO().getPatient(con);
        id = Convert.ToInt32(D.Tables[0].Rows[0][0]);
        Response.Redirect("DentalHistory.aspx?id="+ id);
    }
}