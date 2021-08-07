using System;
using System.Collections.Generic;

class StallCategory :ICloneable
{
    private string _name;
    private string _details;

    public StallCategory() { }

    public StallCategory(string _name, string _details)
    {
        this._name = _name;
        this._details = _details;
    }

    public string Name { get => _name; set => _name = value; }
    public string Details { get => _details; set => _details = value; }

    public object Clone()
    {    
        return (StallCategory)this.MemberwiseClone();
    }

}
