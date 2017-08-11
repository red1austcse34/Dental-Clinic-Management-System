using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for PaymentDAO
/// </summary>
public class PaymentDAO
{
    Conect c = new Conect();
	public PaymentDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public bool pay(PaymentDTO p)
    {
        try
        {
            string query = "INSERT INTO " + p.Treatment + " (pID, dID, tooth, quantity, cost, date) values (" + p.PID + "," + p.DID + ",'" + p.Tooth + "'," + p.Quantity + "," + p.Cost + ",'" + p.Date + "')";
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public DataSet getEarn(string s)
    {
        SqlDataReader DR = new TreatmentDAO().getTreatments();
        string query = "";

        c.dataSet = new DataSet();
        while (DR.Read())
        {
            query = "select * from "+ DR[0].ToString() + " where date LIKE '%" + s + "'";
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlAdap = new SqlDataAdapter(c.sqlComm);
            c.sqlAdap.Fill(c.dataSet);
        }
        return c.dataSet;
    }

    public DataSet getHist(int id)
    {
        SqlDataReader DR = new TreatmentDAO().getTreatments();
        string query = "";

        c.dataSet = new DataSet();
        while (DR.Read())
        {
            query = "select dID, cost, date from " + DR[0].ToString() + " where pID=" + id;
            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlAdap = new SqlDataAdapter(c.sqlComm);
            c.sqlAdap.Fill(c.dataSet);
        }
        return c.dataSet;
    }
}