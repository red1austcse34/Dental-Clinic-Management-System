using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DoctorDTO
/// </summary>
public class DoctorDTO
{
    private int docID, salary;
    private string name;
    private bool available;

    public bool Available
    {
        get { return available; }
        set { available = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public int DocID
    {
        get { return docID; }
        set { docID = value; }
    }

	public DoctorDTO(int docID, string name, int salary, bool available)
	{
        this.docID = docID;
        this.name = name;
        this.salary = salary;
        this.available = available;
	}
}