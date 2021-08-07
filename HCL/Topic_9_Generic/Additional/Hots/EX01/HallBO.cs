using System;
using System.Collections.Generic;

class HallBO
{
    public Hall CreateHall(string hallDetails)
    {
        string[] splits = hallDetails.Split(',');
       
        return new Hall(splits[0], splits[1], Convert.ToInt64(splits[2]), splits[3]);
    }
    public bool RemoveHallFromList(List<Hall> hallList, int index)
    {
        
        if (index-1 >= 0 && index-1 <= hallList.Count)
        {
            hallList.RemoveAt(index-1);
            return true;
        }
        return false;
           

    }
    public void DisplayHalls(List<Hall> hallList)
    {
        if (hallList.Count == 0)
            Console.WriteLine("");
        Console.WriteLine("{0}{1,15}{2,15}{3,15}", "Name", "Contact Number", "Cost per day", "Owner Name");
        foreach (Hall hall in hallList)
            Console.WriteLine("{0}{1,15}{2,15}{3,15}", hall.name, hall.contactNumber, hall.costPerDay, hall.ownerName);
    }
}