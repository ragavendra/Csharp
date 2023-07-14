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
    public static volatile int _counter;

    public int[] _array;

    public int[] _arrayCopy;

    public MergeSort(int[] arr)
    {
        _array = arr;
        _arrayCopy = new int[_array.Length];
        // _arrayCopy = arr;
    }

    public void Split(int l, int r)
    {
        // int[] arr_ = new int[_array.Length];
        _array.CopyTo(_arrayCopy, 0);

        Split_(_array, 0, _array.Length, _arrayCopy);
        // Split_(arr, l, r, arr_);
    }

    public void Split_(int[] arr, int l, int r, int[] arr_)
    {
        if ((r - l) <= 1)
        {
            return;
        }

        // int mid = l + (r - l) / 2;
        int mid = (l + r) / 2;
        // Console.WriteLine("Counter " + _counter++);

        Split_(arr_, l, mid, arr);
        Split_(arr_, mid, r, arr);

        // Console.WriteLine("l " + l + ", m " + mid + ", r " + r);
        Sort(arr, l, mid, r, arr_);

        // MergeSort_(arr, l, mid + 1, r);
        // PrintArray(arr);
    }

    void Sort(int[] arrA, int left, int mid, int right, int[] arrB)
    {

        int left_ = left;
        int mid_ = mid;

        for (int k = left; k < right; k++)
        {
            if (left_ < mid)
            {
                if (mid_ >= right || arrB[left_] <= arrB[mid_])
                {
                    arrA[k] = arrB[left_];
                    left_++;
                }
                else
                {
                    arrA[k] = arrB[mid_];
                    mid_++;
                }
            }
            else if(left_ == mid)
            {
                arrA[k] = arrB[mid_];
                mid_++;
            }
            else
            {
                Console.WriteLine("Should I be here!");
            }
        }

        // l = 0, m = 1, r = 3
        // Console.WriteLine($"l = {l} m = {m} r = {r}");

        /*
                if (l == m)
                { 
                    return;
                }*/

        /*
if((r - m) > 1)
{
    Split(arr, l, m);
}*/
/*

        if (((m - l) < 1) || ((r - m) < 1))
        {
            if (arr[l] <= arr[m])
            {
                if (arr[m] <= arr[r])
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
                }
            }

            if (l != m)
            {
                // swap
                if (arr[m] < arr[l])
                {
                    Swap(ref arr[l], ref arr[m]);
                }
            }
        }

        // if size of array greater than 1
        // if(((m - l) > 1) || ((r - m) > 1))
        {
            int k = m + 1;
            for (int i = 0; i < m; i++)
            {
                // Console.Write(arr[i] + "i ");
                for (int j = m; j <= r; j++)
                {
                    // Console.Write(arr[j] + "j ");
                    if (arr[i] < arr[j])
                    { }
                    else
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            // Split(arr, l, m);

            // Console.WriteLine();
            // PrintArray(arr);
        }*/

    }

    public void Swap(ref int x, ref int y)
    {
        int z = x;
        x = y;
        y = z;
        // Console.Write(++_counter + ". ");
    }

    void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }

    // }
}


public class MergeSort_
{
    public static volatile int _counter;

    // Merges two subarrays of []arr.
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two
        // subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temp arrays
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        // Copy data to temp arrays
        for (i = 0; i < n1; ++i)
        {
            L[i] = arr[l + i];
        }

        for (j = 0; j < n2; ++j)
        {
            R[j] = arr[m + 1 + j];
        }

        // Merge the temp arrays

        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;

        // Initial index of merged
        // subarray array
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements
        // of L[] if any
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        // Copy remaining elements
        // of R[] if any
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    // Main function that
    // sorts arr[l..r] using
    // merge()
    public void sort(int[] arr, int l, int r)
    {
        if (l < r)
        {


            // Console.Write(++_counter + " ");

            // Find the middle point
            int m = l + (r - l) / 2;

            // Sort first and second halves
            sort(arr, l, m);
            sort(arr, m + 1, r);

            // Merge the sorted halves
            merge(arr, l, m, r);
        }
    }
}
