using System;

namespace Quick Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rndArr = { 2,5,1,8,0,4,3,9,6,7};
            partition(rndArr, 0, 9);
            quickSort(rndArr, 0, 9);

            Console.Write("\n  Sorted array:  ");
            foreach(int value in rndArr)
            {
                Console.Write(value + " ");
            }           
            Console.ReadKey();
        }
        static int partition(int[] arr,int low, int high)
        {
            int pivot = arr[high]; //Select the last element as Pivot
            int i = low - 1;
            int temp = 0;
            // left of the pivot is smaller and right is greater
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }        
            temp = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = temp;
            return i + 1;
        }
        static void quickSort(int[] arr,int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);  // Quick sort the left  part
                quickSort(arr, pi + 1,high);  // Quick sort the right part
            }
        }
    }
}
// Retrieved from https://www.youtube.com/watch?v=PgBzjlCcFvc
