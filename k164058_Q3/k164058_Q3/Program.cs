using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace k164058_Q3  //  C# array, ArrayList and List<int>
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int add = 0;
            //Console.WriteLine("Comparing!");

            // Adding items to Array List
            ArrayList arraylist = new ArrayList();
            Random populate = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                int randoms = populate.Next(1000000); // last overloaded form of function, 1value, givesless than1M
                arraylist.Add(randoms);               
                
            }

            // Adding items to Array
            int[] myArr = new int[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                int randoms = populate.Next(1000000); // last overloaded form of function, 1value, givesless than1M
                myArr[i]=randoms;
            }

            // Adding items to List
            List<int> myList = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                int randoms = populate.Next(1000000); // last overloaded form of function, 1value, givesless than1M
                myList.Add(randoms);
            }

            // Adding items to dynamicArray
            //
            dynamicarray DynamicArray = new dynamicarray(1000000);
            for (int i = 0; i < 1000000; i++)
            {
                int randoms = populate.Next(1000000); // last overloaded form of function, 1value, givesless than1M
                DynamicArray.add(randoms);
            }

            


            //////////////////////////////////////////////

            //b)


             // Calculating time to sum in ArrayList
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 1000000; i++)  //sum loop
            {
                add = add+ (int)arraylist[i]; 

            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds);
            Console.WriteLine("Time elapsed in adding 1000000 to Array List (ms): {0}", ts.TotalMilliseconds);
            //Console.WriteLine("Time required to carry out traversal in ArrayList" + elapsedTime);

            // Calculating time to sum in Array
            Stopwatch stopWatchArray = new Stopwatch();
            stopWatchArray.Start();
            int addArray = 0;
            for (int i = 0; i < 1000000; i++)  //sum loop
            {
                addArray += myArr[i];

            }
            stopWatchArray.Stop();
            TimeSpan tsArray = stopWatchArray.Elapsed;
           // string elapsedTimeArray = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsArray.Hours, tsArray.Minutes, tsArray.Seconds, tsArray.Milliseconds);
            //Console.WriteLine("Time required to carry out traversal in Array" + elapsedTimeArray);
            Console.WriteLine("Time elapsed in adding 1000000 to Array (ms): {0}", tsArray.TotalMilliseconds);

            // Calculating time to sum in List
            Stopwatch stopWatchList = new Stopwatch();
            stopWatchList.Start();
            int addList = 0;
            for (int i = 0; i < 1000000; i++)  //sum loop
            {
                addList += myList[i];

            }
            stopWatchList.Stop();
            TimeSpan tsList = stopWatchList.Elapsed;
            //string elapsedTimeList = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsList.Hours, tsList.Minutes, tsList.Seconds, tsList.Milliseconds);
            //Console.WriteLine("Time required to carry out traversal in List" + elapsedTimeList);
            Console.WriteLine("Time elapsed in adding 1000000 to List (ms): {0}", tsList.TotalMilliseconds);


            // Calculating time for Our own class
            Stopwatch dynamicStop = new Stopwatch();
            dynamicStop.Start();
            int dynamicList = 0;
            for (int i = 0; i < 1000000; i++)  //sum loop
            {
                dynamicList += DynamicArray.get(i);

            }
            dynamicStop.Stop();
            TimeSpan dynamicStopwatch = dynamicStop.Elapsed;
            //string elapsedTimeList = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", tsList.Hours, tsList.Minutes, tsList.Seconds, tsList.Milliseconds);
            //Console.WriteLine("Time required to carry out traversal in List" + elapsedTimeList);
            Console.WriteLine("Time elapsed in adding 1000000 to Dynamic Array (ms): {0}", dynamicStopwatch.TotalMilliseconds);



            //c) Search five randomly chosen values from each of the collection by calling the IndexOf() functio and compare response times.  
           // [1,5,6,9,88]
            int[] fiveRandoms = new int[5]; 
            for (int i = 0; i < 5; i++)
			{
			      
                    Random random = new Random();
                    fiveRandoms[i] = random.Next(0, 100000);  
			}




            // Calculating time for ArrayList
            Stopwatch m = new Stopwatch();
            m.Start();
            foreach(int randomValue in fiveRandoms){
                arraylist.IndexOf(randomValue);
            }
            m.Stop();
            var final_elapsed = m.Elapsed.TotalMilliseconds;
            Console.WriteLine("Time taken for ArrayList to search 5 randoms" + final_elapsed);
            // Calculating time for Array
            Stopwatch arrayRandomTime = new Stopwatch();
            arrayRandomTime.Start();
            foreach (int randomValue in fiveRandoms)
            {
                int temp = Array.IndexOf(myArr, randomValue); 
            }
            arrayRandomTime.Stop();
            var arrayRandom = arrayRandomTime.Elapsed.TotalMilliseconds;
            Console.WriteLine("Time taken for Array to search 5 randoms:" + arrayRandom);


            // Caclulating time for List
            Stopwatch listRandomTime = new Stopwatch();
            listRandomTime.Start();
            foreach (int randomValue in fiveRandoms)
            {
                myList.IndexOf(randomValue);
            }
            listRandomTime.Stop();
            var listRandom = listRandomTime.Elapsed.TotalMilliseconds;
            Console.WriteLine("Time taken for List to search 5 randoms:" + listRandom);

            // Caclulating time for DynamicList
            Stopwatch dynamicListRandomTime = new Stopwatch();
            dynamicListRandomTime.Start();
            foreach (int randomValue in fiveRandoms)
            {
                DynamicArray.indexOf(randomValue);
            }
            dynamicListRandomTime.Stop();
            var dynamicTime = dynamicListRandomTime.Elapsed.TotalMilliseconds;
            Console.WriteLine("Time taken for DynamicList to search 5 randoms:" + dynamicTime);


            Console.ReadKey();

           
            

            
        }
    }
}



//https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch.start?view=netframework-4.8