using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo
{
    internal class SearchingAlgorithms
    {
        public int LinearSearch(List<int> DataStructure, int key)
        {
            foreach (int element in DataStructure)
            {
                if (DataStructure[element] == key)
                    return element;
            }
            return -1;
        }
        public int BinarySearch(List<int> DataStructure, int key)
        {
            int left = 0;
            int right = DataStructure.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (DataStructure[mid] == key)
                    return mid;

                // If target greater, ignore left half
                if (DataStructure[mid] < key)
                    left = mid + 1;
                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If we reach here, then the element was not present
            return -1;
        }
    }
}
