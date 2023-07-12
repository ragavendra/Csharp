using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Console.WriteLine("Csharp project");

// MergeSort();

         var rnd = new Random();
         // var arr = new int[] { 98, 87, 75, 66, 55, 33 };
         var arr_ = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

         var quickSort = new QuickSort_();

         var arr = arr_;
         var resp = quickSort.QuickSort(arr, 0, arr.Length - 1);

/*
         foreach (var item in resp)
         {
            Console.Write(item + " "); 
         }*/
         arr = null;

         arr = arr_;

         var mergeSort = new MergeSort();
         mergeSort.Split(arr, 0, arr.Length - 1);
