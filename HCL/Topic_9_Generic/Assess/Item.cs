using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Item : IComparable
{
    private string _name;
    private string _type;
    private string _vendor;
    private double _cost;

    public Item() { }

    public Item(string _name, string _type, string _vendor, double _cost)
    {
        this._name = _name;
        this._type = _type;
        this._vendor = _vendor;
        this._cost = _cost;
    }

    public string Name { get => _name; set => _name = value; }
    public string Type { get => _type; set => _type = value; }
    public string Vendor { get => _vendor; set => _vendor = value; }
    public double Cost { get => _cost; set => _cost = value; }

    public static void FilterByCost(IEnumerator<Item> e, double cost)
    {
        List<Item> list = new List<Item>();
        while (e.MoveNext())
            if (cost < e.Current.Cost)
                list.Add(e.Current);
        if (list.Count > 0)
        {
            
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,-15}", "Name", "Type", "Vendor", "Cost"));
            foreach (Item item in list)
                Console.WriteLine(item.ToString());
        }
        else
            Console.WriteLine("No items found");
    }

    public int CompareTo(object obj)
    {
        return this.Cost.CompareTo(((Item)obj).Cost);
    }

    public override string ToString()
    {
        //Fill your code here
        return String.Format("{0,-15} {1,-15} {2,-15} {3:0.0;-15}", Name, Type, Vendor, Cost);
    }



   
}