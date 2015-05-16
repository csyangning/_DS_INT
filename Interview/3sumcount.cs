    public class Solution
    {
        public int Count(int[] array, int target)
        {
            if (array == null)
            {
                return 0;
            }

            Array.Sort(array);

            int count = 0;


            for (int index1 = 0; index1 < array.Length - 2; index1++)
            {
                int index2 = index1 + 1;
                int index3 = array.Length - 1;

                while (index2 < index3)
                {
                    int sum = array[index1] + array[index2] + array[index3];

                    if (sum > target)
                    {
                        index3--;
                    }
                    else if (sum < target)
                    {
                        index2++;
                    }
                    else
                    {

                        // handle duplications
                        if (array[index2] == array[index2 + 1] || array[index3] == array[index3 - 1])
                        {
                            int originalIndex2 = index2;

                            while (index2 < index3)
                            {
                                count++;

                                while ((index2 + 1) < index3 && array[index2] == array[index2 + 1])
                                {
                                    count++;
                                    index2++;
                                }

                                index3--;

                                if (array[index3] == array[index3 + 1])
                                {
                                    index2 = originalIndex2;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            count++;
                            index3--;
                            index2++;
                        }
                    }
                }
            }

            return count;
        }
    }
     