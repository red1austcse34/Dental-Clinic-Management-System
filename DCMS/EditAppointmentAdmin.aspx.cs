using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;

public partial class EditAppointmentAdmin : System.Web.UI.Page
{
    string[] times = new string[] { "9:00am", "9:30am", "10:00am", "10:30am", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm", "7:30pm", "8:00pm", "8:30pm" };
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
    protected void Search_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(tbPatientID.Text);
        tbPatientName.Text = new PatientDAO().getName(id);
        string[] d = new string[3];
        string app = "";
        d = new AppointmentDAO().find(id);
        app += "Doctor's Name: " + d[0] + "\n";
        app += "Patient's Name: " + new PatientDAO().getName(id) + "\n";
        app += "Date: " + d[1] + "\n";
        app += "Time: " + d[2] + "\n";
        Appoint.InnerText = app;

    }
    protected void Fetch_Click(object sender, EventArgs e)
    {
        string date = ddlDate.SelectedValue.ToString();
        string doc = ddlDoctor.SelectedValue.ToString();
        DataSet d = new AppointmentDAO().getRow(new AppointmentDTO(doc, date));
        ddlTime.Items.Clear();
        for (int i = 0; i < 12; i++)
        {
            if (Convert.ToInt32(d.Tables[0].Rows[0][i + 2]) == 0) ddlTime.Items.Add(times[i]);
        }
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(tbPatientID.Text);
        string[] d = new string[3];
        d = new AppointmentDAO().find(id);
        if (new AppointmentDAO().delete(new AppointmentDTO(d[0], d[1], d[2], id)))
        {
            string date = ddlDate.SelectedValue.ToString();
            string doc = ddlDoctor.SelectedValue.ToString();
            string time = ddlTime.SelectedValue.ToString();
            if (new AppointmentDAO().getApp(new AppointmentDTO(doc, date, time, id)))
            {
                string app = "";
                d = new AppointmentDAO().find(id);
                app += "Doctor's Name: " + d[0] + "\n";
                app += "Patient's Name: " + new PatientDAO().getName(id) + "\n";
                app += "Date: " + d[1] + "\n";
                app += "Time: " + d[2] + "\n";
                Appoint.InnerText = app;
                Response.Redirect("ViewAppointments.aspx");
            }
            else MessageBox.Show("ERROR!!!");
        }
        else MessageBox.Show("ERROR!!!");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(tbPatientID.Text);
        string[] d = new string[3];
        d = new AppointmentDAO().find(id);
        if (new AppointmentDAO().delete(new AppointmentDTO(d[0], d[1], d[2], id)))
        {
            Appoint.InnerText = "";
            Response.Redirect("ViewAppointments.aspx");
        }
        else MessageBox.Show("ERROR!!!");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewAppointments.aspx");
    }
}