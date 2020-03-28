using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace k164058_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // List <T>

            // For int
            Stopwatch intListWatch = new Stopwatch();
            intListWatch.Start();
            List<int> intList = new List<int>();

            for (int i = 0; i < 1000000; i++)
            {
                intList.Add(random.Next(1000));
            }
            intListWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to List<int> (ms): {0}", intListWatch.Elapsed.TotalMilliseconds);

            // For Decimal
            Stopwatch decListWatch = new Stopwatch();
            decListWatch.Start();
            List<Decimal> decimalList = new List<Decimal>();

            for (int i = 0; i < 1000000; i++)
            {
                decimalList.Add(random.Next(1000));
            }
            decListWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to List<Decimal> (ms): {0}", decListWatch.Elapsed.TotalMilliseconds);

            // For Boolean
            Stopwatch boolListWatch = new Stopwatch();
            boolListWatch.Start();
            List<Boolean> boolList = new List<Boolean>();

            for (int i = 0; i < 1000000; i++)
            {
                boolList.Add(false);
            }
            boolListWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to List<Boolean> (ms): {0}", boolListWatch.Elapsed.TotalMilliseconds);



            // Array
            // For int
            Stopwatch intArrWatch = new Stopwatch();
            intArrWatch.Start();
            int[] intArr = new int[1000000];

            for (int i = 0; i < 1000000; i++)
            {
                intArr[i] = random.Next(1000);
            }
            intArrWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to int[] (ms): {0}", intArrWatch.Elapsed.TotalMilliseconds);

            // For Decimal
            Stopwatch decArrWatch = new Stopwatch();
            decArrWatch.Start();
            Decimal[] decimalArr = new Decimal[1000000];

            for (int i = 0; i < 1000000; i++)
            {
                decimalArr[i] = random.Next(1000);
            }
            decArrWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to Decimal[] (ms): {0}", decArrWatch.Elapsed.TotalMilliseconds);

            // For Boolean
            Stopwatch boolArrWatch = new Stopwatch();
            boolArrWatch.Start();
            Boolean[] boolArr = new Boolean[1000000];

            for (int i = 0; i < 1000000; i++)
            {
                boolArr[i] = false;
            }
            boolArrWatch.Stop();
            Console.WriteLine("Time elapsed in adding 1000000 to Boolean[] (ms): {0}", boolArrWatch.Elapsed.TotalMilliseconds);

            Console.ReadKey();


        }
    }
}
