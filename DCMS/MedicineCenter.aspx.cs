using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MedicineCenter : System.Web.UI.Page
{
    DataSet d;
    protected void Page_Load(object sender, EventArgs e)
    {
        d = new MedicineDAO().getMedicine();
        if (d != null)
        {
            if (d.Tables[0].Rows.Count != 0)
            {
                Inventory.DataSource = d;
                Inventory.DataBind();
            }
            else
            {
                Inventory.DataSource = null;
                Inventory.DataBind();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateInventory.aspx");
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx");
    }
}