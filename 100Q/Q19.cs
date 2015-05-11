// 19. Translating Numbers to Strings

// Question: Given a number, please translate it to a string, following the rules: 1 is translated to 'a',
// 2 to 'b', …, 12 to 'l', …, 26 to 'z'. For example, the number 12258 can be translated to "abbeh", "aveh", 
// "abyh", "lbeh" and "lyh", so there are 5 different ways to translate 12258. How to write a function/method 
// to count the different ways to translate a number?

public static int GetTranslationCount(int number)
{
    if (number <= 0) { return 0; }

    string numberInString = number.ToString();
    return GetTranslationCount(numberInString);
}

private static int GetTranslationCount(string number)
{
    int length = number.Length;
    int[] counts = new int[length];

    for (int i = length - 1; i >= 0; --i)
    {

        int count = 0;
        if (number[i] >= '1' && number[i] <= '9')
        {

            if (i < length - 1)
            {
                count += counts[i + 1];
            }
            else
            {
                count += 1;
            }

        }

        if (i < length - 1)
        {
            int digit1 = number[i] - '0';
            int digit2 = number[i + 1] - '0';
            int converted = digit1 * 10 + digit2;
            if (converted >= 10 && converted <= 26)
            {
                if (i < length - 2)
                {
                    count += counts[i + 2];
                }
                else
                {
                    count += 1;
                }
            }
        }

        counts[i] = count;
    }

    return counts[0];
}