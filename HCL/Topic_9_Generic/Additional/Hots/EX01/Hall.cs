using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hall
{
    string _name;
    string _contactNumber;
    double _costPerDay;
    string _ownerName;

    public string name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }

    public string contactNumber
    {
        get
        {
            return this._contactNumber;
        }
        set
        {
            this._contactNumber = value;
        }
    }
    public double costPerDay
    {
        get
        {
            return this._costPerDay;
        }
        set
        {
            this._costPerDay = value;
        }
    }
    public string ownerName
    {
        get
        {
            return this._ownerName;
        }
        set
        {
            this._ownerName = value;
        }
    }

    public Hall(string _name, string _contactNumber, double _costPerDay, string _ownerName)
    {
        name = _name;
        contactNumber = _contactNumber;
        costPerDay = _costPerDay;
        ownerName = _ownerName;
    }
}
