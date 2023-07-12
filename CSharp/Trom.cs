using System;
using System.Linq;
using System.Threading;
					
public class MergeSort
{

    // void MergeSort_()
    // {
        // divide the array up until 1 or elements - recur
        // compare the ele and swap if necessary

        // int[] ele = { 6, 1, 7, 9, 24, 12, 10 };

        // Split(ele, 0, ele.Length - 1);

        public void Split(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = l + (r - l) / 2;

                Split(arr, l, mid);
                Split(arr, mid + 1, r);

                // Console.WriteLine("l " + l + ", m " + mid + ", r " + r);

                MergeSort_(arr, l, mid, r);
                MergeSort_(arr, l, mid + 1, r);
            }
        }

    void MergeSort_(int[] arr, int l, int m, int r)
    {
        // l = 0, m = 1, r = 3
        // Console.WriteLine($"l = {l} m = {m} r = {r}");

        /*
                if (l == m)
                { 
                    return;
                }*/

        if (arr[l] < arr[m])
        {
            if (arr[m] < arr[r])
            {
                // sorted set
                // Console.WriteLine("Should be rare!");
                return;
            }
        }

        // int k;

        if (m != r)
        {
            // from right first
            if (arr[r] < arr[m])
            {
                Swap(ref arr[m], ref arr[r]);
                /*
                k = arr[m];
                arr[m] = arr[r];
                arr[r] = k;*/
                // Console.WriteLine("m " + arr[m] + ", r " + arr[r]);
            }
        }

        if (l != m)
        {
            // swap
            if (arr[m] < arr[l])
            {
                Swap(ref arr[l], ref arr[m]);
                /*
                k = arr[l];
                arr[l] = arr[m];
                arr[m] = k;*/
                // Console.WriteLine("l " + arr[l] + ", m " + arr[m]);
            }
        }

    }

      public void Swap(ref int x, ref int y)
      {
         int z = x;
         x = y;
         y = z;
         // Console.Write(++_counter + ". ");
      }

   // }
}
