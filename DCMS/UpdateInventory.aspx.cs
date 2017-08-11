using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

public partial class UpdateInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataReader DR = new MedicineDAO().getMedicineNames();
            while (DR.Read())
            {
                ddlName.Items.Add(DR[0].ToString());
            }
        }
    }
    protected void ddlName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void tbID_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Fetch_Click(object sender, EventArgs e)
    {
        string name = ddlName.SelectedValue.ToString();
        DataSet D = new MedicineDAO().getMedicineInfo(name);
        tbID.Text = D.Tables[0].Rows[0]["ID"].ToString();
        tbQuantity.Text = D.Tables[0].Rows[0]["Quantity"].ToString();
        tbPrice.Text = D.Tables[0].Rows[0]["Price"].ToString();
        tbSupplier.Text = D.Tables[0].Rows[0]["Supplier"].ToString();
    }
    protected void Confirm_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(tbID.Text);
        string name = ddlName.SelectedValue.ToString();
        int quantity = Convert.ToInt32(tbQuantity.Text);
        int price = Convert.ToInt32(tbPrice.Text);
        if(new MedicineDAO().update(new MedicineDTO(id, name, quantity, price, tbSupplier.Text)))
        {
            Response.Redirect("MedicineCenter.aspx");
        }
        else
        {
            MessageBox.Show("ERROR!!!");
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicineCenter.aspx");
    }
}