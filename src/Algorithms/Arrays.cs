using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;

public static class Arrays
{
    /// <summary>
    /// Returns the index of the value in the sorted array if it exists or -1 otherwise.
    /// </summary>
    public static int IterativeBinarySearch(int[] array, int value)
    {
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (high + low) / 2;
            int currValue = array[mid];

            if (currValue == value)
            {
                return mid;
            }
            else if (value < currValue)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }

    /// <summary>
    /// Returns the index of the value in the sorted array if it exists or -1 otherwise.
    /// </summary>
    public static int RecursiveBinarySearch(int[] array, int value)
    {
        static int Recurse(int[] array, int low, int high, int value)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = (low + high) / 2;
            int currValue = array[mid];

            if (currValue == value)
            {
                return mid;
            }
            else if (value < currValue)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }

            return Recurse(array, low, high, value);
        }
        
        int low = 0;
        int high = array.Length - 1;

        return Recurse(array, low, high, value);
    }
}
