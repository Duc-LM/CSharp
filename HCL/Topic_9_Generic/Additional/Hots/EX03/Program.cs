//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<StallCategory> list = new List<StallCategory>();
//        List<Stall> stallList = new List<Stall>();
//        Console.WriteLine("Enter the number of stalls");
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i=0; i<n;i++)
//        {
//            Console.WriteLine("Enter the stall name");
//            string nameStall = Console.ReadLine();
//            Console.WriteLine("Do you want to use last created category?(Y/N)");
//            string choice = Console.ReadLine();
//            if (choice == "N")
//            {
//                Console.WriteLine("Enter the category name");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter the category details");
//                string detail = Console.ReadLine();
//                list.Add(new StallCategory(name,detail));
//            }
//            Console.WriteLine("Enter the owner name");
//            string ownerName = Console.ReadLine();
//            stallList.Add(new Stall(nameStall, (StallCategory)list[list.Count - 1].Clone(),ownerName)) ;  
//        }
//        Console.WriteLine("Stall Details");
//        Console.WriteLine(String.Format("{0,-17} {1,-15} {2,-15}", "Stall", "Category", "Owner"));
//        foreach (Stall stall in stallList)
//            Console.WriteLine(stall.ToString());
//    }
//}

