using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
                        //  class to a template
namespace k164058_Q4
{

    class dynamicarray<T> // not inherited by any other class
    {

    public T[] arr
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
            this.arr = new T[this.capacity];
        }

         dynamicarray(int capacity )
        {
            this.capacity = capacity;
            this.size = 0;  //one question: Without this its giving me error and abbhi BHII
            arr = new T[this.capacity];  
            
        }
        

        //implementing.add's functionality ; 
         void add(T num)
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
         T get(int index)
         {
            // if (index > size || index < 0)   // shall I do index>capacity in place of size
              //   throw new IndexOutOfRangeException("ERROORRRR!");
                return this.arr[index];
         }


        int indexOf(T num)  //h) finds  element value specified by the argument 
        {
            for (int j = 0; j < size; j++)
            {
                if (num.Equals(this.arr[j]))
                {
                    return j;
                }
            }
            return -1;
         }


        public static void Main(string[] args)
        {

            try
            {
                dynamicarray<String> arr1 = new dynamicarray<String>();
                dynamicarray<int> arr2 = new dynamicarray<int>(26);
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



