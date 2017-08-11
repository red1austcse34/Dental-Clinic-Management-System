using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for MedicineDAO
/// </summary>
public class MedicineDAO
{
    Conect c = new Conect();
	public MedicineDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public DataSet getMedicine()
    {
        string query = "select * from Medicine";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public SqlDataReader getMedicineNames()
    {
        string query = "select Name from Medicine";
        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.DR = c.sqlComm.ExecuteReader();
        return c.DR;
    }

    public DataSet getMedicineInfo(string name)
    {
        string query = "select * from Medicine where Name ='" + name + "'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        return c.dataSet;
    }

    public bool update(MedicineDTO m)
    {
        string query = "update Medicine set Quantity="+ m.Quantity + ", Price=" + m.Price + ", Supplier='" + m.Supplier + "' where Name='" + m.Name + "'";
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

    public bool add(MedicineDTO m)
    {
        try
        {
            string query = "insert into Medicine (Name, Quantity, Price, Supplier) values ('" + m.Name + "'," + m.Quantity + ","+ m.Price +",'" + m.Supplier + "')";
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