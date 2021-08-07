using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class User
{
    private string _name;
    private string _city;
    private long _contactNumber;


    public static Dictionary<string, List<User>> d = new Dictionary<string, List<User>>();

    public User(string _name, string _city, long _contactNumber)
    {
        this._name = _name;
        this._city = _city;
        this._contactNumber = _contactNumber;
    }

    public static void Work(object c)
    {
        List<User> list = ((IEnumerable)c).Cast<User>().ToList();
        foreach (User user in list)
            if (d.ContainsKey(user._city))
            {
                if (!d[user._city].Contains(user))
                    d[user._city].Add(user);
            }
            else
            {
                d[user._city] = new List<User>();
                d[user._city].Add(user);
            }
        foreach (KeyValuePair<string, List<User>> key in d)
        {
            Console.WriteLine("{0} - {1}", key.Key, key.Value.Count);
        }
    }
}
