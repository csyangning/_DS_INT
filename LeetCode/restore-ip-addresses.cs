//  https://leetcode.com/problems/restore-ip-addresses/
//  
//  Given a string containing only digits, restore it by returning all possible valid IP address combinations.
//  
//  For example:
//  Given "25525511135",
//  
//  return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> result = new List<string>();

        if (!string.IsNullOrEmpty(s) && s.Length <= 12)
        {
            string currentPath = string.Empty;
            FindValidIpAddress(s, currentPath, result, 4);
        }

        return result;
    }

    private void FindValidIpAddress(string s, string currentPath, List<string> result, int remainingPart)
    {
        if (remainingPart == 1 && s.Length <=3 && IsValidIPBlock(s))
        {
            currentPath += s;
            result.Add(currentPath);
            return;
        }

        for (int i = 1; i <= 3 && i < s.Length; i++)
        {
            string currentBlock = s.Substring(0, i);

            if (IsValidIPBlock(currentBlock))
            {
                string remainingS = s.Substring(i);
                FindValidIpAddress(remainingS, string.Format("{0}{1}.", currentPath, currentBlock), result, remainingPart - 1);
            }
        }
    }
    
    private bool IsValidIPBlock(string s)
    {
        int num = int.Parse(s);
        
        if(s.Length == 1 && num >= 0)
        {
            return true;
        }
        else if(num <= 255 && num >= Math.Pow(10, s.Length - 1))
        {
            return true;
        }
        
        return false;
    }
}