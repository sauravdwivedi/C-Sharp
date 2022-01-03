/** Consider the following version of Bubble Sort:
 *  for (int i = 0; i < n; i++) {
 *    for (int j = 0; j < n - 1; j++) {
 *      // Swap adjacent elements if they are in decreasing order
 *      if (a[j] > a[j + 1]) {
 *          swap(a[j], a[j + 1]);
 *      }
 *    }
 *  }
 *  Given an array of integers, sort the array in ascending order using
 *  the Bubble Sort algorithm above. Once sorted, print the following
 *  three lines:
 *
 *  Array is sorted in numSwaps swaps., where numSwaps is the number of
 *  swaps that took place.
 *
 *  First Element: firstElement, where firstElement is the first element
 *  in the sorted array.
 *
 *  Last Element: lastElement, where lastElement is the last element in
 *  the sorted array.
 *
 *  Hint: To complete this challenge, you must add a variable that keeps
 *  a running tally of all swaps that occur during execution.
 */
 
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BubbleSortApplication { 
  public class BubbleSort {
    public void BubbleSortFun(List<int> arrayInt) {
    /** Method to count number of swaps to sort the array */
      int numSwaps = 0;
      for (int i=0; i < arrayInt.Count; i++) {
        for (int j=0; j < arrayInt.Count-1; j++) {
          if (arrayInt[j] > arrayInt[j+1]) {
            int left = arrayInt[j];
            arrayInt[j] = arrayInt[j+1];
            arrayInt[j+1] = left;
            numSwaps += 1;
          }
        }
      }
      Console.WriteLine($"Sorted array: {String.Join(", ", arrayInt)}");
      Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
      Console.WriteLine($"First element: {arrayInt[0]}");
      Console.WriteLine($"Last element: {arrayInt[arrayInt.Count-1]}");
    }
  
    public static void Main(string[] args) {
      Console.WriteLine("Enter array of integers (space separated e.g. '1 2 3'): ");
      List<int> arrayInt = Console.ReadLine().Trim().Split(" ").ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
      Console.WriteLine($"Given array: {String.Join(", ", arrayInt)}");
      BubbleSort obj = new BubbleSort();
      obj.BubbleSortFun(arrayInt);
    }
  }
}
