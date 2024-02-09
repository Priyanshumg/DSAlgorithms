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
    }
}
