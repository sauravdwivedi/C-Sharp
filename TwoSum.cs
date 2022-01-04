/** Write a method that checks if there is at least one pair of
 *  numbers in a list of numbers, which has sum equal to target. 
 *  Given arr = [1, 3, 4] and target = 5, result is true because 
 *  the pair (1,4) sums to 4.
 */
 
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TwoSumApplication {
  class Problem {
    public string TwoSum(List<int> listOfNums, int targetNum) {
      bool result = false;
    
      foreach (int p in listOfNums) {
        foreach (int q in listOfNums) {
          if ((p != q) && (p+q == targetNum)) {
            result = true;
          }
        }
      }
      
      if (result == true) {
        return "At least one pair has sum equal to target!";
      }
      else {
        return "No pair has sum equal to target!";
      }
    }
  }
   
  class TwoSum {
    public static void Main(string[] args) {
      Console.WriteLine("Enter list of integers (space separated e.g. '1 2 3'): ");
      List<int> listOfNums = Console.ReadLine().Trim().Split(" ").ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
      Console.WriteLine("Enter target integer: ");
      int targetNum = Convert.ToInt32(Console.ReadLine().Trim());
      Problem prob = new Problem();
      Console.WriteLine(prob.TwoSum(listOfNums, targetNum));
    }
  }
}
