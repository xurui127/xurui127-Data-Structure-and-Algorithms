## Merge Sort 
- #### Summary
Merge Sort is an algorithm that uses recursion and divide and conquer. But the difference from the divide-and-conquer method is that the merge sort divides a set of sequences into 2 sub-sequences,and uses recursion to progressively split the two sets of sequences until they become independent and ordered sequences. Finally, after obtainning 2 sets of ordered sequences, the 2 sets of sequences are sorted and merged.  
- #### Processing
**Divide:** Divided all element sequences to be sorted into two subsequences <br> 
**Conquer:** Sort the two subsquences by using merrge sort<br>
**Combine:** Merge the two sorted subsquences into one sequence <br>
	
 |Merge Sort |
|:---------------------|
![Image text](https://raw.githubusercontent.com/xurui127/Data-Structure-and-Algorithms/branch1/Merge%20Sort/Image/MergeSort.png)

```cpp
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
```
```cpp
void MergeSort(int A[], int begin, int end) {
	if (begin < end)
	{
		int mid = (begin + end) / 2;
		MergeSort(A,begin,mid);
		MergeSort(A,mid+1,end);
		Merge(A,begin,mid,end);
	}
}
```
