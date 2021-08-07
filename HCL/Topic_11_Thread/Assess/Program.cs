using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//class Program
//{
//    static void RUN(string[] args)
//    {
//        List<User> l = new List<User>();
//        Console.WriteLine("Enter the total number of users");
//        int count = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter user details");
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine("Enter name");
//            string userName = Console.ReadLine();
//            Console.WriteLine("Enter city");
//            string city = Console.ReadLine();
//            Console.WriteLine("Enter contactNumber");
//            long contactNo = Convert.ToInt64(Console.ReadLine());
//            l.Add(new User(userName, city, contactNo));

//        }
//        Thread t = new Thread(new ParameterizedThreadStart(User.Work));
//        t.Start(l);
//        Console.Read();
//            }
//}