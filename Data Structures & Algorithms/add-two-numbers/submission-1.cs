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

 //654
 //979
 //  3

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = null, tail = null;
        int carry = 0;
        while(l1 != null && l2 != null)
        {
            int sumDigits = l1.val + l2.val + carry;
            ListNode newNode = new ListNode(sumDigits%10);

            if(head == null && tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else{
                tail.next = newNode;
                tail = tail.next;
            }
            carry = sumDigits / 10;

            l1 = l1.next;
            l2 = l2.next;
        }

        if(l1 != null && l2 == null)
        {
            while(l1 != null)
            {
                ListNode newNode = new ListNode((l1.val + carry)%10);
                tail.next = newNode;
                tail = tail.next;
                carry = (carry + l1.val) / 10;
                l1 = l1.next;
            }
        }
        if(l2 != null && l1 == null)
        {
            while(l2 != null)
            {
                ListNode newNode = new ListNode((l2.val + carry)%10);
                tail.next = newNode;
                tail = tail.next;
                carry = (carry + l2.val) / 10;
                l2 = l2.next;
            }
        }

        if(carry > 0)
        {
            tail.next = new ListNode(carry);
            tail = tail.next;
        }

        return head;
    }
}
