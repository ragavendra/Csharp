using System.Threading.Tasks;
using System;

    public class QuickSort_
   {
      /// <summary>
      /// PE for the Perf Runner or Srvc.
      /// </summary>
      public async Task Main_(string[] args)
      {
         // var arr = new int[] { 10, 12, 24, 15, 8, 12 };
         var rnd = new Random();
         // var arr = new int[] { 98, 87, 75, 66, 55, 33 };
         var arr = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

         QuickSort(arr, 0, arr.Length - 1);

         foreach (var item in arr)
         {
            Console.Write(item + " "); 
         }
      }

      public static volatile int _counter;

      // last ele is pivot
      public void QuickSort(int[] array, int lowPos, int highPos)
      {
         if((highPos <= lowPos) || lowPos < 0)
         {
            return;
         }

         // int pivot = array[array.Length - 1];
         // int pivot = array[highPos];

         // if(array[0] < array[array.Length - 1 - 1])
         if(array[lowPos] < array[highPos])
         {}
         else
         {
            Swap(ref array[lowPos], ref array[highPos]);
         }

         if(array[lowPos] < array[highPos - 1])
         {}
         else
         {
            Swap(ref array[lowPos], ref array[highPos - 1]);
         }

         if(array[highPos - 1] < array[highPos])
         {}
         else
         {
            Swap(ref array[highPos - 1], ref array[highPos]);
         }

         QuickSort(array, lowPos, highPos - 1);
         QuickSort(array, highPos + 1, array.Length - 1);

         // return array;
      }

      public void Swap(ref int x, ref int y)
      {
         int z = x;
         x = y;
         y = z;

         // Console.Write(++_counter + ". ");

      }

   }
