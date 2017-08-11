using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MedicineDTO
/// </summary>
public class MedicineDTO
{
    private int id, price, quantity;
    private string name, supplier;

    public string Supplier
    {
        get { return supplier; }
        set { supplier = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
	public MedicineDTO(int id, string name, int quantity, int price, string supplier)
	{
        this.id = id;
        this.name = name;
        this.quantity = quantity;
        this.price = price;
        this.supplier = supplier;
	}
}