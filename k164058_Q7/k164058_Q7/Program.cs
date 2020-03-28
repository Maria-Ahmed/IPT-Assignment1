using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace k164058_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 quicksort = new Class1();
            int[] list = new int[5] { 99, 98, 92, 97, 95 };

            int totalElements = list.Length;

            Console.WriteLine("List before sorting:\n");

            Class1.printlist(list, totalElements);

            Class1.quicksort(list, 0, totalElements - 1);
            Console.WriteLine("After sorting:\n");

            Class1.printlist(list, totalElements);
        }
    }
}
