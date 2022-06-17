public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
      int position = 0;
      int totalSum = 0; int currentSum = 0;
      
      for(int i = 0 ; i < gas.Length; i++) {
        currentSum = gas[i] - cost[i] + currentSum;
        if(currentSum < 0){
          // why position = i + 1 ?
          // as the currentSum = 0 for current index i, so we assume we might get the positive value in the next index i +1
          position = i + 1;
          totalSum += currentSum;
          currentSum = 0;
        }
      }
      totalSum += currentSum;  
      return totalSum < 0 ? -1 : position;
    }
}
