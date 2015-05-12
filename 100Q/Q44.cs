// Permutation
// Questions: Please print all permutations of a given string. For example, print “abc”, “acb”, “bac”,
// “bca”, “cab”, and “cba” when given the input string “abc”.

public static void Permutation(char[] s)
{
    if (s == null)
    {
        return;
    }

    PermutationCore(s, 0);
}

public static void PermutationCore(char[] s, int startIndex)
{
    if(startIndex == s.Length -1)
    {
        Console.WriteLine(s);
    }
    else
    {
        for(int i = startIndex; i < s.Length; i++)
        {
	        char tmp = s[startIndex];
	        s[startIndex] = s[i];
	        s[i] = tmp;
	
	        PermutationCore(s, startIndex + 1);
	
	        s[i] = s[startIndex]; 
	        s[startIndex] = tmp; 
        }
    }
}