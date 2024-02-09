using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo
{
    internal class SortingAlgorithm
    {
        public static void DisplayDataStructureElements(List<int> DataStructureToDisplay)
        {
            Console.Write("Displaying Sorted List: { ");
            foreach (var elements in DataStructureToDisplay)
            {
                Console.Write(Convert.ToString(elements) + " ,");
            }
            Console.WriteLine("Null }");
        }

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

        internal void DivdeDataStructure(List<int> sampleList)
        {
            throw new NotImplementedException();
        }
    }
    class MergeSort : SortingAlgorithm
    {
        public void DivdeDataStructure(List<int> DataStructureToSort)
        {
            if (DataStructureToSort.Count > 1)
            {
                int middleElement = DataStructureToSort.Count / 2;
                List<int> LeftHandSide = new List<int>(DataStructureToSort.Take(middleElement));
                List<int> RightHandSide = new List<int>(DataStructureToSort.Skip(middleElement));

                DivdeDataStructure(LeftHandSide);
                DivdeDataStructure(RightHandSide);

                MergeElements(DataStructureToSort, LeftHandSide, RightHandSide);
            }
        }
        public List<int> MergeElements(List<int> DataStructureToSort, List<int> LeftHandSide, List<int> RightHandSide)
        {
            int i = 0, j = 0, k = 0;
            while (i < LeftHandSide.Count() && j < RightHandSide.Count())
            {
                if (LeftHandSide[i] <= RightHandSide[j])
                {
                    DataStructureToSort[k] = LeftHandSide[i];
                    i++;
                }
                else
                {
                    DataStructureToSort[k] = RightHandSide[j];
                    j++;
                }
                k++;
            }

            while (i < LeftHandSide.Count())
            {
                DataStructureToSort[k] = LeftHandSide[i];
                i++;
                k++;
            }

            while (j < RightHandSide.Count())
            {
                DataStructureToSort[k] = RightHandSide[j];
                j++;
                k++;
            }
            return DataStructureToSort;
        }
    }
}