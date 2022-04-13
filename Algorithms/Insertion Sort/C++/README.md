## Insertion Sort 
- #### Summary
Insertion sort is that to compare and rearrange unordered elements by construct to an  ordered elements. By comparing the two elements from back to front, the elements are arranged into an ordered sequence. It is an algorithm for sorting a small number of elements.
- #### Processing(Default ascending order)
example: 
input = {4,3,2,1,5,6}
	1. Set second element as a start point. key = 3. 
	2. Contrast the starting element with the key element. Move the smaller element to the previous position.{3,4}
	3. Set key = 2 , compare the first two elements and move the smaller element to the first position.{2,3,4}
	4. the rest can be done in the same manner. 
	
 |Insertion Sort |
|:---------------------|

|Original : { 4, 3 , 2, 1 , 5 , 6 }|
|i = 1 : { **_3_** , **_4_** , 2 , 1 , 5 , 6 }|
|i = 2 : { **_2_** , **_3_** , **_4_** , 1 , 5 , 6 }|
|i = 3 : { **_1_** , **_2_** , **_3_** , **_4_** , 5 , 6 }|
|i = 4 :  { **_1_** , **_2_** , **_3_** , **_4_** , **_5_** , 6 }|
|i = 5 :  { **_1_** , **_2_** , **_3_** , **_4_** , **_5_** , **_6_** }|


```cpp
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
