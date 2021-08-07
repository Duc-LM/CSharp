//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        HashSet<string> hashList = new HashSet<string>();
//        for(int i = 0; i< n; i++)
//        {
//            string input = Console.ReadLine();
            
//            if (!hashList.Contains(input) && input != null)
//                 hashList.Add(input);

//        }
//        if (hashList.Contains(" ")) hashList.Remove(" ");
//        Console.WriteLine("Total number of unique of users " + hashList.Count);
//        Console.Read();
//    }
//}
