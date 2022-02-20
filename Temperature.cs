/** Given mean temperatures on days, find out longest sequence of days with
 *  min and max mean temperature difference within 5 degrees. Example:
 *  Input:
 *  temperatures = [7, 12, 5, 3, 11, 6, 10, 2, 9]
 *  days = [0, 1, 2, 3, 4, 5, 6, 7, 8]
 *  Output:
 *  The sequence of days 4 to 6 has difference between maximum and minimum mean 
 *  temperatures within 5 degrees with length of sequence 2, which is longest. 
 */
 
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TemperatureApplication {
  class Temperature {
    private int maxInDay = 0;
    private int maxFinDay = 0;
    
    public void FindLongestSeq(int numDays, Dictionary<int, int> temDay) {
      int maxLenSeq = 0;
      for (int i = 0; i < numDays; i++) {
        int lenSeq = 0;
        int minTem = temDay[i];
        int maxTem = temDay[i];
        for (int j = i + 1; j < numDays; j++) {
          if (temDay[j] > maxTem) {
            maxTem = temDay[j];
          }
          if (temDay[j] < minTem) {
            minTem = temDay[j];
          }
          if (maxTem - minTem <= 5) {
            lenSeq = j - i;
            if (lenSeq > maxLenSeq) {
              maxLenSeq = lenSeq;
              this.maxInDay = i;
              this.maxFinDay = j;
            }
          } else {
            break;
          }
        }
      }
    }
    
    public int MaxInDay() {
      return this.maxInDay;
    }
    
    public int MaxFinDay() {
      return this.maxFinDay;
    }
    
    public static void Main(string[] args) {
    Console.WriteLine("Enter temperatures on days separated"
      + " by space (e.g. '7 12 5 3'): ");
    List<int> tempOnDay = Console.ReadLine().Trim().Split(" ").ToList().
      Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    int numDays = tempOnDay.Count;
    Dictionary<int, int> temDay = new Dictionary<int, int>();
    for (int i = 0; i < numDays; i++) {
      temDay.Add(i, tempOnDay[i]);
    } 
    Temperature obj = new Temperature();
    obj.FindLongestSeq(numDays, temDay);
    Console.WriteLine($"Initial day: {obj.MaxInDay()}");
    Console.WriteLine($"Final day: {obj.MaxFinDay()}");
    }
  }
}
