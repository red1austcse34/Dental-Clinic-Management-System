using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TreatmentDTO
/// </summary>
public class TreatmentDTO
{
    private string name;
    private int cost;

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

	public TreatmentDTO(string name, int cost)
	{
        this.name = name;
        this.cost = cost;
	}
}