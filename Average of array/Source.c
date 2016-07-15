#include <stdio.h>


void main()
{
	printf("Enter the numbers: ");
	int arr[10], i, sum = 0, count = 0;
	for (i = 0; i < 10; i++)
	{
		scanf_s("%d", &arr[i]);
		sum += arr[i];
		count++;
	}
	printf("Average is %d", sum/count);
	getchar();
	//return 0;
}