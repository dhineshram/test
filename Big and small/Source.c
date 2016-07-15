#include <stdio.h>


void main()
{
	printf("Enter the numbers: ");
	int arr[11], big = 0, small = 0, i;
	arr[0] = 0;
	for (i = 1; i < 11; i++)
	{
		scanf_s("%d", &arr[i]);
		if (arr[i] > big)
			big = arr[i];
		if (arr[i] < small)
			small = arr[i];
	}
	printf("Big is %d \nSmall is %d", big, small);
	getchar();
	//return 0;
}