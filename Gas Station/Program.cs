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
      // We will have a answer only if total of cost <= gas
      int position = -1;
      int costSum = Sum(cost);
      int gasSum = Sum(gas);
      // if total cost gthan total available fuel
      if (costSum > gasSum) return position;
      int total = 0;
      //start from index 0
      position = 0;
      for (int i = 0; i < gas.Length; i++)
      {
        // if total went below 0 which means we can have a solution from the current index.
        total = total + gas[i] - cost[i];
        if (total < 0)
        {
          // reset the total and start position.
          // position would be the next as the current posiiton does not have a solution
          position = i + 1;
          // reset total also to 0
          total = 0;
        }
      }

      return position;
    }

    int Sum(int[] arr)
    {
      int sum = 0;
      foreach (int i in arr)
        sum += i;

      return sum;
    }
  }
}
