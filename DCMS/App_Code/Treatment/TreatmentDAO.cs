using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for TreatmentDAO
/// </summary>
public class TreatmentDAO
{
    Conect c = new Conect();
	public TreatmentDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public int getCost(string treatment)
    {
        int cost;
        string query = "select * from Treatment where Name ='" + treatment + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        cost = Convert.ToInt32(c.dataSet.Tables[0].Rows[0][1]);
        return cost;
    }

    public SqlDataReader getTreatments()
    {
        string query = "select Name from Treatment";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public bool addTreatment(TreatmentDTO t)
    {
        try
        {
            string query = "insert into Treatment (Name, Cost) values ('" + t.Name + "'," + t.Cost + ")";

            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();

            query = "CREATE TABLE " + t.Name + " (pID int, dID int, tooth varchar(50), quantity int, cost int, date varchar(50));";
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
}
