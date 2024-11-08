using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class QuickSort
    {
        public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j<= high; j++)
            {
                if (arr[j]<pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i+1, high);
            return i + 1;
        }

        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void Quicksort(int[] arr, int low, int high)
        {
            if (low<high)
            {
                int pi = partition(arr, low, high);
                Quicksort(arr, low, pi-1);
                Quicksort(arr, pi + 1, high);
            }
        }
    }
}
