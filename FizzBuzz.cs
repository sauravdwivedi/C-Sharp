/** C sharp script to print "Fizz" if a number is divisible by 3, print 
 *  "Buzz" if a number is divisible by 5, and print "FizzBuzz" if a number 
 *  is divisible by both 3 and 5 for numbers in a given range.
 */
 
 using System;
 using System.IO;
 
 namespace FizzBuzzApplication {
   class FizzBuzz {
     public void FizzBuzzFun(int targetNum) {
       for (int x = 1; x < targetNum + 1; x++) {
         if ((x % 3 == 0) && (x % 5 == 0)) {
           Console.WriteLine("FizzBuzz");
         }
         else if (x % 3 == 0) {
           Console.WriteLine("Fizz");
         }
         else if (x % 5 == 0) {
           Console.WriteLine("Buzz");
         }
         else {
           Console.WriteLine(x);
         }
       }
     }
     
     public static void Main(string[] args) {
       FizzBuzz obj = new FizzBuzz();
       Console.WriteLine("Enter range of numbers: ");
       int targetNum = Convert.ToInt32(Console.ReadLine().Trim());
       obj.FizzBuzzFun(targetNum);
     }
   }
 }
       
