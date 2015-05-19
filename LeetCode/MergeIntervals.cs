// https://leetcode.com/problems/merge-intervals/
// 
// Given a collection of intervals, merge all overlapping intervals.
// 
// For example,
// Given [1,3],[2,6],[8,10],[15,18],
// return [1,6],[8,10],[15,18].

public class Solution
{
    public List<Interval> Merge(IList<Interval> intervals)
    {
        if (intervals == null)
        {
            return null;
        }

        List<Interval> result = new List<Interval>();

        if (intervals.Count == 0)
        {
            return result;
        }

        var sortedList = intervals.OrderBy(x => x.start).ToArray();

        int currentStart = sortedList[0].start;
        int currentEnd = sortedList[0].end;

        foreach (Interval interval in sortedList)
        {
            if (interval.end < currentEnd)
            {
                continue;
            }
            else if (interval.start <= currentEnd && interval.end >= currentEnd)
            {
                currentEnd = interval.end;
            }
            else
            {
                result.Add(new Interval(currentStart, currentEnd));
                currentStart = interval.start;
                currentEnd = interval.end;
            }
        }

        result.Add(new Interval(currentStart, currentEnd));

        return result;
    }
}


// This is alternative not so good answer:
public List<Interval> Merge(IList<Interval> intervals)
{
    int map = 0;

    foreach (Interval i in intervals)
    {
        for (int j = i.start; j <= i.end; j++)
        {
            int mask = 1 << j;
            map |= mask;
        }
    }

    List<Interval> result = new List<Interval>();
    int start = 0;
    int index = 0;

    while (map != 0)
    {
        int mask = 1 << index;

        if ((map & mask) > 0)
        {
            if (start == 0)
            {
                start = index;
            }
        }
        else
        {
            if (start != 0)
            {
                result.Add(new Interval(start, index - 1));
                start = 0;
            }
        }

        map &= ~mask;
        index++;
    }

    if (start != 0)
    {
        result.Add(new Interval(start, index - 1));
    }

    return result;
}