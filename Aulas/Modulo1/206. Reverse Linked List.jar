// https://leetcode.com/problems/reverse-linked-list/submissions/1433558049
/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
*/


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode reverseList(ListNode head) {
        ListNode it = head;
        ListNode prev = null;

        while (it != null) {
            ListNode temp = it;
            it = it.next;
            temp.next = prev;
            prev = temp;
        }

        return prev;
    }
}
