/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

boolean hasCycle(Node head) {
    int count = 1;
    
    while(count != 101)
    {
        if(head == null || head.next == null)
        {
            return false;
        }
        
        head = head.next;
        count++;
    }
    
    return true;
}
