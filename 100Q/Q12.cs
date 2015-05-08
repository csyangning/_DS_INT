// 12. How to check whether there is a loop in a linked list? For example, the list in Figure 1 has a loop.

    internal class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }


        public static bool IsLoopExist(ListNode header)
        {
            if (header == null)
            {
                return false;
            }

            ListNode slowPointer = header;
            ListNode fastPointer = header;

            while (slowPointer != null && fastPointer != null)
            {

                slowPointer = slowPointer.Next;
                if (fastPointer.Next != null)
                {
                    fastPointer = fastPointer.Next.Next;
                }
                else
                {
                    return false;
                }

                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }

            return false;
        }
    }