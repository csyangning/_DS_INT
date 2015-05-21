// https://leetcode.com/problems/gas-station/
// 
// There are N gas stations along a circular route, where the amount of gas at station i is gas[i].
// 
// You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station (i+1). 
// You begin the journey with an empty tank at one of the gas stations.
// 
// Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.
// 
// Note:
// The solution is guaranteed to be unique.

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas == null || cost == null || gas.Length != cost.Length)
        {
            return -1;
        }

        int startIndex = -1;
        int currentGas = 0;
        int totalCost = 0;
        int totalGas = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            totalCost += cost[i];
            totalGas += gas[i];

            if (gas[i] >= cost[i] && currentGas ==0)
            {
                currentGas += gas[i] - cost[i];
                startIndex = i;
            }
            else if (gas[i] < cost[i] && (currentGas + gas[i] - cost[i]) < 0)
            {
                currentGas = 0;
            }
            else if (currentGas > 0)
            {
                currentGas += (gas[i] - cost[i]);
            }
            
        }

        if (totalCost > totalGas)
        {
            return -1;
        }
        else
        {
            return startIndex;
        }
    }
}