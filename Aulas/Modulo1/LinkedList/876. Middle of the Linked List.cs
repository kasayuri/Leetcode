// https://leetcode.com/problems/middle-of-the-linked-list/
/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
*/

ListNode MiddleNode(ListNode head) {
  var count = 0;
  var it = head;
  
  while (it != null) {
    count ++;
    it = it.next;
  }
  
  var middle = count / 2;
  ListNode output = head;
  
  for (int i = 1; i <= middle; i++) {
    output = output.next;
  }

  return output;
}


ListNode MiddleNode(ListNode head) {
  var rabbit = head;
  var turtle = head;
  while (rabbit != null && rabbit.next != null) {
    turtle = turtle.next;
    rabbit = rabbit.next.next;
  }
  
  return turtle;
}
