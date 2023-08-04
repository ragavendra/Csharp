using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using Csharp;

// var arr_ = new int[] { 98, 87, 75, 66, 55, 33 };
public class SortingRunner
{
    public static void Main()
    {
        var rnd = new Random();
        var arr_ = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

        var mergeSort = new MergeSort(arr_);
        mergeSort.Split(0, arr_.Length - 1);

        // MergeSort();

        static double Root(double no, double rootOf)
        {
            return Math.Pow(no, 1 / rootOf);
        }

        // var rnd = new Random();
        int no = 6;

        do
        {
            double log = Math.Log(++no);

            // double pow = Math.Pow(Math.E, log);
            // double log = Math.Log10(++no);

            // Console.WriteLine(no + " " + log + " " + pow);
            Console.WriteLine(no + " " + log);
        }
        while (no < 100);


        // var arr_ = new int[] { 98, 87, 75, 66, 55, 33 };
        // var arr_ = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

        var quickSort = new QuickSort_();
        // var mergeSort = new MergeSort(arr_);
        // bool flag;
        // Action<int[], int, int> sort;

        Stopwatch stopWatch = new Stopwatch();
        Meter meter = new Meter("Sort");

        var counter = meter.CreateCounter<double>(
            name: "Algs",
            unit: "loops",
            description: "Time for each algs."
        );

        int times = 10;

        Console.WriteLine("Quick Merge - 6 elements");
        {

            PrintArray(arr_);

            RunSort(mergeSort.Split, arr_);

            PrintArray(arr_);

        }
        // while (true);
        void RunSort(Action<int, int> method, int[] array)
        {

            var arr = array;
            stopWatch.Start();
            method(0, arr.Length - 1);
            stopWatch.Stop();
            Console.Write(" " + stopWatch.Elapsed.TotalMilliseconds);
            counter.Add(stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();
            Console.WriteLine();

            CheckSorted(arr);

        }

        void CheckSorted(int[] arr)
        {
            int? prev = null;
            foreach (var item in arr)
            {
                if (prev != null)
                {
                    if (prev <= item)
                    { }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(prev + " is more than " + item);
                        // Console.BackgroundColor = ConsoleColor.
                        Console.ResetColor();
                    }

                }

                prev = item;
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