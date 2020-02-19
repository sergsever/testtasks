// cppTest.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

void reverseArray( int array[], int size)
{
	int maxindex = size - 1;
	for(int i = 0, j = maxindex; i < j; i++, --j)
	{
		int buff = array[j];
		array[j] = array[i];
		array[i] = buff;
	}
}

int fibonacci(int n)
{
	int res = n < 2 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
	return res;
}

void swap(int* pa, int* pb)
{
	*pa = *pa + *pb;
	*pb = *pb - *pa;
	*pb = -*pb;
	*pa = *pa - *pb;
}

int main()
{
	std::cout << "Hello Tests!\n";
	int arr[] = {1, 2, 3, 4, 5};
	int size = 5;
	int maxindex = size - 1;
	reverseArray(arr, size);
	
	for (int i = 0; i <= maxindex; ++i)
		std::cout << arr[i] << "," << std::endl;
	std::cout << "fobinacci 7: " << fibonacci(7) << std::endl;

	int a = 4, b = 5;
	swap(&a, &b);
	std::cout << "a: " << a << " b:" << b;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
