using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k164058_Q2
{

    sealed class dynamicarray // not inherited by any other class
    {

        public int[] arr
        {
            get; set;
            }
        public int size
        {
            get; set;   
        }
        public int capacity 
        { get; set; }

        dynamicarray()  //Default
        {
            this.capacity = 10;
            this.size = 0;
            this.arr = new int[this.capacity];
        }

         dynamicarray(int capacity )
        {
            this.capacity = capacity;
            this.size = 0;  //one question: Without this its giving me error and abbhi BHII
            arr = new int[this.capacity];  
            
        }
        

        //implementing.add's functionality ; 
         void add(int num)
         {
             //more memory is allocated to extend the capacity of the array so, taking it in exception

             if (size == capacity)
             {
                 //Console.Read.
                 this.arr[size] = num;
                 capacity += 1;
                 size += 1;

             }
             else
             {
                 this.arr[size] = num;
                 size += 1;
             }
            
         } 




         //  g) returns element value of index specified by argument
         int get(int index)
         {
             if (index > size || index < 0)   // shall I do index>capacity in place of size
                 throw new IndexOutOfRangeException("ERROORRRR!");
                return this.arr[index];
         }


        int indexOf(int num)  //h) finds  element value specified by the argument 
        {
            for (int j = 0; j < size; j++)
            {
                if (this.arr[j] == num)
                {
                    return j;
                }
            }
            return -1;
         }


        static void Main(string[] args)
        {

            try
            {
                dynamicarray arr1 = new dynamicarray();
                dynamicarray arr2 = new dynamicarray(26);
                arr2.add(26); 

                Console.WriteLine(arr2.indexOf(26));
                
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);  
            }
            Console.ReadKey();
        }
    }
}








/*
Things to see in it:
-Appending an element at end of array
-constructor use
-exception handling

*/