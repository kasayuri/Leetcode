// https://leetcode.com/problems/middle-of-the-linked-list/
/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
*/

/*
Estratégia: contar quantos elementos existem na lista. 
Iterar a lista até a metade e retornar o nó do meio
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


/*
Estratégia 2: a lebre e a tartaruga.
Criar um ponteiro para lista que anda de nó em nó (tartaruga) e outro que anda dois nós por vez (lebre). 
Quando o ponteiro lebre chegar no final da lista, o ponteiro tartaruga estará no meio.
*/
ListNode MiddleNode(ListNode head) {
  var rabbit = head;
  var turtle = head;
  while (rabbit != null && rabbit.next != null) {
    turtle = turtle.next;
    rabbit = rabbit.next.next;
  }
  
  return turtle;
}
