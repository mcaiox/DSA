using System.Runtime.InteropServices;

public class DoublyLinkedListNode{
    public int val;
    public DoublyLinkedListNode? next;
    public DoublyLinkedListNode? prev;
    
    public DoublyLinkedListNode(int val) {
        this.val = val;
        next = null;
        prev = null;
    }
}

public class DoublyLinkedList{
    public DoublyLinkedListNode head;
    public DoublyLinkedListNode tail;

    public DoublyLinkedList(){
        head = new DoublyLinkedListNode(-1);
        tail = new DoublyLinkedListNode(-1);
        head.next = tail;
        tail.prev = head;
    }

    public void InsertFront(int val){
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(val);
        newNode.prev = head;
        newNode.next = head.next;

        head.next.prev = newNode;
        head.next = newNode;
    }

    public void InsertEnd(int val){
        DoublyLinkedListNode newNode = new DoublyLinkedListNode(val);
        newNode.next = tail;
        newNode.prev = tail.prev;

        tail.prev.next = newNode;
        tail.prev = newNode;
    }

    public void RemoveFront(){
        head.next.next.prev = head;
        head.next = head.next.next;
    }

    public void RemoveEnd(){
        tail.prev.prev.next = tail;
        tail.prev = tail.prev.prev;
    }

    public void Print(){
        DoublyLinkedListNode curr = head.next;
        while (curr != tail){
            Console.Write(curr.val + " -> ");
            curr = curr.next;
        }
        Console.WriteLine();
    }
}