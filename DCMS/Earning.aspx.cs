using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Earning : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string search = Request.QueryString["search"];
        DataSet d = new PaymentDAO().getEarn(search);
        if (d != null)
        {
            if (d.Tables[0].Rows.Count != 0)
            {
                Earn.DataSource = d;
                Earn.DataBind();
            }
            else
            {
                Earn.DataSource = null;
                Earn.DataBind();
            }
        }
        int a = 0;
        for (int i = 0; i < d.Tables[0].Rows.Count; i++)
        {
            a = a + Convert.ToInt32(d.Tables[0].Rows[i]["cost"]);
        }
        Total.Text = a.ToString();
    }
    protected void Ok_Click(object sender, EventArgs e)
    {
        Response.Redirect("EarningsExpensesInfo.aspx");
    }
    protected void Earn_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}