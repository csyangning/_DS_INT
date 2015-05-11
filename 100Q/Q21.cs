// 21. Intersection of Sorted Arrays
// Problem: Please implement a function which gets the intersection of two sorted arrays. Assuming numbers in each array are unique.
// For example, if the two sorted arrays as input are {1, 4, 7, 10, 13} and {1, 3, 5, 7, 9}, it returns an intersection array with numbers {1, 7}.


public static int[] FindIntersection(int[] array1, int[] array2)
{
    List<int> result = new List<int>();

    int i = 0;
    int j = 0;

    while (i < array1.Length && j < array2.Length)
    {
        if (array1[i] == array2[j])
        {
            result.Add(array1[i]);
            i++;
            j++;
        }
        else
        {
            if (array1[i] < array2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
    }

    return result.ToArray();
}

/*
Solution 2: With O(nlogm) Time

As we know, a binary search algorithm requires O(logm) time to find a number in an array with length m. Therefore, if we search each number of an array 
with length n from an array with lengthm, its overall time complexity is O(nlogm). If m is much greater than n, O(nlogm) is actually less than O(m+n).
 Therefore, we can implement a new and better solution based on binary search in such a situation.

*/