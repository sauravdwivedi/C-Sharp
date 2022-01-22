/**It’s another day in the office, and you’re a mastermind of not doing 
 * any work yourself. Instead, you’ll go to your coworkers for “help,” 
 * but secretly have them do all the work.
 * 
 * You’ve determined that the more one of your coworkers helps you, the 
 * more annoyed they become. You’ve also been able to determine how much 
 * more annoyed a coworker gets everytime you ask them for help. At the 
 * beginning of the day, a coworker is initially a annoyed at you. That’s 
 * their annoyance level. Everytime you ask them for help though, they 
 * become d more annoyed at you – their annoyance level a increases 
 * by a constant amount d so that a += d.
 * 
 * You want to complete a project of h tasks solely with “help” from your 
 * coworkers, but you need to be careful not to annoy any of them too much.
 * 
 * What’s the best you can do?
 * 
 * The first line contains 2 integers h and c, where h is the number of 
 * times you have to ask for help to complete the project, and c denotes 
 * the number of coworkers you have. Each of the following c lines contains 
 * two positive integers a and d, representing a coworker whose initial 
 * annoyance level is a and who is getting more annoyed at you by an 
 * increase of d every time you ask them for help.
 * 
 * Output a single number, which is the maximum annoyance level any coworker 
 * has at you provided you use an optimal strategy to minimize this level.

Run: 

mcs AnnoyedCoworkers.cs

echo "4 4           
1 2
2 3
3 4
4 5" | mono AnnoyedCoworkers.exe

 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AnnoyedCoworkersApplication {
  class AnnoyedCoworkers {
    public int annoyanceLevel (
      List<List<int>> coworkers, 
      int numOfTasks, 
      int numOfCoworkers
      ) {
      List<int> annoyance = new List<int>();
      List<int> annoyanceLevels = new List<int>();
      foreach (List<int> worker in coworkers) {
        annoyance.Add(worker[0] + worker[1]);
        annoyanceLevels.Add(worker[0]);
      }
      for (int i=0; i<numOfTasks; i++) {
        int minIndex = annoyance.IndexOf(annoyance.Min());
        int increaseAnnoy = coworkers[minIndex][1];
        annoyanceLevels[minIndex] += increaseAnnoy;
        annoyance[minIndex] += increaseAnnoy;
      }
      return annoyanceLevels.Max();
    }
  
    public static void Main (string[] args) {
    string line;
    List<List<int>> lines = new List<List<int>>();
    while ((line = Console.ReadLine()) != null) {
      lines.Add(line.Trim().Split(" ").ToList()
      .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
    }
    int numOfTasks = lines[0][0];
    int numOfCoworkers = lines[0][1];
    List<List<int>> coworkers = new List<List<int>>(lines.Skip(1));
    AnnoyedCoworkers obj = new AnnoyedCoworkers();
    int result = obj.annoyanceLevel(coworkers, numOfTasks, numOfCoworkers);
    Console.WriteLine(result);
    }
  }
}
