//using System;
//using System.Collections;

//delegate ArrayList FilterBook(string dept, ArrayList bookList);

//class Program
//{
//    static void Main(string[] args)
//    {
//        ArrayList bookList = new ArrayList();
//        int op;
//        string dept;
//        string[] deptArr;
   
//        do
//        {
//            Console.WriteLine("1)Add Books\n2)Display All Books\n3)Search By Department\n4)Exit\nSelect Option");
//            op = Convert.ToInt32(Console.ReadLine());
//            switch (op)
//            {
//                case 1:
//                    Console.WriteLine("Enter the book details");
//                    Console.WriteLine("Enter the book name");
//                    string name = Console.ReadLine();
//                    Console.WriteLine("Enter the author name");
//                    string author = Console.ReadLine();
//                    Console.WriteLine("Enter the price");
//                    double amount = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Enter the number of pages");
//                    int noOfPages = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("1)CSE\n2)IT\n3)ECE\n4)MECH\nSelect department");
//                    int op1 = Convert.ToInt32(Console.ReadLine());
//                    string deptName = "";
//                    if (op1 == 1)
//                        deptName = "CSE";
//                    else if (op1 == 2)
//                        deptName = "IT";
//                    else if (op1 == 3)
//                        deptName = "ECE";
//                    else if (op1 == 4)
//                        deptName = "MECH";
//                    Book b = new Book(name, author, noOfPages, amount, deptName);
//                    bookList.Add(b);
//                    break;
//                case 2:
//                    int i = 0;
//                    if (bookList.Count > 0)
//                    {
//                        foreach (Book book in bookList)
//                        {
//                            Console.WriteLine("Book " + (i + 1) + " Details");
//                            book.Display();
//                            i++;
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Book list is empty");
//                    }
//                    break;
//                case 3:
//                    Console.WriteLine("Enter the department");
//                    dept = Console.ReadLine();
//                    deptArr = dept.Split(',');
//                    i = 0;
//                    bool flag = false;
//                    ArrayList al = new ArrayList();
//                    FilterBook filter = new FilterBook(Book.searchByDepartment);
//                    foreach (string dp in deptArr)
//                        al.AddRange( filter.Invoke(dp, bookList));
//                    if (al.Count > 0)
//                    {
//                        Console.WriteLine("Books under selected department");
//                        foreach (Book book in al)
//                            book.Display();
//                    }
//                    else Console.WriteLine("No books available");
//                    break;
//            }
//        } while (op > 0 && op < 4);
//    }

//}

