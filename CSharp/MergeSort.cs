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

                Sort(arr, l, mid, r);
            }
        }

        void Sort(int[] arr, int l, int m, int r)
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

            int k;

            // from right first
            if (arr[r] < arr[m])
            {
                k = arr[m];
                arr[m] = arr[r];
                arr[r] = k;
            }

            // swap
            if (arr[m] < arr[l])
            {
                k = arr[l];
                arr[l] = arr[m];
                arr[m] = k;
            }

        }

/*        foreach (var item in ele)
        {
            Console.WriteLine($"Ele is - {item}");
        }*/

   // }
}

public class MergeSort_
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		//int[] arr = {38, 27, 43, 3, 9, 82, 10, 65};
		// int[] arr = {82, 11, 63, 41, 84, 44, 67, 62, 65, 17, 58, 30, 60, 47, 59, 3, 79, 35, 80, 74};
		
		var rnd = new Random();
         // var arr = new int[] { 98, 87, 75, 66, 55, 33 };
         var arr = new int[] { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100),
							  rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100),
							 rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100)};
		var now = DateTime.Now;
		
		//Console.WriteLine(DateTime.Now.ToString("hh:mm:ss:fffffff"));
		arr = div(arr);
		foreach(int ele in arr)
			Console.WriteLine(ele);
		//Thread.Sleep(1);
		//Console.WriteLine(DateTime.Now.ToString("hh:mm:ss:fffffff"));
		Console.WriteLine((DateTime.Now - now).ToString("fffffff"));

	}
	
	public static int[] div(int[] arr){
	
		int m = arr.Length/2;
		//int m = l+ (r-l)/2;
		int[] l = arr.Take(m).ToArray();
		int[] r = arr.Skip(m).ToArray();
		
		//arr has 1 ele, return it
		if((arr.Length <= 1))
		{
			//Console.WriteLine(1);
			return arr;
		}
		//div if arr has 2 or more eles
		else if(arr.Length >= 2)
		{
			//Console.WriteLine("l.Len = " + l.Length);
			//Console.WriteLine("r.Len = " + r.Length);
			//if(l.Length > 1)
				div(l);
			//if(r.Length > 1) if r is 2, then l is 1 
				div(r);
			//Console.WriteLine(3);
		}
		
		//Console.WriteLine("x");
		int[] res = mergeAndsort(l, r);
		
		//foreach(int ele in l)
			//foreach(int eler in r)
		
		return res;
	}
	
	public static int[] mergeAndsort(int[] l, int[] r){
	
		//merge arrays say if l has 2 and r has 1
		int[] res = new int[l.Length + r.Length];
		
		for(int i = 0; i < l.Length; i++){
			res[i] = l[i];
			//Console.WriteLine("l[i]: " + l[i]);
		}
		
		int j = 0;
		
		for(int i = l.Length; i < res.Length; i++){
			res[i] = r[j++];
			//Console.WriteLine("r[i]: " + r[j-1]);
		}
	
		res = sort(res);
		
		//div till ele is 1
		//int[] res = div(arr);
		return res;
	}
	
	public static int[] insert(int[] arr, out bool sorted){
		
		int i = 1;
		
		//from 1st ele and not 0th
		for(i = 1; i < arr.Length; i++){
			if(arr[i] < arr[i-1])
			{
				int temp = arr[i];
				arr[i] = arr[i-1];
				arr[i-1] = temp;
				break;
			}		
		}
		
		if(i == arr.Length)
			sorted = true;			
		else
			sorted = false;
		
		return arr;
	}
	
	public static int[] sort(int[] arr){
	
		//int[] arrNew = new int[arr.Length];
		int[] arra = new int[arr.Length];
		arra = arr;
		bool sorted = false;
		
		//for(int i = 0; i < 20; i++)//{
		do{
			insert(arr, out sorted);
		}while(!sorted);
					
		return arra;
	}
}
