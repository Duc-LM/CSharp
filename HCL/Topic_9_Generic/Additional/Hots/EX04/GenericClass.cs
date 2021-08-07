using System;
using System.Collections.Generic;

class GenericClass 
{
    public static void SumOfElements<T>(List<T> list)
    {
        T sum = default(T);
        foreach (T item in list)
            Console.WriteLine(item);
        for (int i = 0; i< list.Count;  i++)
        {
            dynamic a = list[i] ;
            sum += a;
        }
        Console.WriteLine("Sum is "+sum);
    }
}