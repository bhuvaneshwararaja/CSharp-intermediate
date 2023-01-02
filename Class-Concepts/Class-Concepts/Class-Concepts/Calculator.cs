using System;
namespace Class_Concepts
{
	public class Calculator
	{
		public Calculator()
		{
		}

		public int Add(params int[] a)
		{
			int sum = 0;
			foreach(var num in a)
			{
				sum += num;
			}
			return sum;
		}
	}
}

