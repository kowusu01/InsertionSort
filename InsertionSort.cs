
using System;
public class MyInsertionSort
{
	
	public int[] Sort(int[] x, int iterationsToRun = -1)
	{
		Console.WriteLine("Inside Sort method.");
		if (x == null || x.Length < 1)
		{
			Console.WriteLine("Returning null due to list being empty.");
			return null;
		}
		else if (x.Length < 2)
		{
			Console.WriteLine("Returning same list due to list having only one item.");
			return x;
		}

		int count = 1;
		for (int j = 1; j < x.Length; j++)
		{
			
			int key = x[j];
			int i = j-1;
			Console.WriteLine("Executing iteration: " + j + " Key="+ key );// info
			while (i > -1 && x[i] > key)
			{
				x[i + 1] = x[i];
				i--;
			}
			x[i + 1] = key;

			/// CIRCUIT BREAKER
			if ((iterationsToRun > 0) && (count == iterationsToRun)) break;
            
			count++;
		}
		Console.WriteLine("Exiting Sort method.");
		return x;
	}
}
