## Bubble Sort

-------------------

- #### Summary
Bubble sort is to compare two adjacent elements in a sequence until the sorting is completed. 

- #### Processing(Default ascending order)


example: 

input = {5,3,2,9,7}
	
1.To compare two adjacent elements, if the previous element is larger than the next element, then exchange these two elements. {5,3} -> {3,5} 
	
2. Repeat the previous step for every two elements until the end of the round of sorting, and get the last element as the largest element. 
	
3. Repeat yje previous two steps, until there are no elements to compare. 
	

<center>

|Bubble Sort |Original : {5,3,2,9,7}|
|:---------------------| ---------------------|
|Round : i = 1              | Round : i = 2 |
|j = 1 : {__5__,__3__,2,9,7}| j = 1 : {__3__,__2__,5,7,9} |
|j = 2 : {3,__5__,__2__,9,7}| j = 2 :{2,__3__,__5__,7,9}|
|j = 3 : {3,2,__5__,__9__,7}| j = 3 :|2,
|j = 4:  {3,2,5,__9__,__7__}| j = 4 :|
|j = 5:  {3,2,5,7,9}        | j = 5 :|

</center>

```cpp
void BubbleSort(int A[], int size) {
	for (int i = 0; i < size; i++)
	{
		for (int j = i + 1; j < size; j++)
		{
			if (A[j] < A[i])
			{
				int temp = A[j];
				A[j] = A[i];
				A[i] = temp;
			}
		}
	}
}
```

		