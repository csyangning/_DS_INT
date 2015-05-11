// 17. Left Rotation of String
// Problem: Left rotation of a string is to move some leading characters to its tail. Please implement a function to rotate a string.
// For example, if the input string is “abcdefg” and a number 2, the rotated result is “cdefgab”.

public static void ReverseString(char[] s, int left, int right)
{
    while (left < right)
    {
        char tmp = s[left];
        s[left] = s[right];
        s[right] = tmp;

        left++;
        right--;
    }
}

public static void LeftRotation(char[] orignalString, int rotationCount)
{
    if (orignalString == null)
    {
        return;
    }

    if (orignalString.Length <= rotationCount)
    {
        rotationCount = rotationCount % orignalString.Length;
    }

    ReverseString(orignalString, 0, rotationCount -1);
    ReverseString(orignalString, rotationCount, orignalString.Length - 1);
    ReverseString(orignalString, 0, orignalString.Length - 1);
}