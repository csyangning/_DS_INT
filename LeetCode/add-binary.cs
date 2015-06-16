//  https://leetcode.com/problems/add-binary/
//  
//  Given two binary strings, return their sum (also a binary string).
//  
//  For example,
//  a = "11"
//  b = "1"
//  Return "100".

public class Solution {
    public string AddBinary(string a, string b) {
        int aL = a.Length - 1;
		int bL = b.Length - 1;
		string result = string.Empty;
		int c = 0;
		
		while(aL >= 0 || bL >= 0 || c != 0)
		{
			c += aL >= 0 ? a[aL--] - '0' : 0;
			c += bL >= 0 ? b[bL--] - '0' : 0;
			result = (c % 2).ToString() + result;
			c /= 2;
		}
		
		return result;
    }
}