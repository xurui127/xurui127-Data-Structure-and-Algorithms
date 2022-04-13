#include <iostream>
#include<array>
using namespace std;



// -------Merge-----------
//      Pseudocode
// 
// Merge(A,p,q,r)
// n1 = q-p+1
// n2 = r-q
// Let L[1..n1 + 1] and R[1..n2 + 1] be new arrays
// for i = 1 to n1 
//      L[i] = A[p + i + 1]
// for j = 1 to n2
//      R[j] = A[q + j]
// L[n1 + 1] = sentinel value 
// R[n2 + 1] = sentinel value 
// i = 1 
// j = 1
// for k = p to r
//      if L[i] <= R[j]
//          A[k] = L[i]
//          i = i + 1
//      else A[k] = R[j]
//          j = j + 1

/// <summary>
/// Divied  and merge subarrays
/// </summary>
/// <param name="A"> : Array To Sort</param>
/// <param name="left"> : First element of array</param>
/// <param name="mid"> : Middle element of array</param>
/// <param name="right"> : Last element of array</param>
void Merge(int A[], int left, int mid, int right) {
	int n1 = mid - left + 1;
	int n2 = right - mid;
	int* L = new int[n1+1];
	int* R = new int[n2+1];
	
	for (int i = 0; i < n1; i++)
	{
		L[i] = A[left +i];
	}
	for (int j = 0; j < n2; j++)
	{
		R[j] = A[mid + j + 1];
	}
	L[n1] = numeric_limits<int>::max();
	R[n2] = numeric_limits<int>::max();
	int x = 0;
	int y = 0;
	for (int k = left; k <= right; k++)
	{
		if (L[x] <= R[y])
		{
			A[k] = L[x];
			x++;
		}
		else
		{
			A[k] = R[y];
			y++;
		}
	}
 
}

// -------Merge Sort-----------
//         Pseudocode
// MergeSort(A,p,r)
// if p < r
//     q = (p + r) / 2
//     MergeSort(A,p,q)
//     MergeSort(A,q+1,r)
//     Merge(A,p,q,r)

/// <summary>
/// Sort and merge  two arrays
/// </summary>
/// <param name="A"> : Array To Sort</param>
/// <param name="begin"> : Start element of array</param>
/// <param name="end"> : End element of array</param>
void MergeSort(int A[], int begin, int end) {
	if (begin < end)
	{
		int mid = (begin + end) / 2;
		MergeSort(A,begin,mid);
		MergeSort(A,mid+1,end);
		Merge(A,begin,mid,end);
	}
}

/// <summary>
/// Print Array elements 
/// </summary>
/// <param name="A">: Array to be printed</param>
/// <param name="size"> : Printed array's size </param>
void PrintArray(int A[], int size) {
	for (int i = 0; i < size; i++)
	{
		cout << " Element " << i << " : " << A[i] <<endl;
	}
	cout << endl;
}
int main() 
{
	
	int A[6] = { 11, 1, 9,4,2,5 };

	cout << "Original Array : " << endl;
	PrintArray(A, 6);
	cout << endl;
	cout << "----------------------------------------" << endl;

	cout << "Array with Merge Sort : " << endl;
	MergeSort(A, 0, 6-1);
	PrintArray(A, 6);
	cout << "----------Merge Sort End----------------" << endl;

}