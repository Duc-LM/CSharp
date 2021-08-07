//using System;
//using System.Collections;
//using System.Collections.Generic;

//public class Book
//{
//    string _title;
//    string _author;
//    int _noOfPages;
//    double _amount;
//    string _department;

//    public Book(string _title, string _author, int _noOfPages, double _amount, string _department)
//    {
//        this._title = _title;
//        this._author = _author;
//        this._noOfPages = _noOfPages;
//        this._amount = _amount;
//        this._department = _department;
//    }
//    public static ArrayList searchByDepartment(string searchDept, ArrayList bookList)
//    {
//        ArrayList al = new ArrayList();
//        foreach (Book book in bookList)
//            if (book._department == searchDept)
//                al.Add(book);
//        return al;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Title: {0}\nAuthor: {1}\nAmount: {2}\nPages: {3}\nDepartment: {4}",
//            this._title,this._author,this._amount,this._noOfPages,this._department);
//    }
//}
