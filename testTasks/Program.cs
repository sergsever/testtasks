using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace testTasks
{
	class Program
	{
		static void reverseArray(int[] array)
		{
			int maxindex = array.Length -1;
			for(int i = 0, j=maxindex; i < j; ++i, --j)
			{
				int buff = array[j];
				array[j] = array[i];
				array[i] = buff;
			}

		}

		static int Fibonacci(int n)
		{
			int res = n < 2 ? 1 : Fibonacci(n -1) + Fibonacci(n -2);
			return res;
		}

		static void SwapInt(ref int a, ref int b)
		{
			a = a + b;
			b = b -a;
			b = -b;
			a = a - b;
		}

		static void Collections()
		{
			ConcurrentBag<int> intlist = new ConcurrentBag<int>();

			Stopwatch watch = new Stopwatch();
			int maxValue = 10000000;
			watch.Reset();
			watch.Start();
			Random rnd = new Random();
			for(int i = 0; i < maxValue; ++i )
			{
				intlist.Add(rnd.Next(1, maxValue));
			}
			watch.Stop();
			Debug.WriteLine("time: " + watch.ElapsedMilliseconds);


		}

		static void Main(string[] args)
		{
			Debug.WriteLine("test tasks\n");
			/*
						int[] arr = new int[] { 1, 2,3,4,5};
						reverseArray(arr);
			*/
			//			Debug.WriteLine("Fib:" + Fibonacci(8));
			/*
						int a = 3, b = 5;
						SwapInt(ref a, ref b);
						Debug.WriteLine("a: " + a + " b: " + b);
			*/
			Collections();
		



		}
	}
}
