//https://leetcode.com/problems/palindrome-linked-list/description/

//https://leetcode.com/problems/palindrome-linked-list/description/

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
 
 // .  .,   .   ,       ,
 // 1   2   3   4   5   6
    
 // .   .,  .   .,      ,       ,
 // 1   2   3   4   5   6   7
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null)
            return false;

        ListNode slow = head;
        ListNode fast = head;
        ListNode mid = head;

        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        mid = slow; //se par, considera o metade -1
        Stack<int> pilha = new Stack<int>();

        while(mid != null){
            pilha.Push(mid.val);
            mid = mid.next;
        }

        while (pilha.Any()){
            if (head.val != pilha.Pop()){
                return false;
            }
            head = head.next;
        }

        return true;
    }
}
