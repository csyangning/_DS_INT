// 14. Nodes in a list represent a number. For example, the nodes in Figure 1 (a) and (b) represent numbers 123 and 4567 respectively. 
// Please implement a function/method to add numbers in two lists, and store the sum into a new list.

    internal class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public static ListNode RevertList(ListNode header)
        {
            if (header == null)
            {
                return null;
            }
    
            ListNode preNode = null;
            ListNode currentNode = header;
            ListNode nextNode = currentNode.Next;
    
            while (nextNode != null)
            {
                currentNode.Next = preNode;
                preNode = currentNode;
                currentNode = nextNode;
                nextNode = nextNode.Next;
            }
    
            currentNode.Next = preNode;
    
            return currentNode;
        }

        public static ListNode Sum(ListNode node1, ListNode node2)
        {
            if(node1 == null || node2 == null)
            {
                return null;
            }
            
            ListNode revertedNodelist1 = RevertList(node1);
            ListNode revertedNodelist2 = RevertList(node2);
            ListNode resultHeader = null;
            ListNode resultTailer = null;
            int carryOver = 0;
            
            while(revertedNodelist1 != null || revertedNodelist2 != null)
            {
                int num1 = 0;
                int num2 = 0;
                
                if(revertedNodelist1 != null)
                {
                    num1 = revertedNodelist1.Value;
                    revertedNodelist1 = revertedNodelist1.Next;
                }
                
                if(revertedNodelist2 != null)
                {
                    num2 = revertedNodelist2.Value;
                    revertedNodelist2 = revertedNodelist2.Next;
                }
                
                int sum = num1 + num2 + carryOver;
                ListNode resultNode = new ListNode {Value = sum%10};
                
                if(sum >= 10)
                {
                    carryOver = 1;
                }
                else
                {
                    carryOver = 0;
                }
                
                if(resultHeader == null)
                {
                    resultHeader = resultNode;
                    resultTailer = resultHeader;
                }
                else
                {
                    resultTailer.Next = resultNode;
                    resultTailer = resultTailer.Next;
                }
            }
            
            return RevertList(resultHeader);
        }
    }