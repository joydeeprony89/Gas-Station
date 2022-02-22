using System;

namespace Gas_Station
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] gas = new int[] { 1, 2, 3, 4, 5 };
      int[] cost = new int[] { 3, 4, 5, 1, 2 };
      Solution s = new Solution();
      var result = s.CanCompleteCircuit(gas, cost);
    }
  }

  public class Solution
  {
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
      int sum = 0, position = 0, total = 0;
      for(int i = 0; i < gas.Length; i++)
      {
        sum = sum + gas[i] - cost[i];
        if (sum < 0)
        {
          total = total + sum;
          sum = 0;
          position = i + 1;
        }
      }

      total = total + sum;
      return total < 0 ? -1: position;
    }
  }
}
