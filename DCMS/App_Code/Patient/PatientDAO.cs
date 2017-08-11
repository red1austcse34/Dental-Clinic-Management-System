using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Summary description for PatientDAO
/// </summary>
public class PatientDAO
{
    Conect c = new Conect();
	public PatientDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public bool createPatient(PatientDTO p)
    {
        try
        {
            string query = "insert into patient (Name, Address, Contact, Age, Sex, MaritialStatus, Occupation, MedicalInfo) values ('" + p.Name + "','" + p.Address + "','" + p.ContactNo + "'," + p.Age + ",'" + p.Sex + "','" + p.MarialStatus + "','" + p.Occupation + "','" + p.MedInfo + "')";

            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public DataSet getPatient(string contact)
    {
        string query = "select * from patient where Contact ='" + contact + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public string getName(int id)
    {
        string query = "select Name from patient where id =" + id;

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet.Tables[0].Rows[0][0].ToString();
    }

    public bool updatePatient(int id, PatientDTO p)
    {
        try
        {
            string query = "UPDATE patient SET Name='" + p.Name + "', Address='" + p.Address + "', Contact='" + p.ContactNo + "', Age=" + p.Age + ", Sex='" + p.Sex + "', MaritialStatus='" + p.MarialStatus + "', Occupation='" + p.Occupation + "', MedicalInfo='" + p.MedInfo + "' WHERE ID=" + id;
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public bool verifyPatient(string con, int id)
    {
        string query = "select * from patient where Contact='" + con + "' and ID=" + id.ToString();

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        if (c.dataSet.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    public DataSet getPatients()
    {
        string query = "select ID, Name, Address, Contact from patient";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public int getID(string contact)
    {
        string query = "select ID from patient where Contact = '" + contact + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return Convert.ToInt32(c.dataSet.Tables[0].Rows[0]["ID"]);
    }
}