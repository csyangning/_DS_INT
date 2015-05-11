// 13. If there is a loop in a linked list, how to get the entry node of the loop? 
// The entry node is the first node in the loop from head of list. 

    internal class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public static ListNode GetMeetingNodes(ListNode header)
        {
            if (header == null)
            {
                return null;
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
                    return null;
                }

                if (slowPointer == fastPointer)
                {
                    return slowPointer;
                }
            }

            return null;
        }

        public static ListNode EntryOfLoop(ListNode header)
        {
            ListNode meetingNode = GetMeetingNodes(header);
            if (meetingNode == null)
            {
                return null;
            }

            ListNode fastPointer = header.Next;
            ListNode travelNode = meetingNode.Next;

            while (travelNode != meetingNode)
            {
                travelNode = travelNode.Next;
                fastPointer = fastPointer.Next;
            }


            ListNode slowPointer = header;

            while (slowPointer != fastPointer)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next;
            }

            return slowPointer;
        }
    }