using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Summary description for Conect
/// </summary>
public class Conect
{
    public string connString = "Data Source=.\\sqlexpress;Initial Catalog=dbA;Integrated Security=True;Pooling=False";

    public SqlConnection sqlConn;
    public SqlCommand sqlComm;
    public SqlDataAdapter sqlAdap;
    public DataSet dataSet;
    public SqlDataReader DR;
	public Conect()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}