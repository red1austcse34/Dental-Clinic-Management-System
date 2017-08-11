using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EarningsExpensesInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menu.aspx");
    }
    protected void Search_Click(object sender, EventArgs e)
    {
        string year = tbYear.Text;
        string month = "";

        if (ddlMonth.SelectedIndex == 0) month = "01";
        else if (ddlMonth.SelectedIndex == 1) month = "02";
        else if (ddlMonth.SelectedIndex == 2) month = "03";
        else if (ddlMonth.SelectedIndex == 3) month = "04";
        else if (ddlMonth.SelectedIndex == 4) month = "05";
        else if (ddlMonth.SelectedIndex == 5) month = "06";
        else if (ddlMonth.SelectedIndex == 6) month = "07";
        else if (ddlMonth.SelectedIndex == 7) month = "08";
        else if (ddlMonth.SelectedIndex == 8) month = "09";
        else if (ddlMonth.SelectedIndex == 9) month = "10";
        else if (ddlMonth.SelectedIndex == 10) month = "11";
        else if (ddlMonth.SelectedIndex == 11) month = "12";
        Response.Redirect("Earning.aspx?search=-" + month + "-" + year);

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}