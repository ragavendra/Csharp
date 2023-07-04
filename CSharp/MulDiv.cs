using System;
					
public class Progr
{
	public static void Main_()
	{
		// Console.WriteLine("Hello World Multiply " + MultiplyPositiveNos(6, 9));
		
		Console.WriteLine("Hello World Divide " + DividePositiveNos(3, 33));

	}

	public static int MultiplyPositiveNos(int a, int b, int res = 0)
	{
		if(!(a >= 0) && !(b >= 0))
		{
			return 0;
		}

		if (a == 1)
		{
			// Console.WriteLine("A ");
			return b;
		}

		if (b == 1)
		{
			// Console.WriteLine("B ");
			// return a;
			
			if (res > 0)
			{
				return res;
			}
			else
			{
				return a;
			}
		}
		
		if (res == 0)
		{
			res = a;
		}

		var result = a + res;
		b--;

		// Console.WriteLine(result);
		return MultiplyPositiveNos(a, b, result); 
		//Console.WriteLine(result);
		//return result;
	}

	// abstract
	// lets say a by b or a / b, let a be greater 8, 2, 0
	public static int DividePositiveNos(int a, int b, int counter = 0)
	{
		if(a > b)
		{}
		else
		{
			//write swap swap(a, b){}
			Swap(ref a, ref b);
		}
		
		if(a == 0)
		{
			return 0;
		}
		
		if(b == 0)
		{
			// -1 for infinity
			return -1;
		}

		a = a - b;
		counter++;
		// b--;

		// Console.WriteLine(counter);
		if(a >= b)
		{
			return DividePositiveNos(a, b, counter);
		}
		
		return counter;
		//Console.WriteLine(result);
		//return result;
	}
	
	public static void Swap(ref int a, ref int b)
	{
		int c = b;
		b = a;
		a = c;
	}
}
