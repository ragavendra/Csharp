using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Console.WriteLine("Csharp project");

MergeSort();

void MergeSort()
{
    // divide the array up until 1 or elements - recur
    // compare the ele and swap if necessary

    int[] ele = { 6, 1, 7, 9, 24, 12, 10 };

    Split(ele, 0, ele.Length -  1);

    void Split(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int mid = l + (r - l) / 2;

            Split(arr, l, mid);
            Split(arr, mid + 1, r);

            Sort(arr, l, mid, r);
        }
    }

    void Sort(int[] arr, int l, int m, int r)
    {
        // l = 0, m = 1, r = 3
        Console.WriteLine($"l = {l} m = {m} r = {r}");

/*
        if (l == m)
        { 
            return;
        }*/

        if (arr[l] < arr[m])
        {
            if(arr[m] < arr[r])
            {
                // sorted set
                Console.WriteLine("Should be rare!");
                return;
            }
        }

        int k;

        // from right first
        if(arr[r] < arr[m])
        {
            k = arr[m];
            arr[m] = arr[r];
            arr[r] = k;
        }

        // swap
        if(arr[m] < arr[l])
        {
            k = arr[l];
            arr[l] = arr[m];
            arr[m] = k;
        }

    }

    foreach (var item in ele)
    {
       Console.WriteLine($"Ele is - {item}");
    }

}