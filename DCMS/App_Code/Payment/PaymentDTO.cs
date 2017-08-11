using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PaymentDTO
/// </summary>
public class PaymentDTO
{
    string tooth = "", date = "", treatment = "";

    int pID, dID, quantity, cost;

    public string Treatment
    {
        get { return treatment; }
        set { treatment = value; }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public int DID
    {
        get { return dID; }
        set { dID = value; }
    }

    public int PID
    {
        get { return pID; }
        set { pID = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Tooth
    {
        get { return tooth; }
        set { tooth = value; }
    }
	public PaymentDTO(string pID, string dID, string treatment, string tooth, string numTooth, string cost)
	{
        this.pID = Convert.ToInt32(pID);
        this.dID = Convert.ToInt32(dID);
        this.treatment = treatment;
        this.tooth = tooth;
        this.quantity = Convert.ToInt32(numTooth);
        this.cost = Convert.ToInt32(cost);
        this.date = System.DateTime.Today.AddDays(0).ToString("dd-MM-yyyy");
	}
}