using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PatientDTO
/// </summary>
public class PatientDTO
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string address;

    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    private string contactNo;

    public string ContactNo
    {
        get { return contactNo; }
        set { contactNo = value; }
    }
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private string sex;

    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    private string marialStatus;

    public string MarialStatus
    {
        get { return marialStatus; }
        set { marialStatus = value; }
    }
    private string occupation;

    public string Occupation
    {
        get { return occupation; }
        set { occupation = value; }
    }
    private string medInfo;

    public string MedInfo
    {
        get { return medInfo; }
        set { medInfo = value; }
    }

    public PatientDTO(string name, string address, string contactNo, int age, string sex, string marialStatus, string occupation, string medInfo)
    {
        this.name = name;
        this.address = address;
        this.contactNo = contactNo;
        this.age = age;
        this.sex = sex;
        this.marialStatus = marialStatus;
        this.occupation = occupation;
        this.medInfo = medInfo;
    }

}