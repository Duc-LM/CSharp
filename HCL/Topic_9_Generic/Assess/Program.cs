//using System;
//using System.Collections;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int choice;
//        List<Item> list = new List<Item>();
//        do
//        {
//            Console.WriteLine("Menu\n1.Add Item\n2.List all items\n3.Filter item by cost\n4.Exit");
//            choice = Convert.ToInt32(Console.ReadLine());
           
//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter the name");
//                    string name = Console.ReadLine();
//                    Console.WriteLine("Enter the type");
//                    string type = Console.ReadLine();
//                    Console.WriteLine("Enter the vendor");
//                    string vendor = Console.ReadLine();
//                    Console.WriteLine("Enter the cost");
//                    Double cost = Convert.ToDouble(Console.ReadLine());
//                    list.Add(new Item(name, type, vendor, cost));
//                    Console.WriteLine("Item added successfully");
//                    list.Sort();
//                    break;

//                case 3:
                    
//                    if (list.Count > 0)
//                    {
                       
//                        Console.WriteLine("Enter the cost to filter");
//                        double costFilter = Convert.ToInt64(Console.ReadLine());
//                        Item.FilterByCost(list.GetEnumerator(),costFilter);
//                    }
//                    else Console.WriteLine("No items to filter");
//                    break;

//                case 2:
                    
//                    if (list.Count > 0)
//                    {
                        
//                        Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-15} {3,-15}", "Name", "Type", "Vendor", "Cost"));
//                        foreach (Item item in list)
//                            Console.WriteLine(item.ToString());
//                    }
//                    else
//                        Console.WriteLine("No items to list");
//                    break;
//                case 4:
//                    Console.WriteLine("Bye!!");
//                    break;
//                default:
//                    Console.WriteLine("Invalid Input");
//                    break;

//            }
//        } while (choice >= 1 && choice < 4);
//    }
//}