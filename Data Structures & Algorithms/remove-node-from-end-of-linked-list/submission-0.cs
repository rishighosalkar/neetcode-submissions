/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head, slow = head;

        for(int i=0; i<n; i++)
            fast = fast.next;

        if(fast == null)
        {
            slow = slow.next;
            return slow;
        }
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        if(slow != null && slow.next != null)
            slow.next = slow.next.next;

        return head;
    }
}
