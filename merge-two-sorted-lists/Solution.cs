// https://leetcode.com/problems/merge-two-sorted-lists

/**
 * DEFINITION FOR SINGLY-LINKED LIST.
 * PUBLIC CLASS LISTNODE {
 *     PUBLIC INT VAL;
 *     PUBLIC LISTNODE NEXT;
 *     PUBLIC LISTNODE(INT VAL=0, LISTNODE NEXT=NULL) {
 *         THIS.VAL = VAL;
 *         THIS.NEXT = NEXT;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var resultNode = new ListNode();
            var head = resultNode;
            var list1Pointer = list1;
            var list2Pointer = list2;

            while (list1Pointer != null && list2Pointer != null)
            {
                resultNode.next = new ListNode();
                resultNode = resultNode.next;

                if (list1Pointer.val < list2Pointer.val || list1Pointer.val == list2Pointer.val)
                {
                    resultNode.val = list1Pointer.val;
                    list1Pointer = list1Pointer.next;
                }
                else
                {
                    resultNode.val = list2Pointer.val;
                    list2Pointer = list2Pointer.next;
                }
            }

            while (list1Pointer != null)
            {
                resultNode.next = new ListNode();
                resultNode = resultNode.next;
                resultNode.val = list1Pointer.val;
                list1Pointer = list1Pointer.next;
            }

            while (list2Pointer != null)
            {
                resultNode.next = new ListNode();
                resultNode = resultNode.next;
                resultNode.val = list2Pointer.val;
                list2Pointer = list2Pointer.next;
            }

            return head.next;
    }
}