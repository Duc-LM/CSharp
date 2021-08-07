//using System;

//class Program
//{
//    public delegate T add<T>(T a, T b);

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Menu\n1.Add Integer\n2.Concatenate String");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        int a, b;
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("Enter the input a:");
//                a = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the input b:");
//                b = Convert.ToInt32(Console.ReadLine());
//                add<int> delegateA = new add<int>(Add);
//                Console.WriteLine(delegateA.Invoke(a, b));

//                break;
//            case 2:
//                Console.WriteLine("Enter the string s1:");
//                string s1 = Console.ReadLine();
//                Console.WriteLine("Enter the string s2:");
//                string s2 = Console.ReadLine();
//                add<string> delegateB = new add<string>(Concat);
//                Console.WriteLine(delegateB.Invoke(s1, s2));
//                break;
//        }
//        Console.ReadLine();


//    }

//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public static string Concat(string s1, string s2)
//    {
//        return s1 + s2;
//    }
//}
