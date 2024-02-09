using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo
{
    internal class SortingAlgorithm
    {
        public void BubbleSort(List<int> DataStructureToSort)
        {
            int n = DataStructureToSort.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (DataStructureToSort[j] > DataStructureToSort[j + 1])
                    {
                        // Swap DataStructureToSort[j] and DataStructureToSort[j+1]
                        int temp = DataStructureToSort[j];
                        DataStructureToSort[j] = DataStructureToSort[j + 1];
                        DataStructureToSort[j + 1] = temp;
                    }
                }
            }
        }
        public void SelectionSort(List<int> DataStructureToSort)
        {
            int n = DataStructureToSort.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (DataStructureToSort[j] < DataStructureToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = DataStructureToSort[minIndex];
                DataStructureToSort[minIndex] = DataStructureToSort[i];
                DataStructureToSort[i] = temp;
            }
        }
        public void InsertionSort(List<int> DataStructureToSort)
        {
            int n = DataStructureToSort.Count;
            for (int i = 1; i < n; i++)
            {
                int key = DataStructureToSort[i];
                int j = i - 1;
                while (j >= 0 && DataStructureToSort[j] > key)
                {
                    DataStructureToSort[j + 1] = DataStructureToSort[j];
                    j = j - 1;
                }
                DataStructureToSort[j + 1] = key;
            }
        }
    }
}
