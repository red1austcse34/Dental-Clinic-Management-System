using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AppointmentDTO
/// </summary>
public class AppointmentDTO
{
    string date, time, name;
    int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Time
    {
        get { return time; }
        set { time = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }
    
	public AppointmentDTO(string name, string date)
	{
        this.name = name;
        this.date = date;
	}

    public AppointmentDTO(string name, string date, string time, int id)
    {
        this.name = name;
        this.date = date;
        this.time = time;
        this.id = id;
    }
}