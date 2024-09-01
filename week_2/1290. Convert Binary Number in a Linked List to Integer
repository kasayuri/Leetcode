// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/description/
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
    public int GetDecimalValue(ListNode head) {
        Double valorDecimal = 0;
        int contador = -1;
        ListNode aux = head;

        //Aux para contar a qtd de nodes
        while (aux != null) { 
            contador++;
            aux = aux.next;
        }

        while (head != null) { 
            valorDecimal += head.val * Math.Pow(2, contador);
            head = head.next;
            contador--;
        }

        return (int)valorDecimal;
    }
}
