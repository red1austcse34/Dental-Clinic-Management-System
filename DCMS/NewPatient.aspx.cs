using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class NewPatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Add_Click(object sender, EventArgs e)
    {
        string sex="";
        string marialStatus="";
        string occupation="";
        string medInfo = "";

        string name = tbName.Text;
        string address = tbAdress.Text;
        string contactNo = tbContactNo.Text;
        int age = Convert.ToInt32(tbAge.Text);

        if (ddlSex.SelectedIndex == 0) sex = "Male";
        else if (ddlSex.SelectedIndex == 1) sex = "Female";

        if (ddlMarialStatus.SelectedIndex == 0) marialStatus = "Married";
        else if (ddlMarialStatus.SelectedIndex == 1) marialStatus = "Unmarried";

        if (ddlOccupation.SelectedIndex == 0) occupation = "Job";
        else if (ddlOccupation.SelectedIndex == 1) occupation = "Business";
        else if (ddlOccupation.SelectedIndex == 2) occupation = "Student";
        else if (ddlOccupation.SelectedIndex == 3) occupation = "Housewife";
        else if (ddlOccupation.SelectedIndex == 4) occupation = "Retired";

        medInfo += ("Sensitivity To: "+ tbSensitivityTo.Text + "\n");

        //checkBox

        if (cbBadCondition.Checked == true) medInfo += "Bad Condition\n";

        if (cbGumBleeds.Checked == true) medInfo += "Gum Bleeding\n";

        if (cbToothLoose.Checked == true) medInfo += "Loose Tooth\n";

        if (cbChestPain.Checked == true) medInfo += "Chest Pain\n"; ;

        if (cbGumDisease.Checked == true) medInfo += "Gum Disease\n";

        if (cbBadBreath.Checked == true) medInfo += "Bad Breath\n";

        if (cbJawpain.Checked == true) medInfo += "Jaw Pain\n";

        if (cbBleedingTend.Checked == true) medInfo += "Bleeding Tendency\n";

        if (cbHepatitis.Checked == true) medInfo += "Hepatitis\n";

        if (cbHighBP.Checked == true) medInfo += "High BP\n";

        if (cbDiabetes.Checked == true) medInfo += "Diabetes\n";

        if (cbKidneyDisease.Checked == true) medInfo += "Kidney Disease\n";

        if (cbHeartTrouble.Checked == true) medInfo += "Heart Trouble\n";

        if (cbLiverDisease.Checked == true) medInfo += "Liver Disease\n";

        if (cbLungDisease.Checked == true) medInfo += "Lung Disease\n";

        if (cbAsthma.Checked == true) medInfo += "Asthma\n";

        if (cbRheumatic.Checked == true) medInfo += "Rheumatic Fever\n";

        if (cbAIDS.Checked == true) medInfo += "AIDS\n";

        if (cbAnemia.Checked == true) medInfo += "Amenia\n";

        if(tbAllergicTo.Text.Length>0)medInfo += "Allergic To: " + tbAllergicTo.Text + "\n";
        if (tbPregnant.Text.Length > 0) medInfo += "Pregnant of: " + tbPregnant.Text + "\n";
        if (tbMedicine.Text.Length > 0) medInfo += "Taking Medicine: " + tbMedicine.Text + "\n";

        if (new PatientDAO().createPatient(new PatientDTO(name, address, contactNo, age, sex, marialStatus, occupation, medInfo)))
        {
            int id = new PatientDAO().getID(contactNo);
            MessageBox.Show("Your ID is "+id);
            Response.Redirect("Home.aspx");
        }
        else Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Error!!!');</script>");
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void tbAllergicTo_TextChanged(object sender, EventArgs e)
    {

    }
    protected void tbAge_TextChanged(object sender, EventArgs e)
    {

    }
}