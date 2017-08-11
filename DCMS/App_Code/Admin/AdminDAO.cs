using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Summary description for AdminDAO
/// </summary>
public class AdminDAO
{
    Conect c = new Conect();

	public AdminDAO()
	{
        c.sqlConn = new SqlConnection(c.connString);
        c.sqlConn.Open();
	}

    public bool verifyAdmin(string user, string pass)
    {
        string query = "select * from admin where username='"+user+"' and pass='"+pass+"'";

        c.sqlComm = new SqlCommand(query, c.sqlConn);
        c.sqlAdap = new SqlDataAdapter(c.sqlComm);

        c.dataSet = new DataSet();
        c.sqlAdap.Fill(c.dataSet);
        c.sqlConn.Close();
        //string s = dataSet.Tables[0].Rows[0][0].ToString();
        //string q = dataSet.Tables[0].Rows[0][1].ToString();
        //if (s.Equals(user) && q.Equals(pass)) return true;
        if (c.dataSet.Tables[0].Rows.Count > 0) return true;
        else return false;
    }

    public bool changePass(string user, string pass, string newpass)
    {
        if (this.verifyAdmin(user, pass))
        {
            c.sqlConn.Open();
            string query = "update admin set pass='"+newpass+"' where username='"+user+"'";

            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlAdap = new SqlDataAdapter(c.sqlComm);

            c.dataSet = new DataSet();
            c.sqlAdap.Fill(c.dataSet);
            c.sqlConn.Close();
            return true;
        }
        else return false;
    }

    public bool addAdmin(AdminDTO a)
    {
        try
        {
            string query = "insert into admin (username, pass) values ('" + a.USER + "','" + a.PASS + "')";

            c.sqlComm = new SqlCommand(query, c.sqlConn);
            c.sqlComm.ExecuteNonQuery();
            c.sqlConn.Close();
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
            return false;
        }
    }

}