
/** A left rotation operation on an array shifts each of the array's
 *  elements 1 unit to the left. For example, if 2 left rotations are
 *  performed on array [1,2,3,4,5], then the array would become
 *  [3,4,5,1,2]. Note that the lowest index item moves to the highest
 *  index in a rotation. This is called a circular array.
 *
 *  Given an array a of n integers and a number, d, perform d left
 *  rotations on the array. Return the updated array to be printed
 *  as a single line of space-separated integers.
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LeftRotationApplication {
  class Problem {
    public List<int> oneLeftRot(List<int> a) {
      List<int> x = new List<int>();
      for (int j=0; j < a.Count; j++) {
        if (j < a.Count-1) {
          x.Add(a[j+1]);
        }
        else {
          x.Add(a[0]);
        }
      }
    return x;
    }
  }

  class LeftRotation {
    public static void Main(string[] args) {
      Console.WriteLine("Enter array of integers (space separated e.g. '1 2 3'): ");
      List<int> a = Console.ReadLine().Trim().Split(" ").ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
      Console.WriteLine("Enter no. of rotations: ");
      int d = Convert.ToInt32(Console.ReadLine().Trim());
      int c = 0;
      Problem prob = new Problem();
      while (c < d) {
        List<int> z = prob.oneLeftRot(a);
        c = c + 1;
        a = z;
      }
      Console.WriteLine($"Array after {d} left rotations: [{String.Join(", ", a)}]");
    }
  }
}
