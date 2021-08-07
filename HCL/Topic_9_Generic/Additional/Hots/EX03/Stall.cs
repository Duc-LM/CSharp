using System;

class Stall
{
    private string _name;
    private StallCategory _stallCategory;
    private string _owner;

    public Stall() { }

    public Stall(string _name, StallCategory _stallCategory, string _owner)
    {
        this._name = _name;
        this._stallCategory = _stallCategory;
        this._owner = _owner;
    }

    public string Name { get => _name; set => _name = value; }
    public string Owner { get => _owner; set => _owner = value; }
    public StallCategory StallCategory { get => _stallCategory; set => _stallCategory = value; }

    public override string ToString()
    {
        //Fill your code here
        return String.Format("{0,-17} {1,-15} {2,-15}", Name, StallCategory.Name, Owner);
    }
}
