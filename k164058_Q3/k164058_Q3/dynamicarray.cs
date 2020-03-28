using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k164058_Q3
{
    class dynamicarray 
    {
        private int p;


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

        public dynamicarray(int capacity )
        {
            this.capacity = capacity;
            this.size = 0;  
            arr = new int[this.capacity];  
            
        }

         
        

        //implementing.add's functionality ; 
         public void add(int num)
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
         public int get(int index)
         {
             if (index > size || index < 0)   
                 throw new IndexOutOfRangeException("ERROORRRR!");
                return this.arr[index];
         }


        public int indexOf(int num)  //h) finds  element value specified by the argument 
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


        
    }
}

