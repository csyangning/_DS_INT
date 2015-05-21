// https://leetcode.com/problems/merge-k-sorted-lists/
// 
// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 
 public class Solution {
    public ListNode mergeKLists(List<ListNode> lists) {
        if (lists==null||lists.size()==0) return null;

        PriorityQueue<ListNode> queue= new PriorityQueue<ListNode>(lists.size(),new Comparator<ListNode>(){
            @Override
            public int compare(ListNode o1,ListNode o2){
                if (o1.val<o2.val)
                    return -1;
                else if (o1.val==o2.val)
                    return 0;
                else 
                    return 1;
            }
        });

        ListNode dummy = new ListNode(0);
        ListNode tail=dummy;

        for (ListNode node:lists)
            if (node!=null)
                queue.add(node);

        while (!queue.isEmpty()){
            tail.next=queue.poll();
            tail=tail.next;

            if (tail.next!=null)
                queue.add(tail.next);
        }
        return dummy.next;
    }
}
 
 ===============
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0)
        {
            return null;
        }
        
        if(lists.Length == 1 )
        {
            return lists[0];
        }
        
		ListNode root = new ListNode(0);
		ListNode travelNode = root;


        Array.Sort(lists, new ListNodeComparer());
        
		while(lists[0] != null)
		{
		    travelNode.next = lists[0];

		    int newValue = 0;

		    if (lists[0].next == null)
		    {
		        newValue = int.MaxValue;
		    }
		    else
		    {
		        newValue = lists[0].val;
		    }

            lists[0] = lists[0].next;


		    for (int j = 0, i = 1; i < lists.Length; i++, j++)
		    {
		        if (lists[i] == null || lists[i].val > newValue)
		        {
		            break;
		        }
		        else
		        {
		            ListNode tmp = lists[i];
		            lists[i] = lists[j];
		            lists[j] = tmp;
		        }
		    }
		}
		
		return root.next;
    }
}

    public class ListNodeComparer : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y)
        {
            if (x == null)
            {
                return 1;
            }
            else if (y == null)
            {
                return -1;
            }
            else
            {
                return x.val.CompareTo(y.val);
            }
        }
    }