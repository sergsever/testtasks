using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Threading;

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
			List<int> intlist = new List<int>();
			Object key = new object();
			int maxValue = 10000000;
			Random rnd = new Random();
			for (int i = 0; i < maxValue; ++i)
			{
				//				lock (key)
				//				{
				intlist.Add(rnd.Next(1, maxValue));
				//				}


			}
		}

		static Object key = new Object();
		static void Looping()
			{
				for(int i = 0; i < 100; ++i)
				{
				lock (key)
				{
					Debug.WriteLine("index:" + Thread.CurrentThread.Name + " i: " + i);
					Thread.Sleep(100);
				}
				}
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
				//			Collections();
				/*
							Stopwatch watch = new Stopwatch();

							Thread thread = new Thread(new ThreadStart(Collections));
							watch.Start();
							thread.Start();
							thread.Join();
							watch.Stop();
							Debug.WriteLine("Thread time: " + watch.ElapsedMilliseconds);
				*/
				Thread t1 = new Thread(new ThreadStart(Looping)), t2 = new Thread(new ThreadStart(Looping));
			t1.Name = "First";
			t2.Name = "Second";
				t1.Start();
				t2.Start();
				t1.Join();






		}
	}
}
