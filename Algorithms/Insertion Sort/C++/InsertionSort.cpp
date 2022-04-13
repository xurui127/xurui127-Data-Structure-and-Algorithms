


#include <iostream>
#include <array>
#include "InsertionSort.h"
using namespace std;

void InsertionSort(int a[],int length);

int main() {
	int b[] = { 9,8,3,2,5,9 };
	InsertionSort(b, 5);

	for (int i = 0;  i < 6; i++)
	{
		cout << b[i] ;
	}

}


// -------Insertion Sort-----------
//         Pseudocode
//  for j = 2 to A.length 
//       key = A[j]
//       i = j-1
//       while i > 0 and A[i]>key
//          A[i+1] = A[i]
//          i = i - 1
//       A[i+1] = key


void InsertionSort(int a[], int length)
{
	for (int i = 1; i <= length; i++) {
		int key = a[i];
		int j = i - 1;
		while (j >= 0 && a[j] > key) {
			a[j + 1] = a[j];
			j = j - 1;
		}	
		a[j + 1] = key;
	}
}
