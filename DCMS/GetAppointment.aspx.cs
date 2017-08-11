using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public partial class GetAppointment : System.Web.UI.Page
{
    string[] times = new string[] { "9:00am", "9:30am", "10:00am", "10:30am", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm", "7:30pm", "8:00pm", "8:30pm" };
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["pID"]);
            if (!new AppointmentDAO().rowsExist()) new AppointmentDAO().addRows();
            new AppointmentDAO().adjust();
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 7; i++)
            {
                arrList.Add(System.DateTime.Today.AddDays(i).ToString("dd-MM-yyyy"));
            }

            ddlDate.DataSource = arrList;
            ddlDate.DataBind();

            SqlDataReader DR = new DoctorDAO().getDoctors();
            while (DR.Read())
            {
                ddlDoctor.Items.Add(DR[0].ToString());
            }
        }
    }
    protected void ddlDate_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void ddlDoctor_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Check_Click(object sender, EventArgs e)
    {
        string date = ddlDate.SelectedValue.ToString();
        string doc = ddlDoctor.SelectedValue.ToString();
        DataSet d = new AppointmentDAO().getRow(new AppointmentDTO(doc, date));
        ddlTime.Items.Clear();
        for (int i = 0; i < 12; i++)
        {
            if (Convert.ToInt32(d.Tables[0].Rows[0][i+2]) == 0) ddlTime.Items.Add(times[i]);
        }
    }
    protected void Ok_Click(object sender, EventArgs e)
    {
        string date = ddlDate.SelectedValue.ToString();
        string doc = ddlDoctor.SelectedValue.ToString();
        string time = ddlTime.SelectedValue.ToString();
        id = Convert.ToInt32(Request.QueryString["pID"]);
        if (new AppointmentDAO().getApp(new AppointmentDTO(doc, date, time, id)))
        {
            MessageBox.Show("Success");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["pID"]);
        Response.Redirect("ManageAppointment.aspx?id=" + id);
    }
}