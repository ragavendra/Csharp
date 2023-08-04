#include <stdio.h>

void main(int args[])
{
    float a[] = { 21.13807101, 51, 17, 64, 87 };
    float b[] = { 21, 51, 17, 64, 87 };

    TopDownMergeSort(a, b, 5);

    for(int i = 0; i < 5; i++)
    {
        printf("hi %0.3f", a[i]);
    }
    
}

// Array A[] has the items to sort; array B[] is a work array.
void TopDownMergeSort(int A[], int B[],int n)
{
    CopyArray(A, 0, n, B);           // one time copy of A[] to B[]
    TopDownSplitMerge(A, 0, n, B);   // sort data from B[] into A[]
}

// Split A[] into 2 runs, sort both runs into B[], merge both runs from B[] to A[]
// iBegin is inclusive; iEnd is exclusive (A[iEnd] is not in the set).
void TopDownSplitMerge(int B[], int iBegin, int iEnd, int A[])
{
    if (iEnd - iBegin <= 1)                     // if run size == 1
        return;                                 //   consider it sorted
    // split the run longer than 1 item into halves
    int iMiddle = (iEnd + iBegin) / 2;              // iMiddle = mid point
    // recursively sort both runs from array A[] into B[]
    TopDownSplitMerge(A, iBegin,  iMiddle, B);  // sort the left  run
    TopDownSplitMerge(A, iMiddle,    iEnd, B);  // sort the right run
    // merge the resulting runs from array B[] into A[]
    TopDownMerge(B, iBegin, iMiddle, iEnd, A);
}

//  Left source half is A[ iBegin:iMiddle-1].
// Right source half is A[iMiddle:iEnd-1   ].
// Result is            B[ iBegin:iEnd-1   ].
void TopDownMerge(int B[], int iBegin, int iMiddle, int iEnd, int A[])
{
    int i = iBegin;
    int j = iMiddle;

    // While there are elements in the left or right runs...
    for (int k = iBegin; k < iEnd; k++) {
        // If left run head exists and is <= existing right run head.
        if (i < iMiddle && (j >= iEnd || A[i] <= A[j])) {
            B[k] = A[i];
            i = i + 1;
        } else {
            B[k] = A[j];
            j = j + 1;
        }
    }
}

void CopyArray(int A[] , int iBegin, int iEnd, int B[])
{
    for (int k = iBegin; k < iEnd; k++)
        B[k] = A[k];
}