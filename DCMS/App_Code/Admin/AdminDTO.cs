using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminDTO
/// </summary>
public class AdminDTO
{
    private string user="";
    private string pass="";
    public AdminDTO(string user, string pass)
    {
        this.user = user;
        this.pass = pass;
    }
        
    public string USER
    {
        get { return user; }
        set { user = value; }
    }

    public string PASS
    {
        get { return pass; }
        set { pass = value; }
    }
}