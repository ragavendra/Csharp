using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

//namespace Csharp
{
//    public class Program
    {
//        public static void Main()
        {
            // MergeSort();

            var rnd = new Random();

            var quickSort = new QuickSort_();
            var mergeSort = new MergeSort();
            // bool flag;
            // Action<int[], int, int> sort;

            Meter meter = new Meter("Sort");

            var counter = meter.CreateCounter<double>(
                name: "Algs",
                unit: "loops",
                description: "Time for each algs."
            );

            Stopwatch stopWatch = new Stopwatch();

            int times = 10;

            Console.WriteLine("Quick Merge - 6 elements");

            /*
                     do
                     {
                        if(flag)
                        {
                            sort = quickSort.QuickSort;
                        }
                        else
                        {
                            sort = mergeSort.Split;
                        }
                     }
                     while(true);*/


            // do
            {

                // var arr = new int[] { 98, 87, 75, 66, 55, 33 };
                var arr_ = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

                // RunSort(quickSort.QuickSort, arr_);

                PrintArray(arr_);

                RunSort(mergeSort.Split, arr_);

                PrintArray(arr_);
/*
                var arr = arr_;

                stopWatch.Start();

                quickSort.QuickSort(arr, 0, arr.Length - 1);
                stopWatch.Stop();
                Console.Write(stopWatch.Elapsed.TotalMilliseconds);
                counter.Add(stopWatch.Elapsed.TotalMilliseconds);
                stopWatch.Reset();

                arr = null;

                arr = arr_;

                stopWatch.Start();
                mergeSort.Split(arr, 0, arr.Length - 1);
                stopWatch.Stop();
                Console.Write(" " + stopWatch.Elapsed.TotalMilliseconds);
                counter.Add(stopWatch.Elapsed.TotalMilliseconds);
                stopWatch.Reset();
                Console.WriteLine();
*/
                /*
                         if(Console.ReadKey().Key != null)
                         {
                            break;
                         }*/

            }
            // while (true);

            void RunSort(Action<int[], int, int> method, int[] array)
            {

                var arr = array;
                stopWatch.Start();
                method(arr, 0, arr.Length - 1);
                stopWatch.Stop();
                Console.Write(" " + stopWatch.Elapsed.TotalMilliseconds);
                counter.Add(stopWatch.Elapsed.TotalMilliseconds);
                stopWatch.Reset();
                Console.WriteLine();

                CheckSorted(arr);

/*
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }*/
            }

            void CheckSorted(int[] arr)
            {
                int? prev = null;
                foreach (var item in arr)
                {
                    if(prev != null)
                    {
                        if(prev <= item)
                        {}
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(prev + " is more than " + item);
                            // Console.BackgroundColor = ConsoleColor.
                            Console.ResetColor();
                        }

                    }

                    prev = item ;
                }
            }

            void PrintArray(int[] arr)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            }

            // while(times-- > 0);

            // Console.key
            /*
                     foreach (var item in arr)
                     {
                        Console.Write(item + " "); 
                     }*/

            // Task[] tasks = { quickSort.QuickSort, mergeSort.Split };

            // Parallel.ForEach(tasks, task => tas )
        }
    }
}