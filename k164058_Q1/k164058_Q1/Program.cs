using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k164058_Q1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\FAST\Desktop\IPT_Assignment1\k164058_Q1\k164058_Q1\Q1Input.txt");
            while ((line = file.ReadLine()) != null)
            {
                String temp="";
                String [] separateString = line.Split(";");
                if (separateString[1] == "1;")
                {
                    temp = "full";
                    Console.WriteLine("1 means complete bandwidth");
                }
                else
                {
                    temp = "below full";
                    Console.WriteLine("0 means more users possible");
               
                }
            }

            file.Close();
        }
    }
}
