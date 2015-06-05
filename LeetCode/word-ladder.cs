// https://leetcode.com/problems/word-ladder/
// Given two words (beginWord and endWord), and a dictionary, find the length of shortest transformation sequence from beginWord to endWord, such that:
// 
// Only one letter can be changed at a time
// Each intermediate word must exist in the dictionary
// For example,
// 
// Given:
// start = "hit"
// end = "cog"
// dict = ["hot","dot","dog","lot","log"]
// As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
// return its length 5.


public class Solution
    {
        public int LadderLength(string beginWord, string endWord, ISet<string> wordDict)
        {
            if (!wordDict.Contains(endWord))
            {
                wordDict.Add(endWord);
            }

            int stepCount = 1;
            Stack<string> stack = new Stack<string>();
            stack.Push(beginWord);

            while (stack.Count != 0)
            {
                List<string> currentNodes = new List<string>();
                while (stack.Count != 0)
                {
                    string node = stack.Pop();

                    if (node == endWord)
                    {
                        return stepCount;
                    }

                    currentNodes.Add(node);
                }

                foreach (string node in currentNodes)
                {
                    foreach (string s in FindDistanceOne(node, wordDict))
                    {
                        stack.Push(s);
                        wordDict.Remove(s);
                    }
                }

                stepCount++;
            }

            return 0;
        }

        private List<string> FindDistanceOne(string target, ISet<string> strings)
        {
            List<string> result = new List<string>();

            foreach (string word in strings)
            {
                int diffCount = 0;
                for (int i = 0; i < target.Length; i++)
                {
                    if (target[i] != word[i])
                    {
                        diffCount++;
                        if (diffCount > 1)
                        {
                            break;
                        }
                    }
                }

                if (diffCount == 1)
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }

// if all word is of small length
public class Solution
    {
       public int LadderLength(string beginWord, string endWord, ISet<string> wordDict)
        {
            if (!wordDict.Contains(endWord))
            {
                wordDict.Add(endWord);
            }

            int stepCount = 1;
            Stack<string> stack = new Stack<string>();
            stack.Push(beginWord);

            while (stack.Count != 0)
            {
                List<string> currentNodes = new List<string>();
                while (stack.Count != 0)
                {
                    string node = stack.Pop();

                    if (node == endWord)
                    {
                        return stepCount;
                    }

                    currentNodes.Add(node);
                }

                foreach (string node in currentNodes)
                {
                    for (int i = 0; i < node.Length; i++)
                    {
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            string s = node.Substring(0, i) + c + node.Substring(i + 1, beginWord.Length - i - 1);
                            if (wordDict.Contains(s))
                            {
                                stack.Push(s);
                                wordDict.Remove(s);
                            }
                        }
                    }
                }

                stepCount++;
            }

            return 0;
        }
    }