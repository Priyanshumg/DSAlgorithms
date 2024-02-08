using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo
{
    internal class SearchingAlgorithms
    {
        public static int LinearSearch(List<int> DataStructure, int key)
        {
            foreach (int element in DataStructure)
            {
                if (DataStructure[element] == key)
                    return element;
            }
            return -1;
        }
    }
}
