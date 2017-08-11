using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DoctorDAO
/// </summary>
public class DoctorDAO
{
    Conect c = new Conect();
	public DoctorDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public SqlDataReader getDoctors()
    {
        string query = "select Name from doctor where Available=1";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public SqlDataReader getDoctors2()
    {
        string query = "select Name from doctor";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public int getID(string name)
    {
        string query = "select DocId from doctor where Name='"+name+"'";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return Convert.ToInt32(c.dataSet.Tables[0].Rows[0][0]);
    }

    public DataSet getDocs()
    {
        string query = "select * from doctor";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public DataSet getInfo(string name)
    {
        string query = "select * from doctor where name='" + name + "'";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public bool update(DoctorDTO d)
    {
        int s=0;
        if (d.Available == true) s = 1;
        string query = "update doctor set Name='" + d.Name + "', Salary=" + d.Salary + ", Available =" + s + " where DocId=" + d.DocID;
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

    public bool add(DoctorDTO d)
    {
        int s = 0;
        if (d.Available == true) s = 1;
        try
        {
            string query = "insert into doctor (Name, Salary, Available) values ('" + d.Name + "'," + d.Salary + "," + s + ")";
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            for (int i = 0; i < 7; i++)
            {
                new AppointmentDAO().addNew(d.Name, DateTime.Today.AddDays(i).ToString("dd-MM-yyyy"));
            }
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}