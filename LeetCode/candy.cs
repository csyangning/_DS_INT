// https://leetcode.com/problems/candy/
// There are N children standing in a line. Each child is assigned a rating value.
// 
// You are giving candies to these children subjected to the following requirements:
// 
// Each child must have at least one candy.
// Children with a higher rating get more candies than their neighbors.
// What is the minimum candies you must give?

public class Solution {
    public int Candy(int[] ratings) {
        if(ratings == null)
        {
            return 0;
        }
        
        if(ratings.Length == 1)
        {
            return 1;
        }
 
        int[] counts = new int[ratings.Length];
        for(int i = 0; i < counts.Length; i++)
        {
            counts[i] = 1;
        }
        
        
        for(int i = 1; i < ratings.Length; i++)
        {
           if(ratings[i] > ratings[i-1])
           {
               counts[i] = counts[i-1] + 1;
           }
        }
        
        for(int i = ratings.Length - 1; i > 0; i --)
        {
            if(ratings[i-1] > ratings[i])
            {
                counts[i-1] = Math.Max(counts[i] + 1, counts[i-1]);
            }
        }
        
        int result = 0;
        foreach(int i in counts)
        {
            result += i;
        }
        
        return result;
    }
}