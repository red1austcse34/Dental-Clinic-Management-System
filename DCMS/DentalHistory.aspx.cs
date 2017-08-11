using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DentalHistory : System.Web.UI.Page
{
    string name;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            tbName.Text = new PatientDAO().getName(id);
            DataSet D = new DataSet();
            D = new PaymentDAO().getHist(id);
            if (D != null)
            {
                if (D.Tables[0].Rows.Count != 0)
                {
                    Hist.DataSource = D;
                    Hist.DataBind();
                }
                else
                {
                    Hist.DataSource = null;
                    Hist.DataBind();
                }
            }
        }
    }
    protected void Ok_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
}