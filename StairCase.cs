/** A staircase of size (say n = 5) is combination of white spaces and #:
 *
 *      #
 *     ##
 *    ###
 *   ####
 *  #####
 *
 *  where number of #'s at bottom is equal to n. Whrite a method to print
 *  a staircase for a given integer n as input.
 */
 
 
using System;
using System.IO;


namespace StairCaseApplication {
  class StairCase {
  
    public string PrintStairCase(int stairCaseSize) {
      string stairCase = "";
        
      for (int i = 1; i < stairCaseSize + 1; i++) {
      
        for (int j = 0; j < stairCaseSize - i; j++) {
          stairCase += " ";
        }
          
        for (int k = 0; k < i; k++) {
          stairCase += "#";
        }
          
        stairCase += "\n";
      }
        
      return stairCase;
    }
      
      
    public static void Main(string[] args) {
      StairCase obj = new StairCase();
      Console.WriteLine("Size of staircase: ");
      int stairCaseSize = Convert.ToInt32(Console.ReadLine().Trim());
      string result = obj.PrintStairCase(stairCaseSize);
      Console.WriteLine($"The staircase of size {stairCaseSize}!");
      Console.WriteLine(result);
    }
  }
}

