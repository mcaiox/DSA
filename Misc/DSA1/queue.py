class ListNode:
    def __init__(self, val):
        self.val = val
        self.next = None

class Queue:
    def __init__(self):
        self.head = None
        self.tail = None

    def enqueue(self, val):
        new_node = ListNode(val)
        if self.tail is None:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node

    def dequeue(self):
        if self.head is None:
            raise Exception("Queue is empty")
        val = self.head.val
        self.head = self.head.next
        return val

    def print(self):
        curr = self.head
        while curr is not None:
            print(curr.val, end=" ")
            curr = curr.next
        print()
