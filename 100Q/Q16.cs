// 16. First Character Appearing Only Once
// Problem: Implement a function to find the first character in a string which only appears once.
// For example: It returns ‘b’ when the input is “abaccdeff”.

public static char FirstCharAppearOnce(string inputString)
{
    if (inputString == null)
    {
        return '\0';
    }

    int[] hashTable = new int[256];

    foreach (char c in inputString)
    {
        hashTable[GetHashKey(c)]++;
    }

    foreach (char c in inputString)
    {
        if (hashTable[GetHashKey(c)] == 1)
        {
            return c;
        }
    }

    return '\0';
}

public static int GetHashKey(char c)
{
    return (int)c % 256;
}