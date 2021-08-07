//using System;
//using System.Collections.Generic;

//class Program
//{
//    public static List<int> ConvertToList(string input)
//    {
//        List<int> list = new List<int>();
//        string[] splits = input.Split(',');
//        foreach (string item in splits)
//            list.Add(Convert.ToInt32(item));
//        return list;
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the count of booked tickets:");
//        Console.WriteLine("Day 1");
//        string day1 = Console.ReadLine();
//        Console.WriteLine("Day 2");
//        string day2 = Console.ReadLine();
//        Console.WriteLine("Day 3");
//        string day3 = Console.ReadLine();
//        Console.WriteLine("Day 4");
//        string day4 = Console.ReadLine();
//        Console.WriteLine("Day 5");
//        string day5 = Console.ReadLine();
//        List<List<int>> list = new List<List<int>>();
//        list.Add(ConvertToList(day1));
//        list.Add(ConvertToList(day2));
//        list.Add(ConvertToList(day3));
//        list.Add(ConvertToList(day4));
//        list.Add(ConvertToList(day5));
//        string choice = "yes";
//        while (choice == "yes")
//        {
//            Console.Write("Enter the day and show to know its remaining ticket count:");
//            int m = Convert.ToInt32(Console.ReadLine());
//            int n = Convert.ToInt32(Console.ReadLine());
//            if (m >= 1 && m <= 5 && n <= 4 && n >= 1)
//                Console.WriteLine("Remaining tickets:" + (100 - list[m - 1][n - 1]));
//            else
//                Console.WriteLine("Invalid input");
//            Console.WriteLine("Do you want to continue?(yes/no)");
//            choice = Console.ReadLine();
//        }
//    }
//}