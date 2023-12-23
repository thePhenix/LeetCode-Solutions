// https://leetcode.com/problems/add-two-numbers

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum;
            var reminder = 0;
            var head = new ListNode();
            var tail = head;

            while (l1 != null && l2 != null)
            {
                sum = l1.val + l2.val;
                sum += reminder;
                tail.val = sum % 10;
                
                reminder = sum / 10;

                l1 = l1.next;
                l2 = l2.next;
                if (l1 != null || l2 != null)
                {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }

            while (l1 != null)
            {
                sum = l1.val + reminder;
                reminder = sum / 10;

                tail.val = sum % 10;

                l1 = l1.next;
                if (l1 != null)
                {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }

            while (l2 != null)
            {
                sum = l2.val + reminder;
                reminder = sum / 10;

                tail.val = sum % 10;

                l2 = l2.next;
                if (l2 != null)
                {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }

            while (reminder != 0)
            {
                tail.next = new ListNode();
                tail = tail.next;
                tail.val = reminder % 10;
                reminder /= 10;
            }

            return head;
    }
}