#include <iostream>
#include <array>
using namespace std;







// -------Bubble Sort-----------
//      Pseudocode
//
// BubbleSort(A)
// for i = 1 to A.Length-1
//     for j = A.Length downto i + 1 
//          if A[j] < A[j -1]
//            exchange A[j] with A[j -1]
//

void BubbleSort(int A[], int size) {
	for (int i = 0; i < size; i++)
	{
		for (int j = i + 1; j < size; j++)
		{
			cout << "Round == " << i << " A i == " << A[i] << "A j == " << A[j]<<endl;
		
			cout << endl;
			if (A[j] < A[i])
			{
				int temp = A[j];
				A[j] = A[i];
				A[i] = temp;
			}
		}
		for (int i = 0; i < size; i++)
		{
			cout << " Element" << i << " : " << A[i];
		}
	}
}
void PrintArray(int A[], int size) {
	for (int i = 0; i < size; i++)
	{
		cout << " Element " << i << " : " << A[i] << endl;
	}
	cout << endl;
}


int main()
{
	int A[10] = { 5,3,2,9,7,1,3,4,2,6 };

	cout << "Original Array : " << endl;
	PrintArray(A, 10);
	cout << endl;
	cout << "----------------------------------------" << endl;

	cout << "Array with Bubble Sort : " << endl;
	BubbleSort(A, 10);
	PrintArray(A, 10);
	cout << "----------Bubble Sort End----------------" << endl;
}