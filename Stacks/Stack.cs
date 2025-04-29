using System;
using System.Collections;

// Implementing a stack is trivial using a dynamic array

public class Stack{
    ArrayList stack = new ArrayList();
    public Stack(){}

    public void Push(int n){
        stack.Add(n);
    }
    public int Pop(){
        if(Size() > 0){
            int element = (int)stack[Size() - 1];
            stack.RemoveAt(Size() - 1);
            return element;
        }
        return -1;
    }
    public int Peek(){
        if(Size() > 0){
            return (int)stack[Size() - 1];
        }
        return -1;
    }
    public int Size(){
        return stack.Count;
    }
}