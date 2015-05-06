#include <iostream>
#include "qSort.h"

using namespace std;

int quickSort(int arrayA[], int left, int right)
{
	int i = left;
	int j = right;
	int pivot = arrayA[(i + j) / 2];
	while (i < j)
	{
		while (arrayA[i] < pivot)
			++i;
		while (arrayA[j] > pivot)
			--j;
		if (i <= j)
		{
			swap(arrayA[i], arrayA[j]);
			++i;
			--j;
		}
	}
	if (i < right)
		quickSort(arrayA, i, right);

	if (left < j)
		quickSort(arrayA, left, j);
	return 0;
}