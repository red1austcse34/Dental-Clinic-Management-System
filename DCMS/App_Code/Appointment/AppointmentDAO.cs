using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Summary description for AppointmentDAO
/// </summary>
public class AppointmentDAO
{
    Conect c = new Conect();
	public AppointmentDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
	}

    public bool rowsExist()
    {
        c.sqlConn.Open();
        string query = "select * from Appointment";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count == 0) return false;
        else return true;
    }

    public void addRows()
    {
        c.sqlConn.Open();
        string query = "", date= "", name = "";
        SqlDataReader DR = new DoctorDAO().getDoctors();
        while (DR.Read())
        {
            name = DR[0].ToString();
            for (int i = 0; i < 7; i++)
            {
                date = System.DateTime.Today.AddDays(i).ToString("dd-MM-yyyy");
                query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
                c.sqlComm = new SqlCommand(query, c.sqlConn);
                c.sqlComm.ExecuteNonQuery();
            }
        }
        c.sqlConn.Close();
    }

    public DataSet getRow(AppointmentDTO a)
    {
        c.sqlConn.Open();
        string query = "select * from Appointment where Name='" + a.Name +"' and Date='"+ a.Date + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public bool getApp(AppointmentDTO a)
    {
        c.sqlConn.Open();
        string query = "update Appointment set [" + a.Time + "]=" + a.Id + " where Name='" + a.Name + "' and Date='" + a.Date + "'";
        try
        {
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            c.sqlConn.Close();
            return false;
        }
    }

    public bool prevDay(int i)
    {
        string date = DateTime.Today.AddDays(-i).ToString("dd-MM-yyyy");
        string query = "select * from Appointment where Date='" + date + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count == 0) return false;
        else return true;
    }

    public void adjust()
    {
        for (int i = 1; i < 6; i++)
        {
            if (prevDay(i))
            {
                c.sqlConn.Open();
                string date = DateTime.Today.AddDays(-i).ToString("dd-MM-yyyy");
                string query = "Delete from Appointment where Date='" + date + "'";
                string name = "";
                c.sqlComm = new SqlCommand(query, c.sqlConn);
                c.sqlComm.ExecuteNonQuery();
                SqlDataReader DR = new DoctorDAO().getDoctors2();
                while (DR.Read())
                {
                    name = DR[0].ToString();
                    date = System.DateTime.Today.AddDays(i).ToString("dd-MM-yyyy");
                    query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
                    c.sqlComm = new SqlCommand(query, c.sqlConn);
                    c.sqlComm.ExecuteNonQuery();
                }
            }
        }
        c.sqlConn.Close();
    }

    public string[] find(int id)
    {
        c.sqlConn.Open();
        string query = "";
        int i;
        string[] d = new string[] {"", "", ""};
        string[] times = new string[] { "9:00am", "9:30am", "10:00am", "10:30am", "5:00pm", "5:30pm", "6:00pm", "6:30pm", "7:00pm", "7:30pm", "8:00pm", "8:30pm" };
        for (i = 0; i < 12; i++)
        {
            query = "select * from Appointment where [" + times[i] + "]=" + id + "";
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlAdap = new SqlDataAdapter(c.sqlComm);

            c.dataSet = new DataSet();
            c.sqlAdap.Fill(c.dataSet);
            if (c.dataSet.Tables[0].Rows.Count > 0) break;
        }
        if (c.dataSet.Tables[0].Rows.Count > 0)
        {
            d[0] = c.dataSet.Tables[0].Rows[0]["Name"].ToString();
            d[1] = c.dataSet.Tables[0].Rows[0]["Date"].ToString();
            d[2] = times[i];
        }
        return d;
    }

    public bool delete(AppointmentDTO a)
    {
        c.sqlConn.Open();
        string query = "update Appointment set [" + a.Time + "]= 0 where Name='" + a.Name + "' and Date='" + a.Date + "'";
        try
        {
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            c.sqlConn.Close();
            return false;
        }
    }

    public DataSet appList()
    {
        c.sqlConn.Open();
        string query = "select * from Appointment";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public void addNew(string name, string date)
    {
        c.sqlConn.Open();
        string query = "INSERT INTO Appointment (Name, Date) values ('" + name + "','" + date + "')";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlComm.ExecuteNonQuery();
        c.sqlConn.Close();
    }
}