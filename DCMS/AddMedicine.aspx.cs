using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddMedicine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Confirm_Click(object sender, EventArgs e)
    {
        if (new MedicineDAO().add(new MedicineDTO(0, tbName.Text, Convert.ToInt32(tbQuantity.Text), Convert.ToInt32(tbPrice.Text), tbSupplier.Text)))
        {
            Response.Redirect("MedicineCenter.aspx");
        }
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("MedicineCenter.aspx");
    }
}