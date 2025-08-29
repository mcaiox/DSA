class ListNode{
    public int val;
    public ListNode next;
    public ListNode(int val){
        this.val = val;
        this.next = null;
    }
}

class Queue{
    private ListNode head;
    private ListNode tail;

    public Queue(){
        this.head = null;
        this.tail = null;
    }

    public void Enqueue(int val){
        ListNode newNode = new ListNode(val);
        if(this.tail == null){
            this.head = newNode;
            this.tail = newNode;
        }else{
            this.tail.next = newNode;
            this.tail = newNode;
        }   
    }

    public int Dequeue(){
        if(this.head == null){
            throw new Exception("Queue is empty");
        }
        int val = this.head.val;
        this.head = this.head.next;
        return val;
    }

    public void print(){
        ListNode curr = this.head;
        while(curr != null){
            Console.Write(curr.val + " ");
            curr = curr.next;
        }
        Console.WriteLine();
    }
}