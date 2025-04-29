from typing import Any

class Stack:
    def __init__(self):
        self.stack = []
    def push(self, n:Any):
        self.stack.append(n)
    def pop(self)->Any:
        return self.stack.pop()
    def peek(self)->Any:
        return self.stack[-1]