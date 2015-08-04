//  https://leetcode.com/problems/course-schedule/
//  
//  There are a total of n courses you have to take, labeled from 0 to n - 1.
//  
//  Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
//  
//  Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses? 
//  
//  For example:
//  2, [[1,0]]
//  
//  There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.
//  2, [[1,0],[0,1]]
//  
//  There are a total of 2 courses to take. To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.


public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
		
        Dictionary<int, List<int>> requirements = new Dictionary<int, List<int>>();
		
		for(int i = 0; i < prerequisites.GetLength(0); i++)
		{
			if (!requirements.ContainsKey(prerequisites[i][0])
			{
				requirements.Add(i, new List<int>());
			}
			
			requirements[i].Add(prerequisites[i][1]);
		}
		
		
			
    }
}