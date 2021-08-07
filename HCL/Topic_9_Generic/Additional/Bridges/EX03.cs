//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<string, int> list = new Dictionary<string, int>();
//        Console.WriteLine("Enter Count of Records");
//        int n = Convert.ToInt32(Console.ReadLine());
//        for(int i=0;i<n;i++)
//        {
//            string input = Console.ReadLine();
//            string[] splits = input.Split(',');
//            if (list.ContainsKey(splits[1]))
//                list[splits[1]]++;
//            else list[splits[1]] = 0;
//        }
//        foreach (KeyValuePair<string, int> item in list)
//            Console.WriteLine(item.Key+" "+item.Value);
//    }
//}
